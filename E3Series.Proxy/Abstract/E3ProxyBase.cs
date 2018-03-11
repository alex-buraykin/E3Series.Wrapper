using System;
using System.Runtime.InteropServices;

namespace E3Series.Proxy.Abstract
{
    public class E3ProxyBase : IDisposable
    {
        private object _comObject;

        /// <summary>
        /// Wrapped COM object
        /// <exception cref="T:System.ObjectDisposedException" />
        /// </summary>
        public dynamic ComObject => _comObject;

        public E3ProxyBase(object comObject)
        {
            _comObject = comObject;
        }

        /// <summary>
        /// Properly release the COM object
        /// </summary>
        private void ReleaseComObject()
        {
            if (_comObject != null)
                Marshal.ReleaseComObject(_comObject);

            _comObject = null;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            ReleaseComObject();
            GC.SuppressFinalize(this);
        }
    }
}