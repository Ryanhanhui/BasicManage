using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicManage.Tool.Interface
{
    public interface ICacheHelper
    {
        bool Exists(string key);


        T GetCache<T>(string key) where T : class;


        void SetCache(string key, object value);


        void SetCache(string key, object value, DateTimeOffset expiressAbsoulte);//设置绝对时间过期
        
        void RemoveCache(string key);


        void Dispose();
    }
}
