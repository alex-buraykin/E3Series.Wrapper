using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3InfoApplicationProxy : E3ProxyBase
    {
        public E3InfoApplicationProxy(object comObject) : base(comObject)
        {
        }

        public string GetWindowPos(double x, double y, string text)
        {
            return ComObject.GetWindowPos(x, y, text);
        }
    }
}