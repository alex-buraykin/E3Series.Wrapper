using System;
using System.Collections.Generic;
using System.Linq;

namespace E3Series.Wrapper.Entities.Extensions
{
    public static class E3ObjectExtensions
    {
        /// <summary>
        /// Cast E3.series int result to bool
        /// </summary>
        /// <param name="intValue"></param>
        /// <returns></returns>
        public static bool CastToBool(this int intValue)
        {
            switch (intValue)
            {
                case 0:
                    return false;
                case 1:
                    return true;
                default:
                    throw new ArgumentOutOfRangeException(nameof(intValue));
            }
        }

        /// <summary>
        /// Cast E3.series arrays packed in object to IEnumerable
        /// </summary>
        /// <param name="obj">E3.series array packed in object</param>
        /// <returns>IEnumerable</returns>
        public static IEnumerable<T> ToIEnumerable<T>(this object obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (!(obj is object[] array))
                throw new InvalidCastException("Объект obj не является массивом object[]");

            return array.Where(o => o != null)
                .Cast<T>();
        }

        /// <summary>
        /// Cast E3.series integer arrays packed in object to IEnumerable
        /// </summary>
        /// <param name="obj">E3.series array packed in object</param>
        /// <returns>IEnumerable of int</returns>
        public static IEnumerable<int> ToIEnumerable(this object obj)
        {
            return obj.ToIEnumerable<int>();
        }
    }
}