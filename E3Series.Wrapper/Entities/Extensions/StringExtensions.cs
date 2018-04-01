using System;

namespace E3Series.Wrapper.Entities.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Check equality of two strings (ignore case)
        /// </summary>
        /// <param name="str1">First string</param>
        /// <param name="str2">Second string</param>
        /// <returns></returns>
        public static bool EqualsIgnoreCase(this string str1, string str2)
        {
            return string.Equals(str1, str2, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}