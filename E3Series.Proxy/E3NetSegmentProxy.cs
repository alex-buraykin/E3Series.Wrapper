using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3NetSegmentProxy : E3ProxyBase
    {
        public E3NetSegmentProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int AdjustSchemaLength()
        {
            return ComObject.AdjustSchemaLength();
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int DisplayAttributeValue(string name)
        {
            return ComObject.DisplayAttributeValue(name);
        }

        public int DisplayAttributeValueAt(string name, int sheetid, double x, double y)
        {
            return ComObject.DisplayAttributeValueAt(name, sheetid, x, y);
        }

        public int GetAssignedOptionExpressions(ref object expressions, int Term = 0)
        {
            return ComObject.GetAssignedOptionExpressions(ref expressions, Term);
        }

        public int GetAssignedOptionExpressionsEx(ref object expressions, int Term = 0)
        {
            return ComObject.GetAssignedOptionExpressionsEx(ref expressions, Term);
        }

        public int GetAssignedOptionIds(ref object ids)
        {
            return ComObject.GetAssignedOptionIds(ref ids);
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

        public string GetBusName()
        {
            return ComObject.GetBusName();
        }

        public int GetConnectedSymbolIds(ref object ids)
        {
            return ComObject.GetConnectedSymbolIds(ref ids);
        }

        public int GetConnectLineIds(ref object ids)
        {
            return ComObject.GetConnectLineIds(ref ids);
        }

        public int GetCoreCount()
        {
            return ComObject.GetCoreCount();
        }

        public int GetCoreIds(ref object ids)
        {
            return ComObject.GetCoreIds(ref ids);
        }

        public int GetEffectiveDirection(ref object fromID, ref object toID)
        {
            return ComObject.GetEffectiveDirection(ref fromID, ref toID);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public double GetLength()
        {
            return ComObject.GetLength();
        }

        public int GetLevel()
        {
            return ComObject.GetLevel();
        }

        public int GetLineColour()
        {
            return ComObject.GetLineColour();
        }

        public int GetLineSegments(ref object shtId, ref object xarr, ref object yarr)
        {
            return ComObject.GetLineSegments(ref shtId, ref xarr, ref yarr);
        }

        public int GetLineSegments(ref object shtId, ref object xarr, ref object yarr, ref object PointTypArr)
        {
            return ComObject.GetLineSegments(ref shtId, ref xarr, ref yarr, ref PointTypArr);
        }

        public int GetLineStyle()
        {
            return ComObject.GetLineStyle();
        }

        public double GetLineWidth()
        {
            return ComObject.GetLineWidth();
        }

        public double GetManufacturingLength()
        {
            return ComObject.GetManufacturingLength();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetNetId()
        {
            return ComObject.GetNetId();
        }

        public int GetNodeIds(ref object ids)
        {
            return ComObject.GetNodeIds(ref ids);
        }

        public double GetOuterDiameter()
        {
            return ComObject.GetOuterDiameter();
        }

        public double GetRotation(int anchorid)
        {
            return ComObject.GetRotation(anchorid);
        }

        public double GetSchemaLength()
        {
            return ComObject.GetSchemaLength();
        }

        public int GetSignalIds(ref object ids)
        {
            return ComObject.GetSignalIds(ref ids);
        }

        public string GetSignalName()
        {
            return ComObject.GetSignalName();
        }

        public int GetSymbolCount()
        {
            return ComObject.GetSymbolCount();
        }

        public int GetSymbolIds(ref object ids)
        {
            return ComObject.GetSymbolIds(ref ids);
        }

        public string GetTranslatedSignalName()
        {
            return ComObject.GetTranslatedSignalName();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int Highlight()
        {
            return ComObject.Highlight();
        }

        public int IsBus()
        {
            return ComObject.IsBus();
        }

        public int IsOffline()
        {
            return ComObject.IsOffline();
        }

        public int IsPanelPath()
        {
            return ComObject.IsPanelPath();
        }

        public int IsView()
        {
            return ComObject.IsView();
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetAttributeVisibility(string name, int onoff)
        {
            return ComObject.SetAttributeVisibility(name, onoff);
        }

        public int SetBusName(string name)
        {
            return ComObject.SetBusName(name);
        }

        public int SetEffectiveDirection(int toID)
        {
            return ComObject.SetEffectiveDirection(toID);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetIgnoreForCablingTable(int set)
        {
            return ComObject.SetIgnoreForCablingTable(set);
        }

        public double SetLength(double newlen)
        {
            return ComObject.SetLength(newlen);
        }

        public int SetLevel(int level)
        {
            return ComObject.SetLevel(level);
        }

        public int SetLineColour(int newcol)
        {
            return ComObject.SetLineColour(newcol);
        }

        public int SetLineLevel(int newlev)
        {
            return ComObject.SetLineLevel(newlev);
        }

        public int SetLineStyle(int newstl)
        {
            return ComObject.SetLineStyle(newstl);
        }

        public int SetLineWidth(double newwid)
        {
            return ComObject.SetLineWidth(newwid);
        }

        public double SetManufacturingLength(double newval)
        {
            return ComObject.SetManufacturingLength(newval);
        }

        public int SetOptionExpressions(ref object expressions)
        {
            return ComObject.SetOptionExpressions(ref expressions);
        }

        public double SetRotation(int anchorid, double newval)
        {
            return ComObject.SetRotation(anchorid, newval);
        }

        public double SetSchemaLength(double newval)
        {
            return ComObject.SetSchemaLength(newval);
        }

        public int SetSignalName(string name)
        {
            return ComObject.SetSignalName(name);
        }
    }
}