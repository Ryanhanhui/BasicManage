using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicManage.Tool.Interface
{
    public interface ICacheHelper
    {
        /// <summary>
        /// 对应键缓存是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool Exists(string key);

        /// <summary>
        /// 获取缓存值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">键</param>
        /// <returns></returns>
        T GetCache<T>(string key) where T : class;


        /// <summary>
        /// 设置缓存
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        void SetCache(string key, object value);


        /// <summary>
        /// 设置缓存
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <param name="expiressAbsoulte">过期时间</param>
        void SetCache(string key, object value, DateTimeOffset expiressAbsoulte);//设置绝对时间过期
        /// <summary>
        /// 删除缓存
        /// </summary>
        /// <param name="key">键</param>
        void RemoveCache(string key);


        void Dispose();
    }
}
