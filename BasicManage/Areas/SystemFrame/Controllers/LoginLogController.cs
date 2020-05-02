using BasicManage.Entities;
using BasicManage.Tool;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace BasicManage.Areas.SystemFrame.Controllers
{
    [Area("SystemFrame")]
    public class LoginLogController : Controller
    {
        private readonly MyDBContext _dbContext;
        PublicUtil util;
        BasicManage.Areas.SystemFrame.LogicL.LoginLog loginlg;
        public LoginLogController(MyDBContext context)
        {
            _dbContext = context;
            loginlg = new LogicL.LoginLog(_dbContext);
            util = new PublicUtil();
        }
        //
        // GET: /LoginLog/
        [Authorize]
        public ActionResult LoginLogIndex()
        {
            if (!util.CheckPower(Request.GetEncodedUrl(), _dbContext))
                return PartialView("WithoutPower");
            ViewBag.PageCount = loginlg.GetDataCount();
            return View();
        }
        [Authorize]
        [HttpPost]
        public string GetData()
        {
            int currpage = int.Parse(Request.Form["currpage"].ToString());
            int pagesize = int.Parse(Request.Form["pagesize"].ToString());
            string begintime = Request.Form["BeginTime"].ToString();
            string endtime = Request.Form["EndTime"].ToString();
            v_sys_loginlog sysLoginLog = new v_sys_loginlog();
            sysLoginLog.UserId = Request.Form["UserId"].ToString();
            sysLoginLog.NickName = Request.Form["NickName"].ToString();
            ViewBag.PageCount = loginlg.GetDataCount(sysLoginLog,begintime,endtime);
            return loginlg.GetData(currpage, pagesize, sysLoginLog,begintime,endtime);
        }
        [Authorize]
        [HttpPost]
        public string GetDataCount()
        {
            v_sys_loginlog sysLoginLog = new v_sys_loginlog();
            sysLoginLog.UserId = Request.Form["UserId"].ToString();
            sysLoginLog.NickName = Request.Form["NickName"].ToString();
            string begintime = Request.Form["BeginTime"].ToString();
            string endtime = Request.Form["EndTime"].ToString();
            return loginlg.GetDataCount(sysLoginLog,begintime,endtime).ToString();
        }
	}
}