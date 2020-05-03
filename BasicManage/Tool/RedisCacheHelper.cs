using BasicManage.Tool.Interface;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Caching.Redis;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;

namespace BasicManage.Tool
{
    public class RedisCacheHelper : ICacheHelper
    {
        private StackExchange.Redis.IDatabase _cache;
        private ConnectionMultiplexer _connection;
        private readonly string _instanceName;
        public RedisCacheHelper(RedisCacheOptions options,int database=0)
        {
            _connection = ConnectionMultiplexer.Connect(options.Configuration);
            _cache = _connection.GetDatabase(database);
            _instanceName = options.InstanceName;
        }
        public void Dispose()
        {
            if (_connection != null)
                _connection.Dispose();
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// 对应键缓存是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Exists(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));
            return _cache.KeyExists(GetKeyForRedis(key));
        }
        /// <summary>
        /// 获取缓存值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">键</param>
        /// <returns></returns>
        public T GetCache<T>(string key) where T : class
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));
            var value = _cache.StringGet(GetKeyForRedis(key));
            if (!value.HasValue)
                return default(T);
            return JsonConvert.DeserializeObject<T>(value);
        }
        /// <summary>
        /// 删除缓存
        /// </summary>
        /// <param name="key">键</param>
        public void RemoveCache(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));
            _cache.KeyDelete(GetKeyForRedis(key));
        }
        /// <summary>
        /// 设置缓存
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        public void SetCache(string key, object value)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (Exists(GetKeyForRedis(key)))
                RemoveCache(GetKeyForRedis(key));
            _cache.StringSet(GetKeyForRedis(key), JsonConvert.SerializeObject(value));
        }
        /// <summary>
        /// 设置缓存
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <param name="expiressAbsoulte">过期时间</param>
        public void SetCache(string key, object value, DateTimeOffset expiressAbsoulte)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (Exists(GetKeyForRedis(key)))
                RemoveCache(GetKeyForRedis(key));
            _cache.StringSet(GetKeyForRedis(key), JsonConvert.SerializeObject(value), expiressAbsoulte - DateTime.Now);
        }
        private string GetKeyForRedis(string key)
        {
            return _instanceName + key;
        }
    }
}
