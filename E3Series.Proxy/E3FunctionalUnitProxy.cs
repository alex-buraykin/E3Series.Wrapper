using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3FunctionalUnitProxy : E3ProxyBase
    {
        public E3FunctionalUnitProxy(object comObject) : base(comObject)
        {
        }
        
        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int Create(int fdbID, string name, string symnam, string symver)
        {
            return ComObject.Create(fdbID, name, symnam, symver);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int GetAttributeIds(ref object ids, string attnam = null)
        {
            return ComObject.GetAttributeIds(ref ids, attnam);
        }

        public string GetAttributeValue(string name)
        {
            return ComObject.GetAttributeValue(name);
        }

        public int GetDeviceId()
        {
            return ComObject.GetDeviceId();
        }

        public int GetFunctionalPortIds(ref object ids)
        {
            return ComObject.GetFunctionalPortIds(ref ids);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetSchemaSymbolId()
        {
            return ComObject.GetSchemaSymbolId();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int IsDynamic()
        {
            return ComObject.IsDynamic();
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
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