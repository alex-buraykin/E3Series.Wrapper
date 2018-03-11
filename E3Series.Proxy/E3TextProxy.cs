using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3TextProxy : E3ProxyBase
    {
        public E3TextProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int CalculateBoxAt(int shti, string text, double x, double y, double rotation, double height, int mode, int style,
            string fontname, int just, int balloon, ref object bx, ref object by)
        {
            return ComObject.CalculateBoxAt(shti, text, x, y, rotation, height, mode, style, fontname, just, balloon, ref bx, ref by);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int DeleteBox()
        {
            return ComObject.DeleteBox();
        }

        public int GetAlignment()
        {
            return ComObject.GetAlignment();
        }

        public int GetAllowedLength()
        {
            return ComObject.GetAllowedLength();
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

        public int GetBallooning()
        {
            return ComObject.GetBallooning();
        }

        public int GetBox(ref object xsize, ref object ysize)
        {
            return ComObject.GetBox(ref xsize, ref ysize);
        }

        public int GetColour()
        {
            return ComObject.GetColour();
        }

        public string GetFontName()
        {
            return ComObject.GetFontName();
        }

        public double GetHeight()
        {
            return ComObject.GetHeight();
        }

        public string GetHyperlinkAddress()
        {
            return ComObject.GetHyperlinkAddress();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetInternalText()
        {
            return ComObject.GetInternalText();
        }

        public int GetLanguageId()
        {
            return ComObject.GetLanguageId();
        }

        public int GetLeftJustifiedSchemaLocation(ref object x, ref object y, ref object grid)
        {
            return ComObject.GetLeftJustifiedSchemaLocation(ref x, ref y, ref grid);
        }

        public int GetLevel()
        {
            return ComObject.GetLevel();
        }

        public int GetLocking()
        {
            return ComObject.GetLocking();
        }

        public int GetMode()
        {
            return ComObject.GetMode();
        }

        public int GetRightJustifiedSchemaLocation(ref object x, ref object y, ref object grid)
        {
            return ComObject.GetRightJustifiedSchemaLocation(ref x, ref y, ref grid);
        }

        public double GetRotation()
        {
            return ComObject.GetRotation();
        }

        public int GetSchemaLocation(ref object x, ref object y, ref object grid)
        {
            return ComObject.GetSchemaLocation(ref x, ref y, ref grid);
        }

        public int GetSchemaLocation(ref object x, ref object y, ref object grid, ref object column_value)
        {
            return ComObject.GetSchemaLocation(ref x, ref y, ref grid, ref column_value);
        }

        public int GetSchemaLocation(ref object x, ref object y, ref object grid, ref object column_value,
            ref object row_value)
        {
            return ComObject.GetSchemaLocation(ref x, ref y, ref grid, ref column_value, ref row_value);
        }

        public int GetSingleLine()
        {
            return ComObject.GetSingleLine();
        }

        public int GetStyle()
        {
            return ComObject.GetStyle();
        }

        public string GetText()
        {
            return ComObject.GetText();
        }

        public int GetTextExtent(ref object xarr, ref object yarr)
        {
            return ComObject.GetTextExtent(ref xarr, ref yarr);
        }

        public int GetTextExtentSingleLine(ref object nlines, ref object xarr, ref object yarr)
        {
            return ComObject.GetTextExtentSingleLine(ref nlines, ref xarr, ref yarr);
        }

        public int GetTypeId()
        {
            return ComObject.GetTypeId();
        }

        public int GetVisibility()
        {
            return ComObject.GetVisibility();
        }

        public double GetWidth()
        {
            return ComObject.GetWidth();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int IsOffline()
        {
            return ComObject.IsOffline();
        }

        public int IsRedlined()
        {
            return ComObject.IsRedlined();
        }

        public int SetAlignment(int newval)
        {
            return ComObject.SetAlignment(newval);
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetBallooning(int onoff, int type)
        {
            return ComObject.SetBallooning(onoff, type);
        }

        public int SetBox(double xsize, double ysize)
        {
            return ComObject.SetBox(xsize, ysize);
        }

        public int SetColour(int newval)
        {
            return ComObject.SetColour(newval);
        }

        public int SetFontName(string newname)
        {
            return ComObject.SetFontName(newname);
        }

        public int SetHeight(double newval)
        {
            return ComObject.SetHeight(newval);
        }

        public int SetHyperlinkAddress(string newtext)
        {
            return ComObject.SetHyperlinkAddress(newtext);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetLanguageId(int newval)
        {
            return ComObject.SetLanguageId(newval);
        }

        public int SetLevel(int newval)
        {
            return ComObject.SetLevel(newval);
        }

        public int SetLocking(int newval)
        {
            return ComObject.SetLocking(newval);
        }

        public int SetMode(int newval)
        {
            return ComObject.SetMode(newval);
        }

        public int SetOptionExpressions(ref object expressions)
        {
            return ComObject.SetOptionExpressions(ref expressions);
        }

        public double SetRotation(double rotation)
        {
            return ComObject.SetRotation(rotation);
        }

        public int SetSchemaLocation(double x, double y)
        {
            return ComObject.SetSchemaLocation(x, y);
        }

        public int SetSingleLine(int newval)
        {
            return ComObject.SetSingleLine(newval);
        }

        public int SetStyle(int newval)
        {
            return ComObject.SetStyle(newval);
        }

        public int SetText(string newtext)
        {
            return ComObject.SetText(newtext);
        }

        public int SetVisibility(int newval)
        {
            return ComObject.SetVisibility(newval);
        }
    }
}