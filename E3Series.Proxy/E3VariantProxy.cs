using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3VariantProxy : E3ProxyBase
    {
        public E3VariantProxy(object comObject) : base(comObject)
        {
        }

        public int Create(string name)
        {
            return ComObject.Create(name);
        }

        public int Delete(int del)
        {
            return ComObject.Delete(del);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int IsActive()
        {
            return ComObject.IsActive();
        }

        public int Search(string name)
        {
            return ComObject.Search(name);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetName(string name)
        {
            return ComObject.SetName(name);
        }
    }
}