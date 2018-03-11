using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3ModulePortProxy : E3ProxyBase
    {
        public E3ModulePortProxy(object comObject) : base(comObject)
        {
        }

        public string GetBusName()
        {
            return ComObject.GetBusName();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetModuleId()
        {
            return ComObject.GetModuleId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetSignalId()
        {
            return ComObject.GetSignalId();
        }

        public int GetSignalIds(ref object ids)
        {
            return ComObject.GetSignalIds(ref ids);
        }

        public int GetSymbolIds(ref object OnBlockId, ref object OnSheetId)
        {
            return ComObject.GetSymbolIds(ref OnBlockId, ref OnSheetId);
        }

        public int IsBus()
        {
            return ComObject.IsBus();
        }

        public int SetBusName(string name)
        {
            return ComObject.SetBusName(name);
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