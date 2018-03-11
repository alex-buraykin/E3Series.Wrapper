using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3DbeBridgeProxy: E3ProxyBase
    {
        public E3DbeBridgeProxy(object comObject) : base(comObject)
        {
        }

        public void BringToForeground()
        {
            ComObject.BringToForeground();
        }

        public void Edit(int mode, int what, string entry, string version)
        {
            ComObject.Edit(mode, what, entry, version);
        }

        public void New(int mode, int what, string baseEntry, string baseVersion, string name, string version)
        {
            ComObject.New(mode, what, baseEntry, baseVersion, name, version);
        }
    }
}