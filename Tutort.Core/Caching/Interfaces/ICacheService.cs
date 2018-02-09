using System;

namespace Tutort.Core.Caching.Interfaces
{
	public interface ICacheService
	{
		void Set<T>(string key, T data, int expirationInMinutes) where T : class;

		T Get<T>(string key) where T : class;
	}
}
