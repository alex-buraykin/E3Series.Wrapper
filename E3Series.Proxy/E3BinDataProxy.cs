using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3BinDataProxy : E3ProxyBase
    {
        public E3BinDataProxy(object comObject) : base(comObject)
        {
        }

        public int GetData(string name, ref object data, int maxlen)
        {
            return ComObject.GetData(name, ref data, maxlen);
        }

        public int SetData(string name, ref object data, int maxlen)
        {
            return ComObject.SetData(name, ref data, maxlen);
        }
    }
}