using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3ModuleProxy : E3ProxyBase
    {
        public E3ModuleProxy(object comObject) : base(comObject)
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

        public string GetFileName()
        {
            return ComObject.GetFileName();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetLevel()
        {
            return ComObject.GetLevel();
        }

        public int GetModuleIds(ref object ids)
        {
            return ComObject.GetModuleIds(ref ids);
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetParentModuleId()
        {
            return ComObject.GetParentModuleId();
        }

        public int GetParentSheetId()
        {
            return ComObject.GetParentSheetId();
        }

        public int GetPortCount()
        {
            return ComObject.GetPortCount();
        }

        public int GetPortIds(ref object ids)
        {
            return ComObject.GetPortIds(ref ids);
        }

        public int GetSheetIds(ref object ids)
        {
            return ComObject.GetSheetIds(ref ids);
        }

        public string GetTypeName()
        {
            return ComObject.GetTypeName();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int IsTypeLoadable()
        {
            return ComObject.IsTypeLoadable();
        }

        public int Search(string name)
        {
            return ComObject.Search(name);
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