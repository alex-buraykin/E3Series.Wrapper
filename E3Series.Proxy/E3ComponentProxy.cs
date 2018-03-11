using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3ComponentProxy : E3ProxyBase
    {
        public E3ComponentProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int GetAttributeCount()
        {
            return ComObject.GetAttributeCount();
        }

        public int GetAttributeIds(ref object ids, string attnam = null)
        {
            return ComObject.GetAttributeIds(ref ids, attnam);
        }

        public string GetAttributeValue(string name)
        {
            return ComObject.GetAttributeValue(name);
        }

        public int GetFormboardSymbolIds(ref object ids)
        {
            return ComObject.GetFormboardSymbolIds(ref ids);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetModelName()
        {
            return ComObject.GetModelName();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetSupplyPinIds(ref object ids)
        {
            return ComObject.GetSupplyPinIds(ref ids);
        }

        public int GetValidModelCharacteristics(ref object characteristics)
        {
            return ComObject.GetValidModelCharacteristics(ref characteristics);
        }

        public string GetVersion()
        {
            return ComObject.GetVersion();
        }

        public int GetViewDefinitions(ref object viewDefinitions)
        {
            return ComObject.GetViewDefinitions(ref viewDefinitions);
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int Rename(string name, string version)
        {
            return ComObject.Rename(name, version);
        }

        public int Search(string name, string version)
        {
            return ComObject.Search(name, version);
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }
    }
}