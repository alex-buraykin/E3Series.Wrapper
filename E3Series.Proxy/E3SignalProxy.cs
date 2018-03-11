using System;
using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3SignalProxy : E3ProxyBase
    {
        public E3SignalProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int AddDefaultWire(IntPtr wiregroup, IntPtr wirename)
        {
            return ComObject.AddDefaultWire(wiregroup, wirename);
        }

        public int Create(string name)
        {
            return ComObject.Create(name);
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int DeleteDefaultWire(IntPtr wiregroup, IntPtr wirename)
        {
            return ComObject.DeleteDefaultWire(wiregroup, wirename);
        }

        public int DisplayaAttributeValueAt(string name, int sheetid, double x, double y)
        {
            return ComObject.DisplayaAttributeValueAt(name, sheetid, x, y);
        }

        public int DisplayAttributeValueAt(string name, int sheetid, double x, double y)
        {
            return ComObject.DisplayAttributeValueAt(name, sheetid, x, y);
        }

        public int FindPanelPath()
        {
            return ComObject.FindPanelPath();
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

        public int GetCoreCount()
        {
            return ComObject.GetCoreCount();
        }

        public int GetCoreIds(ref object ids)
        {
            return ComObject.GetCoreIds(ref ids);
        }

        public int GetDefaultWires(ref object wiregroups, ref object wirenames)
        {
            return ComObject.GetDefaultWires(ref wiregroups, ref wirenames);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public string GetNameFormat()
        {
            return ComObject.GetNameFormat();
        }

        public int GetNetSegmentCount()
        {
            return ComObject.GetNetSegmentCount();
        }

        public int GetNetSegmentIds(ref object ids)
        {
            return ComObject.GetNetSegmentIds(ref ids);
        }

        public int GetPinCount()
        {
            return ComObject.GetPinCount();
        }

        public int GetPinIds(ref object ids)
        {
            return ComObject.GetPinIds(ref ids);
        }

        public int GetRecalcFormattedName()
        {
            return ComObject.GetRecalcFormattedName();
        }

        public int GetSignalClassId()
        {
            return ComObject.GetSignalClassId();
        }

        public string GetTranslatedName()
        {
            return ComObject.GetTranslatedName();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int Highlight()
        {
            return ComObject.Highlight();
        }

        public int HighlightCoreLogicLinesOfSignal()
        {
            return ComObject.HighlightCoreLogicLinesOfSignal();
        }

        public int Search(string name)
        {
            return ComObject.Search(name);
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetAttributeVisibility(string name, int onoff)
        {
            return ComObject.SetAttributeVisibility(name, onoff);
        }

        public int SetDefaultWires(ref object wiregroups, ref object wirenames)
        {
            return ComObject.SetDefaultWires(ref wiregroups, ref wirenames);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetName(string name)
        {
            return ComObject.SetName(name);
        }

        public int SetNameFormat(string name)
        {
            return ComObject.SetNameFormat(name);
        }

        public int SetRecalcFormattedName(int recalculate)
        {
            return ComObject.SetRecalcFormattedName(recalculate);
        }
    }
}