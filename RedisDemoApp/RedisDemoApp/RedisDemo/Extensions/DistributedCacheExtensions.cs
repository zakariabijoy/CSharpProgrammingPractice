﻿using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace RedisDemo.Extensions
{
    public static class DistributedCacheExtensions
    {
        public static async Task SetRecordAsync<T>(this IDistributedCache cache, string recordId, T data, TimeSpan? absoluteExpireTime =  null, TimeSpan? unusedExprireTime = null)
        {
            var options = new DistributedCacheEntryOptions();
            options.AbsoluteExpirationRelativeToNow = absoluteExpireTime ?? TimeSpan.FromSeconds(60);
            options.SlidingExpiration = unusedExprireTime;

            var jsonData = JsonSerializer.Serialize(data);
            await cache.SetStringAsync(recordId, jsonData, options);
        }

        public static async Task<T> GetRecordAsync<T>(this IDistributedCache cache, string recordId)
        {
            var jsonData = await cache.GetStringAsync(recordId);

            if(jsonData is null)
            {
                return default(T);
            }

            return JsonSerializer.Deserialize<T>(jsonData);
        }
    }
}
