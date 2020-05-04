using BasicManage.Entities;
using BasicManage.Tool;
using BasicManage.Tool.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace BasicManage.Areas.SystemFrame.Controllers
{
    [Area("SystemFrame")]
    public class NodeManageController : Controller
    {
        private readonly MyDBContext _dbContext;
        PublicUtil util;
        BasicManage.Areas.SystemFrame.LogicL.NodeManage nodeManage;
        private readonly ICacheHelper _cacheHelper;
        public NodeManageController(MyDBContext context, ICacheHelper cacheHelper)
        {
            _dbContext = context;
            _cacheHelper = cacheHelper;
            nodeManage = new LogicL.NodeManage(_dbContext, _cacheHelper);
            util = new PublicUtil();
        }
        //
        // GET: /NodeManage/
        [Authorize]
        public ActionResult Index()
        {
            if (!util.CheckPower(Request.GetEncodedUrl(), _dbContext, _cacheHelper))
                return PartialView("WithoutPower");
            return PartialView();
        }
        [Authorize]
        public ActionResult NodeIndex()
        {
            if (!util.CheckPower(Request.GetEncodedUrl(), _dbContext, _cacheHelper))
                return PartialView("WithoutPower");
            return PartialView();
        }
        [Authorize]
        [HttpPost]
        public string GetNodeTreeData()
        {
            return nodeManage.GetNodeTreeData();
        }
        [Authorize]
        [HttpPost]
        public string GetNodeTreeDataBusiness()
        {
            return nodeManage.GetNodeTreeDataBusiness();
        }
        [Authorize]
        [HttpPost]
        public string GetSingleData(string Id)//获取指定树节点
        {
            return nodeManage.GetSingleData(Id);
        }
        [Authorize]
        [HttpPost]
        public string AddNode()
        {
            NodeSetInfo nodesetinfo = new NodeSetInfo();
            nodesetinfo.NodeName = Request.Form["NodeName"].ToString();
            if (string.IsNullOrWhiteSpace(Request.Form["NodeNum"]))
                nodesetinfo.NodeNum = null;
            else
                nodesetinfo.NodeNum = int.Parse(Request.Form["NodeNum"].ToString());
            nodesetinfo.NodeType = Request.Form["NodeType"].ToString();
            nodesetinfo.NodeUrl = Request.Form["NodeUrl"].ToString();
            if (string.IsNullOrWhiteSpace(Request.Form["ParentNode"]))
                nodesetinfo.ParentNode = null;
            else
                nodesetinfo.ParentNode = Request.Form["ParentNode"].ToString();
            nodesetinfo.Status = Request.Form["Status"].ToString();
            return nodeManage.AddNode(nodesetinfo);
        }
        [Authorize]
        [HttpPost]
        public string UpdateData()
        {
            NodeSetInfo nodesetinfo = new NodeSetInfo();
            nodesetinfo.Id = Request.Form["Id"].ToString();
            nodesetinfo.NodeName = Request.Form["NodeName"].ToString();
            nodesetinfo.NodeNum = int.Parse(Request.Form["NodeNum"].ToString());
            nodesetinfo.NodeType = Request.Form["NodeType"].ToString();
            nodesetinfo.NodeUrl = Request.Form["NodeUrl"].ToString();
            if (string.IsNullOrWhiteSpace(Request.Form["ParentNode"]))
                nodesetinfo.ParentNode = null;
            else
                nodesetinfo.ParentNode = Request.Form["ParentNode"].ToString();
            nodesetinfo.Status = Request.Form["Status"].ToString();
            return nodeManage.UpdateData(nodesetinfo);
        }
        [Authorize]
        [HttpPost]
        public string DeleteNode()
        {
            if (!string.IsNullOrWhiteSpace(Request.Form["Id"]))
                return nodeManage.DeleteNode(Request.Form["Id"].ToString());
            else
                return "";
        }
	}
}