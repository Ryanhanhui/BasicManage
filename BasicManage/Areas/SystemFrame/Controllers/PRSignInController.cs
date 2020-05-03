using BasicManage.Areas.SystemFrame.LogicL;
using BasicManage.Entities;
using BasicManage.Tool;
using BasicManage.Tool.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace BasicManage.Areas.SystemFrame.Controllers
{
    [Area("SystemFrame")]
    public class PRSignInController : Controller
    {
        private readonly IConfiguration _config;
        private readonly MyDBContext _dbContext;
        private readonly ICacheHelper _cacheHelper;
        public PRSignInController(IConfiguration config,MyDBContext context, ICacheHelper cacheHelper)
        {
            _config = config;
            _dbContext = context;
            _cacheHelper = cacheHelper;
        }
        
        //
        // GET: /PRSignIn/
        public ActionResult Login()
        {
            PRSignIn signin = new PRSignIn(_dbContext, _cacheHelper);
            ViewBag.SysDown = _config["DownLoadPath:SysDown"].ToString();
            SYS_SystemConfigInfo sysconfig = signin.GetFooter();
            ViewBag.LoginFooter = sysconfig.LoginFooter;
            ViewBag.System_Name = sysconfig.System_Name;
            LoginImg imgfunc = new LoginImg(_dbContext, _cacheHelper);
            ViewBag.BgImgs = imgfunc.GetAllData();
            return View();
        }
        [HttpPost]
        public async System.Threading.Tasks.Task<string> LoginConfirm(string username,string pwd)
        {
            PRSignIn signin = new PRSignIn(_dbContext, _cacheHelper);
            bool result = signin.LoginConfirm(username, pwd,HttpContext.Connection.RemoteIpAddress.ToString());
            if (result)
            {
                pwd = EnDecryptTil.SHA1_Encrypt(pwd);
                PR_UserInfo musers = _dbContext.PR_UserInfo.Where(u => u.UserId == username && u.Password == pwd).FirstOrDefault();
                string mguid = Guid.NewGuid().ToString("N");
                UserRepository userdata = new UserRepository();
                userdata.UserId = musers.UserId;
                userdata.NickName = musers.NickName;
                userdata.Name = musers.Name;
                userdata.RoleType = musers.RoleType;
                userdata.UserType = musers.UserType;
                RoleManage roleMa = new RoleManage(_dbContext, _cacheHelper);
                userdata.RoleIndexPage = roleMa.GetDetailObj(musers.RoleType).RoleIndexPage;
                //权限控制、身份认证
                Claim[] clainms = new[] { new Claim(musers.UserId + mguid, userdata.GetUserString()) };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(clainms, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsPrincipal),new AuthenticationProperties() { ExpiresUtc=DateTime.Now.AddHours(2),IssuedUtc=DateTime.Now});
                return "";
            }
            else
                return "用户名或密码错误";
        }
	}
}