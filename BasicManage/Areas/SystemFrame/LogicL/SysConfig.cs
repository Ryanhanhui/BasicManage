using BasicManage.Entities;
using BasicManage.Tool;
using BasicManage.Tool.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicManage.Areas.SystemFrame.LogicL
{
    public class SysConfig
    {
        private readonly MyDBContext mdb;
        private readonly ICacheHelper cacheHelper;
        private const string tableCacheKey = "SYS_SystemConfigInfo";
        public SysConfig(MyDBContext _context, ICacheHelper _cacheHelper)
        {
            mdb = _context;
            cacheHelper = _cacheHelper;
        }
        /// <summary>
        /// 获取信息
        /// </summary>
        /// <returns></returns>
        //public string GetBindData()
        //{
        //    SYS_SystemConfigInfo systemConfig = mdb.SYS_SystemConfigInfo.ToList().FirstOrDefault();
        //    return putil.GetJsonData(systemConfig);
        //}
        /// <summary>
        /// 获取信息
        /// </summary>
        /// <returns></returns>
        public SYS_SystemConfigInfo GetBindData()
        {
            SYS_SystemConfigInfo systemConfig = null;
            if (cacheHelper.Exists(tableCacheKey))
                systemConfig = cacheHelper.GetCache<SYS_SystemConfigInfo>(tableCacheKey);
            else
                systemConfig = mdb.SYS_SystemConfigInfo.ToList().FirstOrDefault();
            return systemConfig;
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="sysConfig">系统配置信息</param>
        /// <returns>标志,成功 success,不成功为空</returns>
        public string UpdateData(SYS_SystemConfigInfo sysConfig)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sysConfig.Id.ToString()))//添加
                {
                    sysConfig.Id = Guid.NewGuid().ToString("N");
                    mdb.SYS_SystemConfigInfo.Add(sysConfig);
                }
                else//更新
                {
                    EntityEntry<SYS_SystemConfigInfo> entry = mdb.Entry<SYS_SystemConfigInfo>(sysConfig);
                    entry.State = EntityState.Unchanged;
                    entry.Property("System_Name").IsModified = true;
                    entry.Property("LoginFooter").IsModified = true;
                    entry.Property("MainFooter").IsModified = true;
                    entry.Property("PhoneQR").IsModified = true;
                    entry.Property("PhoneAddress").IsModified = true;
                }
                int ret = mdb.SaveChanges();
                if (ret != 0)
                {
                    cacheHelper.SetCache(tableCacheKey, mdb.SYS_SystemConfigInfo.ToList().FirstOrDefault());
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