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
    public string 参会人1姓名 { get; set; }
    public string 参会人1号码 { get; set; }
    public string 参会人1职务 { get; set; }
    public string 参会人2姓名 { get; set; }
    public string 参会人2号码 { get; set; }
    public string 参会人2职务 { get; set; }
    public string 参会人3姓名 { get; set; }
    public string 参会人3号码 { get; set; }
    public string 参会人3职务 { get; set; }
    public string 参会人4姓名 { get; set; }
    public string 参会人4号码 { get; set; }
    public string 参会人4职务 { get; set; }
    public string 参会人5姓名 { get; set; }
    public string 参会人5号码 { get; set; }
    public string 参会人5职务 { get; set; }
    public string 参会人6姓名 { get; set; }
    public string 参会人6号码 { get; set; }
    public string 参会人6职务 { get; set; }
    public string 参会人7姓名 { get; set; }
    public string 参会人7号码 { get; set; }
    public string 参会人7职务 { get; set; }
    public string 参会人8姓名 { get; set; }
    public string 参会人8号码 { get; set; }
    public string 参会人8职务 { get; set; }
    public string 参会人9姓名 { get; set; }
    public string 参会人9号码 { get; set; }
    public string 参会人9职务 { get; set; }
    public string 参会人10姓名 { get; set; }
    public string 参会人10号码 { get; set; }
    public string 参会人10职务 { get; set; }
    public string 参会人11姓名 { get; set; }
    public string 参会人11号码 { get; set; }
    public string 参会人11职务 { get; set; }
    public string 参会人12姓名 { get; set; }
    public string 参会人12号码 { get; set; }
    public string 参会人12职务 { get; set; }
    public string 参会人13姓名 { get; set; }
    public string 参会人13号码 { get; set; }
    public string 参会人13职务 { get; set; }
    public string 参会人14姓名 { get; set; }
    public string 参会人14号码 { get; set; }
    public string 参会人14职务 { get; set; }
    public string 参会人15姓名 { get; set; }
    public string 参会人15号码 { get; set; }
    public string 参会人15职务 { get; set; }
    public string 备注 { get; set; }
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
    public string 参会人1姓名 { get; set; }
    public string 参会人1号码 { get; set; }
    public string 参会人1职务 { get; set; }
    public string 参会人2姓名 { get; set; }
    public string 参会人2号码 { get; set; }
    public string 参会人2职务 { get; set; }
    public string 参会人3姓名 { get; set; }
    public string 参会人3号码 { get; set; }
    public string 参会人3职务 { get; set; }
    public string 参会人4姓名 { get; set; }
    public string 参会人4号码 { get; set; }
    public string 参会人4职务 { get; set; }
    public string 参会人5姓名 { get; set; }
    public string 参会人5号码 { get; set; }
    public string 参会人5职务 { get; set; }
    public string 参会人6姓名 { get; set; }
    public string 参会人6号码 { get; set; }
    public string 参会人6职务 { get; set; }
    public string 参会人7姓名 { get; set; }
    public string 参会人7号码 { get; set; }
    public string 参会人7职务 { get; set; }
    public string 参会人8姓名 { get; set; }
    public string 参会人8号码 { get; set; }
    public string 参会人8职务 { get; set; }
    public string 参会人9姓名 { get; set; }
    public string 参会人9号码 { get; set; }
    public string 参会人9职务 { get; set; }
    public string 参会人10姓名 { get; set; }
    public string 参会人10号码 { get; set; }
    public string 参会人10职务 { get; set; }
    public string 参会人11姓名 { get; set; }
    public string 参会人11号码 { get; set; }
    public string 参会人11职务 { get; set; }
    public string 参会人12姓名 { get; set; }
    public string 参会人12号码 { get; set; }
    public string 参会人12职务 { get; set; }
    public string 参会人13姓名 { get; set; }
    public string 参会人13号码 { get; set; }
    public string 参会人13职务 { get; set; }
    public string 参会人14姓名 { get; set; }
    public string 参会人14号码 { get; set; }
    public string 参会人14职务 { get; set; }
    public string 参会人15姓名 { get; set; }
    public string 参会人15号码 { get; set; }
    public string 参会人15职务 { get; set; }
    public string 备注 { get; set; }
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
            signup.参会人1姓名 = postData.参会人1姓名;
            signup.参会人1号码 = postData.参会人1号码;
            signup.参会人1职务 = postData.参会人1职务;
            signup.参会人2姓名 = postData.参会人2姓名;
            signup.参会人2号码 = postData.参会人2号码;
            signup.参会人2职务 = postData.参会人2职务;
            signup.参会人3姓名 = postData.参会人3姓名;
            signup.参会人3号码 = postData.参会人3号码;
            signup.参会人3职务 = postData.参会人3职务;
            signup.参会人4姓名 = postData.参会人4姓名;
            signup.参会人4号码 = postData.参会人4号码;
            signup.参会人4职务 = postData.参会人4职务;
            signup.参会人5姓名 = postData.参会人5姓名;
            signup.参会人5号码 = postData.参会人5号码;
            signup.参会人5职务 = postData.参会人5职务;
            signup.参会人6姓名 = postData.参会人6姓名;
            signup.参会人6号码 = postData.参会人6号码;
            signup.参会人6职务 = postData.参会人6职务;
            signup.参会人7姓名 = postData.参会人7姓名;
            signup.参会人7号码 = postData.参会人7号码;
            signup.参会人7职务 = postData.参会人7职务;
            signup.参会人8姓名 = postData.参会人8姓名;
            signup.参会人8号码 = postData.参会人8号码;
            signup.参会人8职务 = postData.参会人8职务;
            signup.参会人9姓名 = postData.参会人9姓名;
            signup.参会人9号码 = postData.参会人9号码;
            signup.参会人9职务 = postData.参会人9职务;
            signup.参会人10姓名 = postData.参会人10姓名;
            signup.参会人10号码 = postData.参会人10号码;
            signup.参会人10职务 = postData.参会人10职务;
            signup.参会人11姓名 = postData.参会人11姓名;
            signup.参会人11号码 = postData.参会人11号码;
            signup.参会人11职务 = postData.参会人11职务;
            signup.参会人12姓名 = postData.参会人12姓名;
            signup.参会人12号码 = postData.参会人12号码;
            signup.参会人12职务 = postData.参会人12职务;
            signup.参会人13姓名 = postData.参会人13姓名;
            signup.参会人13号码 = postData.参会人13号码;
            signup.参会人13职务 = postData.参会人13职务;
            signup.参会人14姓名 = postData.参会人14姓名;
            signup.参会人14号码 = postData.参会人14号码;
            signup.参会人14职务 = postData.参会人14职务;
            signup.参会人15姓名 = postData.参会人15姓名;
            signup.参会人15号码 = postData.参会人15号码;
            signup.参会人15职务 = postData.参会人15职务;
            signup.备注 = postData.备注;
            await _context.SaveChangesAsync();
            return new SignupResponse
            {
                单位名 = signup.单位名,
                单位联系人 = signup.单位联系人,
                单位联系人移动电话 = signup.单位联系人移动电话,
                标间数=signup.标间数,
                单间数 = signup.单间数,
                入住日期=signup.入住日期,
                离开日期 = signup.离开日期,
                参会人1姓名 =signup.参会人1姓名 ,
                参会人1号码 =signup.参会人1号码 ,
                参会人1职务 =signup.参会人1职务 ,
                参会人2姓名 =signup.参会人2姓名 ,
                参会人2号码 =signup.参会人2号码 ,
                参会人2职务 =signup.参会人2职务 ,
                参会人3姓名 =signup.参会人3姓名 ,
                参会人3号码 =signup.参会人3号码 ,
                参会人3职务 =signup.参会人3职务 ,
                参会人4姓名 =signup.参会人4姓名 ,
                参会人4号码 =signup.参会人4号码 ,
                参会人4职务 =signup.参会人4职务 ,
                参会人5姓名 =signup.参会人5姓名 ,
                参会人5号码 =signup.参会人5号码 ,
                参会人5职务 =signup.参会人5职务 ,
                参会人6姓名 =signup.参会人6姓名 ,
                参会人6号码 =signup.参会人6号码 ,
                参会人6职务 =signup.参会人6职务 ,
                参会人7姓名 =signup.参会人7姓名 ,
                参会人7号码 =signup.参会人7号码 ,
                参会人7职务 =signup.参会人7职务 ,
                参会人8姓名 =signup.参会人8姓名 ,
                参会人8号码 =signup.参会人8号码 ,
                参会人8职务 =signup.参会人8职务 ,
                参会人9姓名 =signup.参会人9姓名 ,
                参会人9号码 =signup.参会人9号码 ,
                参会人9职务 =signup.参会人9职务 ,
                参会人10姓名=signup.参会人10姓名,
                参会人10号码=signup.参会人10号码,
                参会人10职务=signup.参会人10职务,
                参会人11姓名=signup.参会人11姓名,
                参会人11号码=signup.参会人11号码,
                参会人11职务=signup.参会人11职务,
                参会人12姓名=signup.参会人12姓名,
                参会人12号码=signup.参会人12号码,
                参会人12职务=signup.参会人12职务,
                参会人13姓名=signup.参会人13姓名,
                参会人13号码=signup.参会人13号码,
                参会人13职务=signup.参会人13职务,
                参会人14姓名=signup.参会人14姓名,
                参会人14号码=signup.参会人14号码,
                参会人14职务=signup.参会人14职务,
                参会人15姓名=signup.参会人15姓名,
                参会人15号码=signup.参会人15号码,
                参会人15职务=signup.参会人15职务,
                备注=signup.备注
            };
        }
    }
}

