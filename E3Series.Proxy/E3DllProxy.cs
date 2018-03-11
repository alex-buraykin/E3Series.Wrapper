using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3DllProxy : E3ProxyBase
    {
        public E3DllProxy(object comObject) : base(comObject)
        {
        }

        public int Call(string method, string item1 = "-353353", string item2 = "-353353", string item3 = "-353353",
            string item4 = "-353353", string item5 = "-353353")
        {
            return ComObject.Call(method, item1, item2, item3, item4, item5);
        }

        public int Load(string name)
        {
            return ComObject.Load(name);
        }

        public int Unload()
        {
            return ComObject.Unload();
        }
    }
}