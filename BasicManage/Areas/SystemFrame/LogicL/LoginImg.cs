using BasicManage.Entities;
using BasicManage.Tool;
using BasicManage.Tool.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicManage.Areas.SystemFrame.LogicL
{
    public class LoginImg
    {
        private readonly MyDBContext mdb ;
        private readonly ICacheHelper cacheHelper;
        private const string tableCacheKey = "SYS_LoginImg";
        public LoginImg(MyDBContext _context, ICacheHelper _cacheHelper)
        {
            mdb = _context;
            cacheHelper = _cacheHelper;
        }
        public List<SYS_LoginImg> GetAllData()
        {
            List<SYS_LoginImg> imgs = null;
            if (cacheHelper.Exists(tableCacheKey))
                imgs = cacheHelper.GetCache<List<SYS_LoginImg>>(tableCacheKey).OrderBy(u => u.ImgId).ToList();
            else
                imgs = mdb.SYS_LoginImg.OrderBy(u => u.ImgId).ToList();
            return imgs;
        }
        public string AddData(string imgurl)
        {
            SYS_LoginImg limg = new SYS_LoginImg();
            limg.ImgId = Guid.NewGuid().ToString("N");
            limg.ImgUrl = imgurl;
            mdb.SYS_LoginImg.Add(limg);
            int ret = mdb.SaveChanges();
            if (ret != 0)
            {
                cacheHelper.SetCache(tableCacheKey, mdb.SYS_LoginImg.ToList());
                return "success";
            }
            else
                return "";
        }
        public string DeleteData(string imgid)
        {
            try
            {
                SYS_LoginImg lgimg = mdb.SYS_LoginImg.Where(u => u.ImgId.Equals(imgid)).FirstOrDefault();
                mdb.SYS_LoginImg.Remove(lgimg);//删除实体
                int ret = mdb.SaveChanges();
                if (ret != 0)
                {
                    cacheHelper.SetCache(tableCacheKey, mdb.SYS_LoginImg.ToList());
                    LogHandle.GetInstance().Info("【删除数据】" + BasicManage.Tool.UserInfo.GetInstance().UserId + " 删除登录图片", GetType().ToString());
                    return "success";
                }
                else
                    return "";
            }
            catch (Exception ex)
            {
                LogHandle.GetInstance().Error(ex.Message, GetType().ToString());
                return string.Empty;
            }
        }
    }
}