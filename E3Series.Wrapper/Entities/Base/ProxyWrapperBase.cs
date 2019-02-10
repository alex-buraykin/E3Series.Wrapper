using System;
using System.Collections.Generic;
using System.Linq;
using E3Series.Proxy.Abstract;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Base
{
    /// <inheritdoc cref="IProxyWrapper" />
    /// <summary>
    /// Base class for all classes-wrappers of E3.series COM objects
    /// </summary>
    public abstract class ProxyWrapperBase<T> : IProxyWrapper, IProxyProvider<T> where T : E3ProxyBase
    {
        private readonly List<IProxyWrapper> _children;
        private readonly T _comObject;
        private bool _disposed;

        /// <inheritdoc />
        public IProxyWrapper Parent { get; }

        protected ProxyWrapperBase(IProxyWrapper parent, Func<T> createAction)
        {
            Parent = parent;
            _children = new List<IProxyWrapper>();

            Parent?.RegisterChild(this);

            _comObject = createAction.Invoke();
        }

        /// <inheritdoc />
        /// <summary>
        /// Wrapped COM object
        /// <exception cref="T:System.ObjectDisposedException" />
        /// </summary>
        public T Proxy
        {
            get
            {
                GuardDisposed();
                return _comObject;
            }
        }

        /// <inheritdoc />
        public void RegisterChild(IProxyWrapper child)
        {
            _children.Add(child);
        }

        /// <inheritdoc />
        public void UnregisterChild(IProxyWrapper child)
        {
            _children.Remove(child);
        }

        /// <inheritdoc />
        public bool HasChild(Type childType)
        {
            return GetChild(childType) != null;
        }

        /// <inheritdoc />
        public IProxyWrapper GetChild(Type childType)
        {
            return _children.FirstOrDefault(o => o.GetType() == childType);
        }

        /// <inheritdoc />
        /// <summary>
        /// <para>Releases COM object.</para>
        /// <para>Calling <see cref="M:E3Series.Wrapper.Entities.Base.ProxyWrapperBase.Dispose" /> makes object disposed. 
        /// Any subsequent call on any method except <see cref="M:E3Series.Wrapper.Entities.Base.ProxyWrapperBase.Dispose" /> would throw 
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
                foreach (var child in _children)
                {
                    try
                    {
                        child.Dispose();
                    }
                    catch
                    {
                        // ignored
                    }
                }

                _children.Clear();

                //Release managed resources
                Proxy.Dispose();
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