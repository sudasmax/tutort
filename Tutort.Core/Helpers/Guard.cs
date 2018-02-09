using System;

namespace Tutort.Core.Helpers
{
	public static class Guard
	{
		public static void ArgumentNotNull(this object arg, string name)
		{
			if (arg == null)
			{
				throw new ArgumentNullException(name);
			}
		}

		public static void ArgumentNotNullOrEmpty(this string arg, string name)
		{
			if (string.IsNullOrWhiteSpace(arg))
			{
				throw new ArgumentNullException(name);
			}
		}
	}
}
