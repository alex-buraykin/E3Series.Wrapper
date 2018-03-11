using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3BundleProxy : E3ProxyBase
    {
        public E3BundleProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int Capture(ref object cabwirids)
        {
            return ComObject.Capture(ref cabwirids);
        }

        public int Create(ref object aroundids)
        {
            return ComObject.Create(ref aroundids);
        }

        public int CreateBundle()
        {
            return ComObject.CreateBundle();
        }

        public int CreateBundle(ref object aroundids)
        {
            return ComObject.CreateBundle(ref aroundids);
        }

        public int CreateBundleIn(int cableid)
        {
            return ComObject.CreateBundleIn(cableid);
        }

        public int CreateIn(int cableid)
        {
            return ComObject.CreateIn(cableid);
        }

        public int CreateShield()
        {
            return ComObject.CreateShield();
        }

        public int CreateShield(ref object aroundids)
        {
            return ComObject.CreateShield(ref aroundids);
        }

        public int CreateShieldIn(int cableid)
        {
            return ComObject.CreateShieldIn(cableid);
        }

        public int CreateTwist()
        {
            return ComObject.CreateTwist();
        }

        public int CreateTwist(ref object aroundids)
        {
            return ComObject.CreateTwist(ref aroundids);
        }

        public int CreateTwistIn(int cableid)
        {
            return ComObject.CreateTwistIn(cableid);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int GetAnyCount()
        {
            return ComObject.GetAnyCount();
        }

        public int GetAnyIds(ref object ids)
        {
            return ComObject.GetAnyIds(ref ids);
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

        public int GetBundleCount()
        {
            return ComObject.GetBundleCount();
        }

        public int GetBundleIds(ref object ids)
        {
            return ComObject.GetBundleIds(ref ids);
        }

        public int GetCableCount()
        {
            return ComObject.GetCableCount();
        }

        public int GetCableIds(ref object ids)
        {
            return ComObject.GetCableIds(ref ids);
        }

        public int GetCoreCount()
        {
            return ComObject.GetCoreCount();
        }

        public int GetCoreIds(ref object ids)
        {
            return ComObject.GetCoreIds(ref ids);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetOverbraidId()
        {
            return ComObject.GetOverbraidId();
        }

        public int GetParentBundleId()
        {
            return ComObject.GetParentBundleId();
        }

        public int GetPinCount()
        {
            return ComObject.GetPinCount();
        }

        public int GetPinIds(ref object ids)
        {
            return ComObject.GetPinIds(ref ids);
        }

        public int GetRootBundleId(int bndid)
        {
            return ComObject.GetRootBundleId(bndid);
        }

        public int GetSymbolCount()
        {
            return ComObject.GetSymbolCount();
        }

        public int GetSymbolIds(ref object ids)
        {
            return ComObject.GetSymbolIds(ref ids);
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int IsBundle()
        {
            return ComObject.IsBundle();
        }

        public int IsShield()
        {
            return ComObject.IsShield();
        }

        public int IsTwisted()
        {
            return ComObject.IsTwisted();
        }

        public int PlaceAll()
        {
            return ComObject.PlaceAll();
        }

        public int ReleaseIDs(ref object ids)
        {
            return ComObject.ReleaseIDs(ref ids);
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