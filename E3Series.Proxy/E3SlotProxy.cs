using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3SlotProxy : E3ProxyBase
    {
        public E3SlotProxy(object comObject) : base(comObject)
        {
        }

        public int GetFixType()
        {
            return ComObject.GetFixType();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetMountType()
        {
            return ComObject.GetMountType();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetPosition(int point, ref object x, ref object y, ref object z)
        {
            return ComObject.GetPosition(point, ref x, ref y, ref z);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }
    }
}