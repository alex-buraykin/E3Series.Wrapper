using System;

namespace E3Series.Wrapper.Extensions
{
    /// <summary>
    /// Extension methods for strings
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Replace suffix for string
        /// </summary>
        /// <param name="source">string</param>
        /// <param name="oldSuffixSeparator">Old suffix</param>
        /// <param name="newSuffixSeparator">New suffix</param>
        /// <param name="comp">String comparision method</param>
        /// <returns></returns>
        public static string ReplaceSuffix(this string source, string oldSuffixSeparator, string newSuffixSeparator,
                                           StringComparison comp = StringComparison.InvariantCultureIgnoreCase)
        {
            int index = source.IndexOf(oldSuffixSeparator, comp);
            return index == -1
                       ? source
                       : source.Remove(0, oldSuffixSeparator.Length).Insert(0, newSuffixSeparator);
        }
    }
}