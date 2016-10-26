using System;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Extensions;

namespace E3Series.Wrapper.Entities.Extensions
{
    public static class EntityExtensions
    {
        /// <summary>
        /// A factory method for creating managed E3 API objects.
        /// </summary>
        /// <typeparam name="T">.NET public interface of E3 API object</typeparam>
        /// <returns>Managed E3 API object</returns>
        internal static T CreateObject<T>(this ComWrapper entity) where T : IDisposable
        {
            entity.GuardDisposed();
            var typeName = typeof(T).Name.ReplaceSuffix("I", "E3");
            var t = Type.GetType(string.Format("E3Series.Wrapper.Entities.{0}", typeName), true);

            return (T)Activator.CreateInstance(t, entity);
        }
    }
}