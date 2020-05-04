using BasicManage.Entities;
using BasicManage.Tool;
using BasicManage.Tool.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BasicManage.Areas.SystemFrame.Controllers
{
    [Area("SystemFrame")]
    public class SysConfigController : Controller
    {
        private readonly MyDBContext _dbContext;
        private readonly IConfiguration _config;
        PublicUtil util;
        BasicManage.Areas.SystemFrame.LogicL.SysConfig sysConfig;
        private readonly ICacheHelper _cacheHelper;
        public SysConfigController(MyDBContext context, IConfiguration config, ICacheHelper cacheHelper)
        {
            _dbContext = context;
            _config = config;
            _cacheHelper = cacheHelper;
            sysConfig = new LogicL.SysConfig(_dbContext, _cacheHelper);
            util = new PublicUtil();
        }
        //
        // GET: /SysConfig/
        [Authorize]
        public ActionResult Index()
        {
            if (!util.CheckPower(Request.GetEncodedUrl(), _dbContext, _cacheHelper))
                return PartialView("WithoutPower");
            ViewBag.SysDown = _config["DownLoadPath:SysDown"].ToString();
            SYS_SystemConfigInfo sysmodel = sysConfig.GetBindData();
            ViewBag.Id = "";
            ViewBag.System_Name = "";
            ViewBag.LoginFooter = "";
            ViewBag.MainFooter = "";
            ViewBag.PhoneAddress = "";
            ViewBag.PhoneQR = "";
            if(sysmodel!=null)
            {
                ViewBag.Id = sysmodel.Id;
                ViewBag.System_Name = sysmodel.System_Name;
                ViewBag.LoginFooter = sysmodel.LoginFooter;
                ViewBag.MainFooter = sysmodel.MainFooter;
                ViewBag.PhoneAddress = sysmodel.PhoneAddress;
                ViewBag.PhoneQR = sysmodel.PhoneQR;
            }
            return PartialView();
        }
        [Authorize]
        [HttpPost]
        public string UpdateData()
        {
            SYS_SystemConfigInfo sysconfig = new SYS_SystemConfigInfo();
            if(!string.IsNullOrWhiteSpace(Request.Form["Id"]))
                sysconfig.Id = Request.Form["Id"].ToString();
            sysconfig.System_Name = Request.Form["System_Name"].ToString();
            sysconfig.LoginFooter = Request.Form["LoginFooter"].ToString();
            sysconfig.MainFooter = Request.Form["MainFooter"].ToString();
            sysconfig.PhoneAddress = Request.Form["PhoneAddress"].ToString();
            sysconfig.PhoneQR = Request.Form["PhoneQR"].ToString();
            return sysConfig.UpdateData(sysconfig);
        }
	}
}