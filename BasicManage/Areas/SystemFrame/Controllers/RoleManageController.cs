using BasicManage.Entities;
using BasicManage.Tool;
using BasicManage.Tool.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicManage.Areas.SystemFrame.Controllers
{
    [Area("SystemFrame")]
    public class RoleManageController : Controller
    {
        private readonly MyDBContext _dbContext;
        PublicUtil util;
        BasicManage.Areas.SystemFrame.LogicL.RoleManage roleManage;
        private readonly ICacheHelper _cacheHelper;
        public RoleManageController(MyDBContext context, ICacheHelper cacheHelper)
        {
            _dbContext = context;
            _cacheHelper = cacheHelper;
            roleManage = new LogicL.RoleManage(_dbContext, _cacheHelper);
            util = new PublicUtil();
        }
        //
        // GET: /RoleManage/
        [Authorize]
        public ActionResult Index()
        {
            if (!util.CheckPower(Request.GetEncodedUrl(), _dbContext, _cacheHelper))
                return PartialView("WithoutPower");
            ViewBag.PageCount = roleManage.GetDataCount();
            return PartialView();
        }
        [Authorize]
        [HttpPost]
        public string GetData(int currpage, int pagesize)
        {
            return roleManage.GetData(currpage, pagesize);
        }
        [Authorize]
        public ActionResult DetialPage()
        {
            ViewBag.RStatus = Request.Query["status"].ToString();
            if(!Request.Query["status"].ToString().Equals("add"))
            {
                
                ViewBag.RId = Request.Query["id"].ToString();
            }
            return PartialView();
        }
        [Authorize]
        [HttpPost]
        public string GetDetail(string Id)
        {
            return roleManage.GetDetail(Id);
        }
        [Authorize]
        [HttpPost]
        public string AddData()
        {
            SYS_RoleInfo sysRoleInfo = new SYS_RoleInfo();
            sysRoleInfo.RoleName = Request.Form["RoleName"].ToString();
            sysRoleInfo.RoleDesc = Request.Form["RoleDesc"].ToString();
            sysRoleInfo.RoleIndexPage = Request.Form["RoleIndexPage"].ToString();
            return roleManage.AddData(sysRoleInfo);
        }
        [Authorize]
        [HttpPost]
        public string UpdateData()
        {
            SYS_RoleInfo sysRoleInfo = new SYS_RoleInfo();
            sysRoleInfo.Id = Request.Form["Id"].ToString();
            sysRoleInfo.RoleName = Request.Form["RoleName"].ToString();
            sysRoleInfo.RoleDesc = Request.Form["RoleDesc"].ToString();
            sysRoleInfo.RoleIndexPage = Request.Form["RoleIndexPage"].ToString();
            return roleManage.UpdateData(sysRoleInfo);
        }
        [Authorize]
        [HttpPost]
        public string DeleteData()
        {
            if (!string.IsNullOrWhiteSpace(Request.Form["Id"]))
                return roleManage.DeleteData(Request.Form["Id"].ToString());
            else
                return "";
        }
        [Authorize]
        public ActionResult PowerPage()
        {
            ViewBag.RoleId = Request.Query["Id"].ToString();
            return PartialView();
        }
        [Authorize]
        [HttpPost]
        public string GetRolePower()
        {
            string roleId = Request.Form["RoleId"].ToString();
            return roleManage.GetRolePower(roleId);
        }
        [Authorize]
        [HttpPost]
        public string UpdateRolePower()
        {
            string roleId = Request.Form["roleId"].ToString();
            List<SYS_RolePower> sysRolePowers = new List<SYS_RolePower>();
            foreach (string key in Request.Form.Keys)
            {
                if (key.Equals("roleId")) continue;
                string[] nddid = Request.Form[key].ToString().Split('|');
                SYS_RolePower sysRolePower = new SYS_RolePower();
                sysRolePower.RoleId = roleId;
                sysRolePower.NodeId = nddid[0];
                sysRolePower.PowerId = Guid.NewGuid().ToString("N");
                sysRolePowers.Add(sysRolePower);
                if (!sysRolePowers.Any(u => u.NodeId == nddid[1]))
                {
                    SYS_RolePower parentpower = new SYS_RolePower();
                    parentpower.RoleId = roleId;
                    parentpower.NodeId = nddid[1];
                    parentpower.PowerId = Guid.NewGuid().ToString("N");
                    sysRolePowers.Add(parentpower);
                }
            }
            return roleManage.UpdateRolePower(sysRolePowers,roleId);
        }
	}
}