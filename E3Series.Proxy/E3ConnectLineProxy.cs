using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3ConnectLineProxy : E3ProxyBase
    {
        public E3ConnectLineProxy(object comObject) : base(comObject)
        {
        }

        public int AddProtectionSymbolId(int id)
        {
            return ComObject.AddProtectionSymbolId(id);
        }

        public int GetCoordinates(ref object xarr, ref object yarr, ref object zarr)
        {
            return ComObject.GetCoordinates(ref xarr, ref yarr, ref zarr);
        }

        public int GetCoordinates(ref object xarr, ref object yarr, ref object zarr, ref object PointTypArr)
        {
            return ComObject.GetCoordinates(ref xarr, ref yarr, ref zarr, ref PointTypArr);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetProtectionSymbolIds(ref object ids)
        {
            return ComObject.GetProtectionSymbolIds(ref ids);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }
    }
}