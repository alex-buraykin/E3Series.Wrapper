using System.Collections.Generic;
using E3Series.Proxy;

namespace E3Series.Wrapper.Entities.Extensions
{
    public static class E3TreeExtensions
    {
        /// <summary>
        /// Get ids of selected terminals in project tree
        /// </summary>
        /// <param name="tree">E3.series ITreeInterface COM proxy object</param>
        /// <returns>IEnumerable of ids or empty collection</returns>
        public static IEnumerable<int> GetSelectedTerminalIdsEnumerable(this E3TreeProxy tree)
        {
            object termIds = null;
            tree.GetSelectedTerminalIds(ref termIds);

            return termIds.ToIEnumerable();
        }
    }
}