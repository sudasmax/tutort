using System.Linq;
using System.Web.Routing;

namespace Tutort.Web.Extensions
{
    /// <summary>
    /// Helper methods related to <see cref="RouteValueDictionary">.
    /// </summary>
    public static class RouteValueDictionaryExtensions
    {
        /// <summary>
        /// Merges two <see cref="RouteValueDictionary">.
        /// </summary>
        /// <param name="initial">Initial collection.</param>
        /// <param name="values">Collection which will be added.</param>
        /// <returns>Combined <see cref="RouteValueDictionary"> collection.</returns>
        public static RouteValueDictionary MergeRouteValues(this RouteValueDictionary initial, RouteValueDictionary values)
        {
            var result = initial ?? new RouteValueDictionary();

            if (values != null && values.Any())
            {
                foreach (var pair in values)
                {
                    result.Add(pair.Key, pair.Value);
                }
            }

            return result;
        }
    }
}