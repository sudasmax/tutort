using System;
using System.Runtime.Caching;
using Tutort.Core.Caching.Interfaces;
using Tutort.Core.Helpers;

namespace Tutort.Core.Caching.Services
{
	public class CacheService : ICacheService
	{
		private MemoryCache _cache;

		public CacheService()
		{
			_cache = MemoryCache.Default;
		}

		public T Get<T>(string key) where T : class
		{
			Guard.ArgumentNotNullOrEmpty(key, "key");

			return _cache.Get(key) as T;
		}

		private DateTimeOffset ToExpiration(int expiration)
		{
			return new DateTimeOffset(DateTime.Now).ToOffset(TimeSpan.FromMinutes(expiration));
		}

		public void Set<T>(string key, T data, int expirationInMinutes) where T : class
		{
			Guard.ArgumentNotNullOrEmpty(key, "key");

			_cache.Set(key, data, ToExpiration(expirationInMinutes));
		}
	}
}
