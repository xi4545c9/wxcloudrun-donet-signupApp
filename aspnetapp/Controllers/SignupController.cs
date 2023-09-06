using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class SignupRequest
{
    public string 单位名 { get; set; }
    public string 单位联系人 { get; set; }
    public string 单位联系人移动电话 { get; set; }
    public string 标间数 { get; set; }
    public string 单间数 { get; set; }
    public string 入住日期 { get; set; }
    public string 离开日期 { get; set; }
}

public class SignupResponse
{
    public string 单位名 { get; set; }
    public string 单位联系人 { get; set; }
    public string 单位联系人移动电话 { get; set; }
    public string 标间数 { get; set; }
    public string 单间数 { get; set; }
    public string 入住日期 { get; set; }
    public string 离开日期 { get; set; }
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

        private async Task<Signup> addSignup()
        {
            var signup = new Signup();
            await _context.Signups.AddAsync(signup);
            await _context.SaveChangesAsync();
            return signup;
        }

        [HttpPost]
        public async Task<ActionResult<SignupResponse>> PostSignup(SignupRequest postData)
        {
            var signup = await addSignup();
            // signup.id = _context.Signups.Count();
            signup.单位名 = postData.单位名;
            signup.单位联系人 = postData.单位联系人;
            signup.单位联系人移动电话 = postData.单位联系人移动电话;
            signup.标间数 = postData.标间数;
            signup.单间数 = postData.单间数;
            signup.入住日期 = postData.入住日期;
            signup.离开日期 = postData.离开日期;
            await _context.SaveChangesAsync();
            return new SignupResponse
            {
                单位名 = signup.单位名,
                单位联系人 = signup.单位联系人,
                单位联系人移动电话 = signup.单位联系人移动电话,
                标间数=signup.标间数,
                单间数 = signup.单间数,
                入住日期=signup.入住日期,
                离开日期 = signup.离开日期
            };
        }
    }
}

