using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3SupplyProxy : E3ProxyBase
    {
        public E3SupplyProxy(object comObject) : base(comObject)
        {
        }

        public int Create(int devid, string name)
        {
            return ComObject.Create(devid, name);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int GetBlockId()
        {
            return ComObject.GetBlockId();
        }

        public int GetComponentIds(ref object ids)
        {
            return ComObject.GetComponentIds(ref ids);
        }

        public int GetDevCompIds(ref object ids)
        {
            return ComObject.GetDevCompIds(ref ids);
        }

        public int GetDeviceIds(ref object ids)
        {
            return ComObject.GetDeviceIds(ref ids);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public string GetOwnerName()
        {
            return ComObject.GetOwnerName();
        }

        public int GetPinIds(ref object ids)
        {
            return ComObject.GetPinIds(ref ids);
        }

        public int GetSignalIds(ref object ids)
        {
            return ComObject.GetSignalIds(ref ids);
        }

        public string GetSignalTypeName(int which)
        {
            return ComObject.GetSignalTypeName(which);
        }

        public int Search(int devid, string name)
        {
            return ComObject.Search(devid, name);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetName(string name)
        {
            return ComObject.SetName(name);
        }

        public int SetSignalIds(ref object ids)
        {
            return ComObject.SetSignalIds(ref ids);
        }
    }
}