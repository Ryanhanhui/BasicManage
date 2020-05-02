using BasicManage.Entities;
using BasicManage.Tool;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasicManage.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    public class OverViewController : Controller
    {
        private readonly MyDBContext _dbContext;
        PublicUtil util;
        BasicManage.Areas.UserArea.LogicL.OverView overView;
        public OverViewController(MyDBContext context)
        {
            _dbContext = context;
            util = new PublicUtil();
            overView = new LogicL.OverView(_dbContext);
        }
        //
        // GET: /OverView/
        [Authorize]
        public ActionResult NormalIndex()
        {
            if (!util.CheckLoginState())
                return RedirectToAction("Login", "PRSignIn");
            return View();
        }
        [Authorize]
        public ActionResult UserIndex()
        {
            if (!util.CheckLoginState())
                return RedirectToAction("Login", "PRSignIn");
            return View();
        }
	}
}