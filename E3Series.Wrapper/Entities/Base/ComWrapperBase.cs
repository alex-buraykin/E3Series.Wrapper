using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Base
{
    /// <inheritdoc cref="IComObject" />
    /// <inheritdoc cref="IComObjectProvider" />
    /// <summary>
    /// Base class for all classes-wrappers of E3.series COM objects
    /// </summary>
    public abstract class ComWrapperBase : IComObject, IComObjectProvider
    {
        private readonly List<IComObject> _children;
        private object _comObject;
        private bool _disposed;

        /// <inheritdoc />
        public IComObject Parent { get; }

        protected ComWrapperBase(IComObject parent, Func<object> createAction)
        {
            Parent = parent;
            _children = new List<IComObject>();

            Parent?.RegisterChild(this);

            _comObject = createAction.Invoke();
        }

        /// <inheritdoc />
        /// <summary>
        /// Wrapped COM object
        /// <exception cref="T:System.ObjectDisposedException" />
        /// </summary>
        public dynamic ComObject
        {
            get
            {
                GuardDisposed();
                return _comObject;
            }
        }

        /// <inheritdoc />
        public void RegisterChild(IComObject child)
        {
            _children.Add(child);
        }

        /// <inheritdoc />
        public void UnregisterChild(IComObject child)
        {
            _children.Remove(child);
        }

        /// <inheritdoc />
        public void ReleaseComObject()
        {
            if (_comObject != null)
                Marshal.ReleaseComObject(_comObject);

            _comObject = null;
        }

        /// <inheritdoc />
        public bool HasChild(Type childType)
        {
            return GetChild(childType) != null;
        }

        /// <inheritdoc />
        public IComObject GetChild(Type childType)
        {
            return _children.FirstOrDefault(o => o.GetType() == childType);
        }

        /// <inheritdoc />
        /// <summary>
        /// <para>Releases COM object.</para>
        /// <para>Calling <see cref="M:E3Series.Wrapper.Entities.Base.ComWrapperBase.Dispose" /> makes object disposed. 
        /// Any subsequent call on any method except <see cref="M:E3Series.Wrapper.Entities.Base.ComWrapperBase.Dispose" /> would throw 
        /// an <see cref="T:System.ObjectDisposedException" />.</para>
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            // No unmanaged resources to release

            if (disposing)
            {
                // Release from parent object
                Parent?.UnregisterChild(this);

                // Release child objects
                try
                {
                    foreach (var child in _children.Where(o => o != null))
                        child.ReleaseComObject();
                }
                finally
                {
                    _children.Clear();
                }

                //Release managed resources
                ReleaseComObject();
            }
            _disposed = true;
        }

        /// <summary>
        /// Checks if <see cref="Dispose()"/> method was called on this IDisposable object
        /// <exception cref="ObjectDisposedException"></exception>
        /// </summary> 
        protected internal void GuardDisposed()
        {
            if (_disposed) throw new ObjectDisposedException(GetType().ToString());
        }
    }
}