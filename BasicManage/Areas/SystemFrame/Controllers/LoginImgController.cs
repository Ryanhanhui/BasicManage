using BasicManage.Entities;
using BasicManage.Tool;
using BasicManage.Tool.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace BasicManage.Areas.SystemFrame.Controllers
{
    [Area("SystemFrame")]
    public class LoginImgController : Controller
    {
        private readonly MyDBContext _dbContext;
        private readonly IConfiguration _config;
        private readonly IHostingEnvironment _host;
        PublicUtil util;
        BasicManage.Areas.SystemFrame.LogicL.LoginImg lgimg ;
        private readonly ICacheHelper _cacheHelper;
        public LoginImgController(MyDBContext context, IConfiguration config, IHostingEnvironment host, ICacheHelper cacheHelper)
        {
            _dbContext = context;
            _config = config;
            _host = host;
            _cacheHelper = cacheHelper;
            lgimg = new LogicL.LoginImg(_dbContext,_cacheHelper);
            util = new PublicUtil();
        }
        //
        // GET: /LoginImg/
        [Authorize]
        public ActionResult LoginImgIndex()
        {
            if (!util.CheckPower(Request.GetEncodedUrl(), _dbContext, _cacheHelper))
                return PartialView("WithoutPower");
            ViewBag.SysDown = _config["DownLoadPath:SysDown"].ToString();
            ViewBag.Model = lgimg.GetAllData();
            return View();
        }
        [Authorize]
        [HttpPost]
        public string AddData()
        {
            string imgurl = Request.Form["ImgUrl"].ToString();
            return lgimg.AddData(imgurl);
        }
        [Authorize]
        [HttpPost]
        public string DeleteData()
        {
            if (!string.IsNullOrWhiteSpace(Request.Form["ImgId"]) && !string.IsNullOrWhiteSpace(Request.Form["ImgUrl"]))
            {
                try
                {
                    string sysDown = _config["DownLoadPath:SysDown"].ToString();
                    string oldpath = _host.WebRootPath+sysDown + Request.Form["ImgUrl"].ToString();
                    System.IO.File.Delete(oldpath);
                }
                catch (Exception ex)
                {
                    LogHandle.GetInstance().Error(ex.Message, GetType().ToString());
                    return string.Empty;
                }
                return lgimg.DeleteData(Request.Form["ImgId"].ToString());
            }
            return "";
        }
	}
}