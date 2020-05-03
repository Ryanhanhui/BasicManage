using BasicManage.Areas.SystemFrame.LogicL;
using BasicManage.Entities;
using BasicManage.Tool;
using BasicManage.Tool.Interface;
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
        private readonly ICacheHelper _cacheHelper;
        public HomeController(MyDBContext context, ICacheHelper cacheHelper)
        {
            _dbContext = context;
            _cacheHelper = cacheHelper;
            util = new PublicUtil();
            home = new Home(_dbContext, _cacheHelper);
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