using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3LayerProxy : E3ProxyBase
    {
        public E3LayerProxy(object comObject) : base(comObject)
        {
        }

        public int Create(string name, int type, int copper, int layer_id, int before)
        {
            return ComObject.Create(name, type, copper, layer_id, before);
        }

        public int GetBoardLayerIds(ref object ids)
        {
            return ComObject.GetBoardLayerIds(ref ids);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int IsGlobalLayer()
        {
            return ComObject.IsGlobalLayer();
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }
    }
}