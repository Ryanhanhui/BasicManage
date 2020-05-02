using BasicManage.Entities;
using BasicManage.Tool;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicManage.Areas.SystemFrame.LogicL
{
    public class Home
    {
        private readonly MyDBContext mdb;
        PublicUtil putil ;
        public Home(MyDBContext _context)
        {
            mdb = _context;
            putil = new PublicUtil();
        }
        public string GetPower()
        {
            string usertype = BasicManage.Tool.UserInfo.GetInstance().UserType;
            string roletype = BasicManage.Tool.UserInfo.GetInstance().RoleType;
            List<v_getuserpower> powerlist = mdb.v_getuserpower.Where(u => u.RoleId.Equals(roletype) && u.NodeType.Equals("0")).ToList();
            if(usertype.Equals("1"))
            {
                List<v_getuserpower> tmplist = mdb.v_getuserpower.Where(u => u.NodeType.Equals("1")).ToList();
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
            SYS_SystemConfigInfo sysconfig = mdb.SYS_SystemConfigInfo.ToList().FirstOrDefault();
            return sysconfig;
        }
    }
}