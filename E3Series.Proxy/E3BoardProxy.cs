using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3BoardProxy : E3ProxyBase
    {
        public E3BoardProxy(object comObject) : base(comObject)
        {
        }

        public int Create(string name)
        {
            return ComObject.Create(name);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetLayerIds(ref object ids)
        {
            return ComObject.GetLayerIds(ref ids);
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetOutlineId()
        {
            return ComObject.GetOutlineId();
        }

        public int GetSheetIds(ref object ids)
        {
            return ComObject.GetSheetIds(ref ids);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }
    }
}