using System;

namespace E3Series.Wrapper.Entities.Base.Interfaces
{
    /// <summary>
    /// Interface for correct load/unload COM objects
    /// </summary>
    public interface IComObject : IDisposable
    {
        /// <summary>
        /// Parent object
        /// </summary>
        IComObject Parent { get; }

        /// <summary>
        /// Register child object
        /// </summary>
        /// <param name="child">Child object</param>
        void RegisterChild(IComObject child);

        /// <summary>
        /// Unregister child object
        /// </summary>
        /// <param name="child">Child object</param>
        void UnregisterChild(IComObject child);

        /// <summary>
        /// Check child object already registered
        /// </summary>
        /// <param name="childType">Type of child object</param>
        /// <returns></returns>
        bool HasChild(Type childType);

        /// <summary>
        /// Get child object from list of registered
        /// </summary>
        /// <param name="childType">Type of child object</param>
        /// <returns></returns>
        IComObject GetChild(Type childType);
    }
}