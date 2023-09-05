using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class SignupRequest
{
    public string unitName { get; set; }
    public bool isVIP { get; set; }
    public string UnitMainPerson { get; set; }
    public string UnitMainPersonPhone { get; set; }
}

public class SignupResponse
{
    public string unitName { get; set; }
    public bool isVIP { get; set; }
    public string UnitMainPerson { get; set; }
    public string UnitMainPersonPhone { get; set; }
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
            signup.id = _context.Signups.Count();
            signup.unitName = postData.unitName;
            signup.isVIP = postData.isVIP;
            signup.UnitMainPerson = postData.UnitMainPerson;
            signup.UnitMainPersonPhone = postData.UnitMainPersonPhone;
            await _context.SaveChangesAsync();
            return new SignupResponse
            {
                unitName = signup.unitName,
                isVIP = signup.isVIP,
                UnitMainPerson = signup.UnitMainPerson,
                UnitMainPersonPhone = signup.UnitMainPersonPhone
            };
        }
    }
}

