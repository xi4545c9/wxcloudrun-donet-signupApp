using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class SignupRequest
{
    public string 单位名 { get; set; }
    public bool 会员 { get; set; }
    public string 单位联系人 { get; set; }
    public string 单位联系人移动电话 { get; set; }
}

public class SignupResponse
{
    public string 单位名 { get; set; }
    public bool 会员 { get; set; }
    public string 单位联系人 { get; set; }
    public string 单位联系人移动电话 { get; set; }
}

namespace aspnetapp.Controllers
{
    [Route("api/signup")]
    [ApiController]
    public class SignupController : ControllerBase
    {
        private readonly SignupContext _context;

        public SignupController(SignupContext context)
        {
            _context = context;
        }

        private async Task<Signup> getSignup()
        {
            var signups = await _context.Signups.ToListAsync();
            return signups[0];
        }

        [HttpPost]
        public async Task<ActionResult<SignupResponse>> PostSignup(SignupRequest postData)
        {
            var signup = await getSignup();
            signup.单位名 = postData.单位名;
            signup.会员 = postData.会员;
            signup.单位联系人 = postData.单位联系人;
            signup.单位联系人移动电话 = postData.单位联系人移动电话;
            await _context.SaveChangesAsync();
            return new SignupResponse();
        }
    }
}

