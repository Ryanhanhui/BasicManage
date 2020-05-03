using BasicManage.Entities;
using BasicManage.Tool;
using BasicManage.Tool.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicManage.Areas.SystemFrame.LogicL
{
    public class NodeManage
    {
        private readonly MyDBContext mdb;
        PublicUtil putil;
        private readonly ICacheHelper cacheHelper;
        private const string tableCacheKey = "NodeSetInfo";
        public NodeManage(MyDBContext _context, ICacheHelper _cacheHelper)
        {
            mdb = _context;
            cacheHelper = _cacheHelper;
            putil = new PublicUtil();
        }
        /// <summary>
        /// 获取树节点所有数据
        /// </summary>
        /// <returns>节点数据集合</returns>
        public string GetNodeTreeData()
        {
            List<NodeSetInfo> nodemodel = null;
            if (cacheHelper.Exists(tableCacheKey))
                nodemodel = cacheHelper.GetCache<List<NodeSetInfo>>(tableCacheKey).OrderBy(u => u.NodeNum).ToList();
            else
                nodemodel = mdb.NodeSetInfo.OrderBy(u => u.NodeNum).ToList();
            return putil.GetJsonData(nodemodel);
        }
        public string GetNodeTreeDataBusiness()
        {
            List<NodeSetInfo> nodemodel = null;
            if (cacheHelper.Exists(tableCacheKey))
                nodemodel = cacheHelper.GetCache<List<NodeSetInfo>>(tableCacheKey).Where(u => u.NodeType.Equals("0") && u.Status.Equals("1")).ToList();
            else
                nodemodel = mdb.NodeSetInfo.Where(u => u.NodeType.Equals("0") && u.Status.Equals("1")).ToList();
            return putil.GetJsonData(nodemodel);
        }
        /// <summary>
        /// 根据id获取对应树节点数据
        /// </summary>
        /// <param name="Id">ID</param>
        /// <returns>节点数据</returns>
        public string GetSingleData(string Id)
        {
            if (string.IsNullOrWhiteSpace(Id))
                return "null";
            NodeSetInfo nodemodel = null;
            if (cacheHelper.Exists(tableCacheKey))
                nodemodel = cacheHelper.GetCache<List<NodeSetInfo>>(tableCacheKey).Where(u => u.Id == Id).ToList().FirstOrDefault();
            else
                nodemodel = mdb.NodeSetInfo.Where(u => u.Id == Id).ToList().FirstOrDefault();
            return putil.GetJsonData(nodemodel);
        }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="nodesetinfo">树节点</param>
        /// <returns>标志,成功 success,不成功为空</returns>
        public string AddNode(NodeSetInfo nodesetinfo)
        {
            try
            {
                nodesetinfo.Id = Guid.NewGuid().ToString("N");
                mdb.NodeSetInfo.Add(nodesetinfo);
                int ret = mdb.SaveChanges();
                if (ret != 0)
                {
                    cacheHelper.SetCache(tableCacheKey, mdb.NodeSetInfo.ToList());
                    cacheHelper.SetCache("v_getuserpower", mdb.v_getuserpower.ToList());
                    LogHandle.GetInstance().Info("【添加数据】" + BasicManage.Tool.UserInfo.GetInstance().UserId + " 添加节点信息", GetType().ToString());
                    return "success";
                }
                else
                    return "";
            }
            catch (Exception ex)
            {
                LogHandle.GetInstance().Error(ex.Message, GetType().ToString());
                return "";
            }
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="nodesetinfo">树节点</param>
        /// <returns>标志,成功 success,不成功为空</returns>
        public string UpdateData(NodeSetInfo nodesetinfo)
        {
            try
            {
                EntityEntry<NodeSetInfo> entry = mdb.Entry<NodeSetInfo>(nodesetinfo);
                entry.State = EntityState.Unchanged;
                entry.Property("NodeName").IsModified = true;
                entry.Property("NodeUrl").IsModified = true;
                entry.Property("NodeType").IsModified = true;
                entry.Property("NodeNum").IsModified = true;
                entry.Property("Status").IsModified = true;
                int ret = mdb.SaveChanges();
                if (ret != 0)
                {
                    cacheHelper.SetCache(tableCacheKey, mdb.NodeSetInfo.ToList());
                    cacheHelper.SetCache("v_getuserpower", mdb.v_getuserpower.ToList());
                    LogHandle.GetInstance().Info("【更新数据】" + BasicManage.Tool.UserInfo.GetInstance().UserId + " 更新节点信息", GetType().ToString());
                    return "success";
                }
                else
                    return "";
            }
            catch (Exception ex)
            {
                LogHandle.GetInstance().Error(ex.Message, GetType().ToString());
                return "";
            }
        }
        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="Id">Id</param>
        /// <returns>标志,成功 success,不成功为空</returns>
        public string DeleteNode(string Id)
        {
            try
            {
                NodeSetInfo nodesetinfo = mdb.NodeSetInfo.Where(u => u.Id == Id).FirstOrDefault();
                mdb.NodeSetInfo.Remove(nodesetinfo);//删除实体
                int ret = mdb.SaveChanges();
                if (ret != 0)
                {
                    cacheHelper.SetCache(tableCacheKey, mdb.NodeSetInfo.ToList());
                    cacheHelper.SetCache("v_getuserpower", mdb.v_getuserpower.ToList());
                    LogHandle.GetInstance().Info("【删除数据】" + BasicManage.Tool.UserInfo.GetInstance().UserId + " 删除节点信息", GetType().ToString());
                    return "success";
                }
                else
                    return "";
            }
            catch (Exception ex)
            {
                LogHandle.GetInstance().Error(ex.Message, GetType().ToString());
                return "";
            }
        }
    }
}