using System.Collections.Generic;
using E3Series.Proxy;

namespace E3Series.Wrapper.Entities.Extensions
{
    public static class E3JobExtensions
    {
        /// <summary>
        /// Get ids of selected net segments in current E3.series project
        /// </summary>
        /// <param name="proxy">E3.series IJobInterface COM proxy object</param>
        /// <returns>IEnumerable of ids or empty collection</returns>
        public static IEnumerable<int> GetSelectedNetSegmentIdsEnumerable(this E3JobProxy proxy)
        {
            if (proxy.GetSelectedNetSegmentCount() == 0)
                return new int[] { };

            object nsIds = null;
            proxy.GetSelectedNetSegmentIds(ref nsIds);

            return nsIds.ToIEnumerable();
        }
    }
}