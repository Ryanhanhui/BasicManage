using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicManage.Entities
{
    public class MyDBContext:DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options):base(options)
        {

        }
        #region 框架实体部分
        public DbSet<NodeSetInfo> NodeSetInfo { get; set; }
        public DbSet<PR_UserInfo> PR_UserInfo { get; set; }
        public DbSet<SYS_LoginImg> SYS_LoginImg { get; set; }
        public DbSet<SYS_LoginLog> SYS_LoginLog { get; set; }
        public DbSet<SYS_RoleInfo> SYS_RoleInfo { get; set; }
        public DbSet<SYS_RolePower> SYS_RolePower { get; set; }
        public DbSet<SYS_SystemConfigInfo> SYS_SystemConfigInfo { get; set; }
        public DbSet<v_getuserpower> v_getuserpower { get; set; }
        public DbSet<v_sys_loginlog> v_sys_loginlog { get; set; }
        public DbSet<v_userinfo> v_userinfo { get; set; }
        #endregion

        #region 功能实体部分
       
        #endregion


        
    }
}
