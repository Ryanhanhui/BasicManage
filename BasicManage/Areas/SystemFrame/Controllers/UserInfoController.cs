
using BasicManage.Entities;
using BasicManage.Tool;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace BasicManage.Areas.SystemFrame.Controllers
{
    [Area("SystemFrame")]
    public class UserInfoController : Controller
    {
        private readonly MyDBContext _dbContext;
        PublicUtil util;
        BasicManage.Areas.SystemFrame.LogicL.UserInfo usi;
        public UserInfoController(MyDBContext context)
        {
            _dbContext = context;
            usi = new LogicL.UserInfo(_dbContext);
            util = new PublicUtil();
        }
        //
        // GET: /UserInfo/
        [Authorize]
        public ActionResult Index()
        {
            if (!util.CheckPower(Request.GetEncodedUrl(),_dbContext))
                return PartialView("WithoutPower");
            ViewBag.PageCount = usi.GetDataCount();
            return PartialView();
        }
        [Authorize]
        public ActionResult EditPage()
        {
            if(!string.IsNullOrEmpty(Request.Query["UserId"]))
            {
                ViewBag.RStatus = "edit";
                v_userinfo pr = usi.GetEditInfo(Request.Query["UserId"].ToString());
                ViewBag.Model = pr;
            }
            else
            {
                ViewBag.RStatus = "add";
                v_userinfo pr = new v_userinfo();
                ViewBag.Model = pr;
            }
            return View();
        }
        [Authorize]
        [HttpPost]
        public string UpdateData()
        {
            PR_UserInfo pr = new PR_UserInfo();
            pr.Id = Request.Form["Id"].ToString();
            pr.UserId = Request.Form["UserId"].ToString();
            pr.NickName = Request.Form["NickName"].ToString();
            pr.Name = Request.Form["Name"].ToString();
            pr.Sex = Request.Form["Sex"].ToString();
            if (string.IsNullOrWhiteSpace(Request.Form["Age"]))
                pr.Age = null;
            else
                pr.Age = int.Parse(Request.Form["Age"]);
            pr.Remark = Request.Form["Remark"].ToString();
            return usi.UpdateData(pr);
        }
        [Authorize]
        public ActionResult PwdPage()
        {
            if (!string.IsNullOrEmpty(Request.Query["UserId"]))
            {
                ViewBag.RStatus = "edit";
                v_userinfo pr = usi.GetEditInfo(Request.Query["UserId"].ToString());
                ViewBag.Model = pr;
            }
            return View();
        }
        [Authorize]
        [HttpPost]
        public string UpdatePwdData()
        {
            string oldpwd = Request.Form["oldPwdField"].ToString();
            string newpwd = Request.Form["newPwdField"].ToString();
            string newpwdconfirm = Request.Form["newPwd1Field"].ToString();
            string pid = Request.Form["Id"].ToString();
            return usi.UpdatePwdData(pid, oldpwd, newpwd, newpwdconfirm);
        }
        [Authorize]
        [HttpPost]
        public string GetData()
        {
            int currpage=int.Parse(Request.Form["currpage"].ToString());
            int pagesize = int.Parse(Request.Form["pagesize"].ToString());
            v_userinfo prUserinfo = new v_userinfo();
            prUserinfo.UserId = Request.Form["UserId"].ToString();
            prUserinfo.Name = Request.Form["Name"].ToString();
            ViewBag.PageCount = usi.GetDataCount(prUserinfo);
            return usi.GetData(currpage, pagesize,prUserinfo);
        }
        [Authorize]
        [HttpPost]
        public string AddData()
        {
            PR_UserInfo pr = new PR_UserInfo();
            pr.UserId = Request.Form["UserId"].ToString();
            pr.NickName = Request.Form["NickName"].ToString();
            pr.Name = Request.Form["Name"].ToString();
            pr.Sex = Request.Form["Sex"].ToString();
            if (string.IsNullOrWhiteSpace(Request.Form["Age"]))
                pr.Age = null;
            else
                pr.Age = int.Parse(Request.Form["Age"]);
            pr.Remark = Request.Form["Remark"].ToString();
            pr.UserType = "0";
            pr.Password = "10470c3b4b1fed12c3baac014be15fac67c6e815";
            return usi.AddData(pr);
        }
        [Authorize]
        [HttpPost]
        public string DeleteData()
        {
            if (!string.IsNullOrWhiteSpace(Request.Form["Id"]))
                return usi.DeleteData(Request.Form["Id"].ToString());
            else
                return "";
        }
        [Authorize]
        [HttpPost]
        public string GetDataCount()
        {
            v_userinfo prUserinfo = new v_userinfo();
            prUserinfo.UserId = Request.Form["UserId"].ToString();
            prUserinfo.Name = Request.Form["Name"].ToString();
            return usi.GetDataCount(prUserinfo).ToString();
        }
        [Authorize]
        public ActionResult RoleSetPage()
        {
            if (!string.IsNullOrEmpty(Request.Query["UserId"]))
            {
                v_userinfo pr = usi.GetEditInfo(Request.Query["UserId"].ToString());
                ViewBag.Model = pr;
            }
            else
            {
                v_userinfo pr = new v_userinfo();
                ViewBag.Model = pr;
            }
            return View();
        }
        [Authorize]
        [HttpPost]
        public string GetRoleList()
        {
            return usi.GetRoleList();
        }
        [Authorize]
        [HttpPost]
        public string SetUserRole()
        {
            string pid = Request.Form["Id"].ToString();
            string roletype = Request.Form["RoleType"].ToString();
            PR_UserInfo pruserinfo = new PR_UserInfo();
            pruserinfo.Id = pid;
            pruserinfo.RoleType = roletype;
            return usi.SetUserRole(pruserinfo);
        }
        [Authorize]
        [HttpPost]
        public string ResetPassword()
        {
            if (!string.IsNullOrWhiteSpace(Request.Form["Id"]))
                return usi.ResetPassword(Request.Form["Id"].ToString());
            else
                return "";
        }
	}
}