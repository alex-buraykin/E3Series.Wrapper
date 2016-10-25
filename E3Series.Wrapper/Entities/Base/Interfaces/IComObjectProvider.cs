using System;

namespace E3Series.Wrapper.Entities.Base.Interfaces
{
    /// <summary>
    /// Generic interface for all class-wrappers
    /// </summary>
    /// <typeparam name="TE3ComObjectType"></typeparam>
    public interface IComObjectProvider<out TE3ComObjectType> : IDisposable
    {
        /// <summary>
        /// Wrapped E3series COM object
        /// </summary>
        [Obsolete("Use wrapped methods instead", false)]
        TE3ComObjectType ComObject { get; }
    }
}