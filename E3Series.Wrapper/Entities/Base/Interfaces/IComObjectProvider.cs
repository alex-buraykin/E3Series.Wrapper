using System;

namespace E3Series.Wrapper.Entities.Base.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Generic interface for all class-wrappers with readonly access to ComObject field
    /// </summary>
    public interface IComObjectProvider: IDisposable
    {
        /// <summary>
        /// Wrapped E3series COM object
        /// </summary>
        [Obsolete("Use wrapped methods whenever possible", false)]
        dynamic ComObject { get; }
    }
}