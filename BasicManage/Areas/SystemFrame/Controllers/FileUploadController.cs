using System;
using System.Linq;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace BasicManage.Areas.SystemFrame.Controllers
{
    [Area("SystemFrame")]
    public class FileUploadController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IHostingEnvironment _host;
        private readonly string sysDown;
        private readonly string userDown;
        public FileUploadController(IConfiguration config,IHostingEnvironment host)
        {
            _config = config;
            _host = host;
            sysDown= _config["DownLoadPath:SysDown"].ToString();
            userDown= _config["DownLoadPath:UserDown"].ToString();
        }
        //
        // GET: /FileUpload/
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 单文件上传
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        [RequestSizeLimit(20971520)]
        public string UploadSingleFile()
        {
            string filetype = string.Empty, folder = string.Empty, oldpath = string.Empty;
            string newfilepath = string.Empty, newfile = string.Empty;
            if (!string.IsNullOrEmpty(Request.Form["type"]))
                filetype = Request.Form["type"].ToString();
            if (!string.IsNullOrEmpty(Request.Form["folder"]))
                folder = Request.Form["folder"].ToString();
            if (!string.IsNullOrEmpty(Request.Form["oldpath"]))
                oldpath = Request.Form["oldpath"].ToString();

            if (filetype.Equals("1"))
            {
                oldpath = _host.WebRootPath + sysDown + oldpath;
                newfilepath = _host.WebRootPath + sysDown + folder + "/";
            }
            else if (filetype.Equals("0"))
            {
                oldpath = _host.WebRootPath + userDown + oldpath;
                newfilepath = _host.WebRootPath + userDown + folder + "/";
            }
            try
            {
                if(!string.IsNullOrEmpty(Request.Form["oldpath"]))
                    System.IO.File.Delete(oldpath);
            }
            catch
            { }
            if (!Directory.Exists(newfilepath))
            {
                Directory.CreateDirectory(newfilepath);
            }
            if (Request.Form.Files.Count == 0)
            {
                //Request.Files.Count 文件数为0上传不成功
                return "Error";
            }

            var file = Request.Form.Files[0];
            if (file.Length == 0)
            {
                //文件大小大（以字节为单位）为0时，做一些操作
                return "Error0";
            }
            else
            {
                //文件大小不为0
                file = Request.Form.Files[0];
                //保存成自己的文件全路径,newfile就是你上传后保存的文件,
                //服务器上的UpLoadFile文件夹必须有读写权限
                string fileextension = System.IO.Path.GetExtension(file.FileName);
                string filename = Guid.NewGuid().ToString("N") + fileextension;
                newfile = folder + "/" + filename;
                string newfilename = newfilepath + filename;
                using (FileStream fileStream = new FileStream(newfilename, FileMode.Create))
                {
                    file.CopyToAsync(fileStream).Wait();
                }
                return newfile;
            }
        }
    }
}