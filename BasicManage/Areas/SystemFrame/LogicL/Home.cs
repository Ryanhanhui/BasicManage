using BasicManage.Entities;
using BasicManage.Tool;
using BasicManage.Tool.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicManage.Areas.SystemFrame.LogicL
{
    public class Home
    {
        private readonly MyDBContext mdb;
        PublicUtil putil ;
        private readonly ICacheHelper cacheHelper;
        public Home(MyDBContext _context, ICacheHelper _cacheHelper)
        {
            mdb = _context;
            cacheHelper = _cacheHelper;
            putil = new PublicUtil();
        }
        public string GetPower()
        {
            string usertype = BasicManage.Tool.UserInfo.GetInstance().UserType;
            string roletype = BasicManage.Tool.UserInfo.GetInstance().RoleType;
            List<v_getuserpower> powerlist = null;
            if (cacheHelper.Exists("v_getuserpower"))
                powerlist = cacheHelper.GetCache<List<v_getuserpower>>("v_getuserpower").ToList();
            else
                powerlist = mdb.v_getuserpower.ToList();
            powerlist=powerlist.Where(u => u.RoleId.Equals(roletype) && u.NodeType.Equals("0")).ToList();
            if (usertype.Equals("1"))
            {
                List<v_getuserpower> tmplist = null;
                if (cacheHelper.Exists("v_getuserpower"))
                    tmplist = cacheHelper.GetCache<List<v_getuserpower>>("v_getuserpower").Where(u => u.NodeType.Equals("1")).ToList();
                else
                    tmplist = mdb.v_getuserpower.Where(u => u.NodeType.Equals("1")).ToList();
                if (powerlist == null)
                    powerlist = tmplist;
                else
                    powerlist.AddRange(tmplist);
            }
            powerlist = powerlist.OrderBy(u => u.NodeNum).ToList();
            return putil.GetJsonData(powerlist);
        }
        public SYS_SystemConfigInfo GetSysConfig()
        {
            SYS_SystemConfigInfo sysconfig =(new SysConfig(mdb, cacheHelper)).GetBindData();
            return sysconfig;
        }
    }
}