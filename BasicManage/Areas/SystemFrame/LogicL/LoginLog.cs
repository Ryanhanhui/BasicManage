using BasicManage.Entities;
using BasicManage.Tool;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicManage.Areas.SystemFrame.LogicL
{
    public class LoginLog
    {
        private readonly MyDBContext mdb;
        PublicUtil putil;
        public LoginLog(MyDBContext _context)
        {
            mdb = _context;
            putil = new PublicUtil();
        }
        /// <summary>
        /// 获取数据条数
        /// </summary>
        /// <returns></returns>
        public int GetDataCount()
        {
            return mdb.v_sys_loginlog.OrderBy(u => u.LoginTime).ToList().Count;
        }
        public int GetDataCount(v_sys_loginlog loginlog, string begintime = null, string endtime = null)
        {
            try
            {
                IQueryable<v_sys_loginlog> loginlogquery = mdb.v_sys_loginlog as IQueryable<v_sys_loginlog>;
                if (!string.IsNullOrWhiteSpace(loginlog.UserId))
                    loginlogquery = loginlogquery.Where(u => u.UserId.Contains(loginlog.UserId)) as IQueryable<v_sys_loginlog>;
                if (!string.IsNullOrWhiteSpace(loginlog.NickName))
                    loginlogquery = loginlogquery.Where(u => u.NickName.Contains(loginlog.NickName)) as IQueryable<v_sys_loginlog>;
                if (!string.IsNullOrWhiteSpace(loginlog.LoginIP))
                    loginlogquery = loginlogquery.Where(u => u.LoginIP.Contains(loginlog.LoginIP)) as IQueryable<v_sys_loginlog>;
                if (!string.IsNullOrWhiteSpace(loginlog.LoginAddress))
                    loginlogquery = loginlogquery.Where(u => u.LoginAddress.Equals(loginlog.LoginAddress)) as IQueryable<v_sys_loginlog>;
                if (!string.IsNullOrWhiteSpace(begintime))
                {
                    DateTime _begintime = DateTime.Parse(begintime);
                    loginlogquery = loginlogquery.Where(u => u.LoginTime >= _begintime) as IQueryable<v_sys_loginlog>;
                }
                if (!string.IsNullOrWhiteSpace(endtime))
                {
                    DateTime _endtime = DateTime.Parse(endtime);
                    loginlogquery = loginlogquery.Where(u => u.LoginTime <= _endtime) as IQueryable<v_sys_loginlog>;
                }

                return loginlogquery.ToList().Count;
            }
            catch (Exception ex)
            {
                LogHandle.GetInstance().Error(ex.Message, GetType().ToString());
                return 0;
            }
        }
        public string GetData(int currpage, int pagesize, v_sys_loginlog loginlog, string begintime = null, string endtime = null)
        {
            try
            {
                IQueryable<v_sys_loginlog> loginlogquery = mdb.v_sys_loginlog as IQueryable<v_sys_loginlog>;
                if (!string.IsNullOrWhiteSpace(loginlog.UserId))
                    loginlogquery = loginlogquery.Where(u => u.UserId.Contains(loginlog.UserId)) as IQueryable<v_sys_loginlog>;
                if (!string.IsNullOrWhiteSpace(loginlog.NickName))
                    loginlogquery = loginlogquery.Where(u => u.NickName.Contains(loginlog.NickName)) as IQueryable<v_sys_loginlog>;
                if (!string.IsNullOrWhiteSpace(loginlog.LoginIP))
                    loginlogquery = loginlogquery.Where(u => u.LoginIP.Contains(loginlog.LoginIP)) as IQueryable<v_sys_loginlog>;
                if (!string.IsNullOrWhiteSpace(loginlog.LoginAddress))
                    loginlogquery = loginlogquery.Where(u => u.LoginAddress.Equals(loginlog.LoginAddress)) as IQueryable<v_sys_loginlog>;
                if (!string.IsNullOrWhiteSpace(begintime))
                {
                    DateTime _begintime=DateTime.Parse(begintime);
                    loginlogquery = loginlogquery.Where(u => u.LoginTime >= _begintime) as IQueryable<v_sys_loginlog>;
                }
                if (!string.IsNullOrWhiteSpace(endtime))
                {
                    DateTime _endtime=DateTime.Parse(endtime);
                    loginlogquery = loginlogquery.Where(u => u.LoginTime <= _endtime) as IQueryable<v_sys_loginlog>;
                }

                loginlogquery = loginlogquery.OrderByDescending(u => u.LoginTime).Skip((currpage - 1) * pagesize).Take(pagesize) as IQueryable<v_sys_loginlog>;

                List<v_sys_loginlog> loginloginfo = loginlogquery.ToList();
                return putil.GetJsonData(loginloginfo);
            }
            catch (Exception ex)
            {
                LogHandle.GetInstance().Error(ex.Message, GetType().ToString());
                return string.Empty;
            }
        }
    }
}