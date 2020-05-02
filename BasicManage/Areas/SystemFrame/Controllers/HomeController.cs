using BasicManage.Areas.SystemFrame.LogicL;
using BasicManage.Entities;
using BasicManage.Tool;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasicManage.Areas.SystemFrame.Controllers
{
    [Area("SystemFrame")]
    public class HomeController : Controller
    {
        private readonly MyDBContext _dbContext;
        PublicUtil util ;
        Home home ;
        public HomeController(MyDBContext context)
        {
            _dbContext = context;
            util = new PublicUtil();
            home = new Home(_dbContext);
        }
        //
        // GET: /Home/
        public ActionResult Index()
        {
            if (!util.CheckLoginState())
                return RedirectToAction("Login", "PRSignIn",new { area="SystemFrame"});
            SYS_SystemConfigInfo sysconfig = home.GetSysConfig();
            ViewBag.System_Name = sysconfig.System_Name;
            ViewBag.MainFooter = sysconfig.MainFooter;
            ViewBag.PhoneQR = sysconfig.PhoneQR;
            ViewBag.RoleIndexPage = BasicManage.Tool.UserInfo.GetInstance().RoleIndexPage;
            return View("Main");
        }
        [Authorize]
        [HttpPost]
        public string GetPower()
        {
            return home.GetPower();
        }
        [Authorize]
        [HttpPost]
        public string SignOut()
        {
            HttpContext.SignOutAsync().Wait();
            return "success";
        }
	}
}