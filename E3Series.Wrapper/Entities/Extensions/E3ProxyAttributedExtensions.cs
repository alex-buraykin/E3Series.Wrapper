using System;
using System.Collections.Generic;
using E3Series.Proxy.Interfaces;

namespace E3Series.Wrapper.Entities.Extensions
{
    public static class E3ProxyAttributedExtensions
    {
        /// <summary>
        /// Get attributes ids for proxy object
        /// </summary>
        /// <param name="proxy">E3.series proxy object</param>
        /// <param name="attributeName">Returns only attributes with name <c>attributeName</c></param>
        /// <returns>IEnumerable of ids or empty collection</returns>
        public static IEnumerable<int> GetAttributeIdsEnumerable(this IAttributed proxy, string attributeName = "")
        {
            if (attributeName == null)
                throw new ArgumentNullException(nameof(attributeName));

            object attIds = null;

            if (!string.IsNullOrWhiteSpace(attributeName))
            {
                if (!proxy.HasAttribute(attributeName).CastToBool())
                    return new int[] { };

                proxy.GetAttributeIds(ref attIds, attributeName);
                return attIds.ToIEnumerable();
            }

            if (proxy.GetAttributeCount() == 0)
                return new int[] { };

            proxy.GetAttributeIds(ref attIds);

            return attIds.ToIEnumerable();
        }
    }
}