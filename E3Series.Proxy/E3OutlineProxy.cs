using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3OutlineProxy : E3ProxyBase
    {
        public E3OutlineProxy(object comObject) : base(comObject)
        {
        }

        public int CreateBoardOutline(int brdi, int pnts, ref object x, ref object y)
        {
            return ComObject.CreateBoardOutline(brdi, pnts, ref x, ref y);
        }

        public double GetHeight()
        {
            return ComObject.GetHeight();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetPath(ref object xarr, ref object yarr)
        {
            return ComObject.GetPath(ref xarr, ref yarr);
        }

        public int GetPathEx(ref object xarr, ref object yarr, ref object zarr)
        {
            return ComObject.GetPathEx(ref xarr, ref yarr, ref zarr);
        }

        public int GetPosition(ref object x, ref object y, ref object z)
        {
            return ComObject.GetPosition(ref x, ref y, ref z);
        }

        public double GetRadius()
        {
            return ComObject.GetRadius();
        }

        public int GetSymbolCount()
        {
            return ComObject.GetSymbolCount();
        }

        public int GetSymbolIds(ref object ids)
        {
            return ComObject.GetSymbolIds(ref ids);
        }

        public int GetTypeId()
        {
            return ComObject.GetTypeId();
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int UseInE3CutOut()
        {
            return ComObject.UseInE3CutOut();
        }
    }
}