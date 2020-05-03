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
    public class RoleManage
    {
        PublicUtil putil = new PublicUtil();
        private readonly MyDBContext mdb;
        private readonly ICacheHelper cacheHelper;
        private const string tableCacheKey = "SYS_RoleInfo";
        public RoleManage(MyDBContext _context, ICacheHelper _cacheHelper)
        {
            mdb = _context;
            cacheHelper = _cacheHelper;
        }
        /// <summary>
        /// 获取列表数据
        /// </summary>
        /// <param name="currpage">当前页</param>
        /// <param name="pagesize">每一页个数</param>
        /// <returns>数据列表json</returns>
        public string GetData(int currpage, int pagesize)
        { 
            List<SYS_RoleInfo> sysRoleInfo = null;
            if (cacheHelper.Exists(tableCacheKey))
                sysRoleInfo = cacheHelper.GetCache<List<SYS_RoleInfo>>(tableCacheKey).OrderBy(u => u.RoleName).Skip((currpage - 1) * pagesize).Take(pagesize).ToList();
            else
                sysRoleInfo = mdb.SYS_RoleInfo.OrderBy(u => u.RoleName).Skip((currpage - 1) * pagesize).Take(pagesize).ToList();
            return putil.GetJsonData(sysRoleInfo);
        }
        /// <summary>
        /// 获取信息条数（无条件）
        /// </summary>
        /// <returns></returns>
        public int GetDataCount()
        {
            if (cacheHelper.Exists(tableCacheKey))
                return cacheHelper.GetCache<List<SYS_RoleInfo>>(tableCacheKey).ToList().Count;
            else
                return mdb.SYS_RoleInfo.ToList().Count;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id">数据ID</param>
        /// <returns>单条记录json</returns>
        public string GetDetail(string Id)
        {
            if (string.IsNullOrEmpty(Id))
                return string.Empty;
            SYS_RoleInfo sysRoleInfo = null;
            if (cacheHelper.Exists(tableCacheKey))
                sysRoleInfo = cacheHelper.GetCache<List<SYS_RoleInfo>>(tableCacheKey).Where(u => u.Id == Id).ToList().FirstOrDefault();
            else
                sysRoleInfo = mdb.SYS_RoleInfo.Where(u => u.Id == Id).ToList().FirstOrDefault();
            return putil.GetJsonData(sysRoleInfo);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id">数据ID</param>
        /// <returns></returns>
        public SYS_RoleInfo GetDetailObj(string Id)
        {
            if (string.IsNullOrEmpty(Id))
                return new SYS_RoleInfo();
            SYS_RoleInfo sysRoleInfo = null;
            if (cacheHelper.Exists(tableCacheKey))
                sysRoleInfo = cacheHelper.GetCache<List<SYS_RoleInfo>>(tableCacheKey).Where(u => u.Id == Id).ToList().FirstOrDefault();
            else
                sysRoleInfo = mdb.SYS_RoleInfo.Where(u => u.Id == Id).ToList().FirstOrDefault();
            return sysRoleInfo;
        }
        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="sysRoleInfo"></param>
        /// <returns></returns>
        public string AddData(SYS_RoleInfo sysRoleInfo)
        {
            try
            {
                if (!IsExists(sysRoleInfo))
                    return "exists";
                sysRoleInfo.Id = Guid.NewGuid().ToString("N");
                mdb.SYS_RoleInfo.Add(sysRoleInfo);
                int ret = mdb.SaveChanges();
                if (ret != 0)
                {
                    cacheHelper.SetCache(tableCacheKey, mdb.SYS_RoleInfo.ToList());
                    cacheHelper.SetCache("v_getuserpower", mdb.v_getuserpower.ToList());
                    LogHandle.GetInstance().Info("【添加数据】" + BasicManage.Tool.UserInfo.GetInstance().UserId + " 添加角色信息", GetType().ToString());
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
        private bool IsExists(SYS_RoleInfo sysRoleInfo)
        {
            int ncount = 0;
            if (cacheHelper.Exists(tableCacheKey))
                ncount = cacheHelper.GetCache<List<SYS_RoleInfo>>(tableCacheKey).Where(u => u.RoleName.Equals(sysRoleInfo.RoleName)).ToList().Count;
            else
                ncount = mdb.SYS_RoleInfo.Where(u => u.RoleName.Equals(sysRoleInfo.RoleName)).ToList().Count;
            return !(ncount > 0);
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="sysRoleInfo"></param>
        /// <returns>标志,成功 success,不成功为空</returns>
        public string UpdateData(SYS_RoleInfo sysRoleInfo)
        {
            try
            {
                EntityEntry<SYS_RoleInfo> entry = mdb.Entry<SYS_RoleInfo>(sysRoleInfo);
                entry.State = EntityState.Unchanged;
                entry.Property("RoleDesc").IsModified = true;
                entry.Property("RoleIndexPage").IsModified = true;
                int ret = mdb.SaveChanges();
                if (ret != 0)
                {
                    cacheHelper.SetCache(tableCacheKey, mdb.SYS_RoleInfo.ToList());
                    cacheHelper.SetCache("v_getuserpower", mdb.v_getuserpower.ToList());
                    LogHandle.GetInstance().Info("【更新数据】" + BasicManage.Tool.UserInfo.GetInstance().UserId + " 更新角色信息", GetType().ToString());
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
        /// 删除数据
        /// </summary>
        /// <param name="Id">Id</param>
        /// <returns>标志,成功 success,不成功为空</returns>
        public string DeleteData(string Id)
        {
            try
            {
                SYS_RoleInfo sysRoleInfo = mdb.SYS_RoleInfo.Where(u => u.Id == Id).FirstOrDefault();
                mdb.SYS_RoleInfo.Remove(sysRoleInfo);//删除实体
                int ret = mdb.SaveChanges();
                if (ret != 0)
                {
                    cacheHelper.SetCache(tableCacheKey, mdb.SYS_RoleInfo.ToList());
                    cacheHelper.SetCache("v_getuserpower", mdb.v_getuserpower.ToList());
                    LogHandle.GetInstance().Info("【删除数据】"+ BasicManage.Tool.UserInfo.GetInstance().UserId+" 删除角色数据", GetType().ToString());
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
        /// 获取角色的权限节点信息
        /// </summary>
        /// <param name="roleId">角色id</param>
        /// <returns>节点集合</returns>
        public string GetRolePower(string roleId)
        {
            List<SYS_RolePower> sysRolePower = null;
            if (cacheHelper.Exists("SYS_RolePower"))
                sysRolePower = cacheHelper.GetCache<List<SYS_RolePower>>("SYS_RolePower").Where(u => u.RoleId == roleId).ToList();
            else
                sysRolePower = mdb.SYS_RolePower.Where(u => u.RoleId == roleId).ToList();
            return putil.GetJsonData(sysRolePower);
        }
        /// <summary>
        /// 更新角色权限
        /// </summary>
        /// <param name="sysRolePowers">角色权限</param>
        /// <param name="roleId">角色id</param>
        /// <returns>标志,成功 success,不成功为空</returns>
        public string UpdateRolePower(List<SYS_RolePower> sysRolePowers,string roleId)
        {
            try
            {
                //删除之前的权限
                List<SYS_RolePower> dlist = mdb.SYS_RolePower.Where(u => u.RoleId == roleId).ToList();
                mdb.SYS_RolePower.RemoveRange(dlist);
                //重新插入
                mdb.SYS_RolePower.AddRange(sysRolePowers);
                int ret = mdb.SaveChanges();
                if (ret != 0)
                {
                    cacheHelper.SetCache("SYS_RolePower", mdb.SYS_RolePower.ToList());
                    cacheHelper.SetCache("v_getuserpower", mdb.v_getuserpower.ToList());
                    LogHandle.GetInstance().Info("【更新数据】" + BasicManage.Tool.UserInfo.GetInstance().UserId + " 更新角色权限", GetType().ToString());
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