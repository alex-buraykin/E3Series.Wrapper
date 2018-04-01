using System;
using System.Collections.Generic;
using System.Linq;
using E3Series.Proxy.Abstract;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Base.Interfaces;
using E3Series.Wrapper.Extensions;

namespace E3Series.Wrapper.Entities.Extensions
{
    public static class EntityExtensions
    {
        /// <summary>
        /// A factory method for creating managed E3 API objects.
        /// </summary>
        /// <typeparam name="T">.NET public interface of E3 API object</typeparam>
        /// <typeparam name="TProxy">Proxy class for E3.Series COM</typeparam>
        /// <returns>Managed E3 API object</returns>
        internal static T CreateObject<T, TProxy>(this ComWrapperBase<TProxy> entity)
            where T : IDisposable where TProxy : E3ProxyBase
        {
            entity.GuardDisposed();
            var typeName = typeof(T).Name.ReplaceSuffix("I", "E3");
            var t = Type.GetType($"E3Series.Wrapper.Entities.{typeName}", true);

            return (T) Activator.CreateInstance(t ?? throw new TypeLoadException($"Unable to find 'E3Series.Wrapper.Entities.{typeName}'"), entity);
        }

        /// <summary>
        /// Cast E3.series arrays packed in object to IEnumerable
        /// </summary>
        /// <param name="obj">E3.series array packed in object</param>
        /// <returns>IEnumerable</returns>
        public static IEnumerable<T> CastToIEnumerable<T>(this object obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (!(obj is object[] array))
                throw new InvalidCastException(nameof(obj));

            return array.Where(o => o != null)
                .Cast<T>();
        }

        /// <summary>
        /// Cast E3.series integer arrays packed in object to IEnumerable
        /// </summary>
        /// <param name="obj">E3.series array packed in object</param>
        /// <returns>IEnumerable of int</returns>
        public static IEnumerable<int> CastToIEnumerable(this object obj)
        {
            return obj.CastToIEnumerable<int>();
        }

        /// <summary>
        /// Enumerate object with single iterator
        /// </summary>
        /// <typeparam name="T">Iterator type</typeparam>
        /// <param name="iterator">Iterator</param>
        /// <param name="func">Func to get objects identifiers</param>
        /// <returns></returns>
        public static IEnumerable<T> GetEnumerable<T>(this T iterator, Func<IEnumerable<int>> func) 
            where T : IE3Identificated
        {
            return GetEnumerable(iterator, func.Invoke());
        }

        /// <summary>
        /// Enumerate object with single iterator
        /// </summary>
        /// <typeparam name="T">Iterator type</typeparam>
        /// <param name="iterator">Iterator</param>
        /// <param name="ids">Objects identifiers</param>
        /// <returns></returns>
        public static IEnumerable<T> GetEnumerable<T>(this T iterator, IEnumerable<int> ids) 
            where T : IE3Identificated
        {
            var oldId = iterator.Id;
            foreach (var devId in ids)
            {
                iterator.Id = devId;
                if (iterator.Id == 0) continue;

                yield return iterator;

            }
            iterator.Id = oldId;
        }
    }
}