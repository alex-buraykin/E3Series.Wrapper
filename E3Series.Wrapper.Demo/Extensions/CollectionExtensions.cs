using System;
using System.Collections.Generic;

namespace E3Series.Wrapper.Demo.Extensions
{
    /// <summary>
    /// Extension methods for IEnumerable
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Applies the specified changes to the collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection">Collection.</param>
        /// <param name="predicate">The predicate.</param>
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> predicate)
        {
            foreach (var item in collection)
                predicate(item);
        }
    }
}