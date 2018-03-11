using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3DimensionProxy : E3ProxyBase
    {
        public E3DimensionProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int Create(int shtId, double x1, double y1, double x2, double y2, int flags, double distance, string text, double tx,
            double ty)
        {
            return ComObject.Create(shtId, x1, y1, x2, y2, flags, distance, text, tx, ty);
        }

        public int CreateEx(int dimtyp, int sheet, ref object x, ref object y, int flags = 0)
        {
            return ComObject.CreateEx(dimtyp, sheet, ref x, ref y, flags);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int GetArrowMode()
        {
            return ComObject.GetArrowMode();
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

        public int GetColour()
        {
            return ComObject.GetColour();
        }

        public int GetDimensionedIds(ref object anyids)
        {
            return ComObject.GetDimensionedIds(ref anyids);
        }

        public string GetDisplayAttribute()
        {
            return ComObject.GetDisplayAttribute();
        }

        public double GetExtension()
        {
            return ComObject.GetExtension();
        }

        public double GetExtensionLineOffset()
        {
            return ComObject.GetExtensionLineOffset();
        }

        public int GetHideLongerPart()
        {
            return ComObject.GetHideLongerPart();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetLevel()
        {
            return ComObject.GetLevel();
        }

        public double GetLineWidth()
        {
            return ComObject.GetLineWidth();
        }

        public double GetOffset()
        {
            return ComObject.GetOffset();
        }

        public int GetParameters(out object x1, out object y1, out object x2, out object y2, out object distance, out object flags,
            out object text, out object tx, out object ty)
        {
            return ComObject.GetParameters(out x1, out y1, out x2, out y2, out distance, out flags, out text, out tx, out ty);
        }

        public int GetPartIds(out object ids)
        {
            return ComObject.GetPartIds(out ids);
        }

        public int GetPrecision()
        {
            return ComObject.GetPrecision();
        }

        public string GetPrefix()
        {
            return ComObject.GetPrefix();
        }

        public int GetRunningDimTextRotation()
        {
            return ComObject.GetRunningDimTextRotation();
        }

        public string GetSuffix()
        {
            return ComObject.GetSuffix();
        }

        public double GetSuffixSizeFactor()
        {
            return ComObject.GetSuffixSizeFactor();
        }

        public int GetText(out object text, out object @fixed)
        {
            return ComObject.GetText(out text, out @fixed);
        }

        public int GetTextColour()
        {
            return ComObject.GetTextColour();
        }

        public string GetTextFontName()
        {
            return ComObject.GetTextFontName();
        }

        public double GetTextHeight()
        {
            return ComObject.GetTextHeight();
        }

        public int GetTextStyle()
        {
            return ComObject.GetTextStyle();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int IsAlongPath()
        {
            return ComObject.IsAlongPath();
        }

        public int IsPartOfDimension()
        {
            return ComObject.IsPartOfDimension();
        }

        public int IsRunningDimension()
        {
            return ComObject.IsRunningDimension();
        }

        public int SetArrowMode(int value)
        {
            return ComObject.SetArrowMode(value);
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetColour(int value)
        {
            return ComObject.SetColour(value);
        }

        public int SetDisplayAttribute(string attnam)
        {
            return ComObject.SetDisplayAttribute(attnam);
        }

        public double SetExtension(double value)
        {
            return ComObject.SetExtension(value);
        }

        public double SetExtensionLineOffset(double value)
        {
            return ComObject.SetExtensionLineOffset(value);
        }

        public int SetHideLongerPart(int value)
        {
            return ComObject.SetHideLongerPart(value);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetLevel(int value)
        {
            return ComObject.SetLevel(value);
        }

        public double SetLineWidth(double value)
        {
            return ComObject.SetLineWidth(value);
        }

        public double SetOffset(double value)
        {
            return ComObject.SetOffset(value);
        }

        public int SetPrecision(int value)
        {
            return ComObject.SetPrecision(value);
        }

        public string SetPrefix(string value)
        {
            return ComObject.SetPrefix(value);
        }

        public int SetRunningDimTextRotation(int value)
        {
            return ComObject.SetRunningDimTextRotation(value);
        }

        public string SetSuffix(string value)
        {
            return ComObject.SetSuffix(value);
        }

        public double SetSuffixSizeFactor(double value)
        {
            return ComObject.SetSuffixSizeFactor(value);
        }

        public int SetText(string text, int @fixed)
        {
            return ComObject.SetText(text, @fixed);
        }

        public int SetTextColour(int value)
        {
            return ComObject.SetTextColour(value);
        }

        public string SetTextFontName(string text)
        {
            return ComObject.SetTextFontName(text);
        }

        public double SetTextHeight(double value)
        {
            return ComObject.SetTextHeight(value);
        }

        public int SetTextStyle(int value)
        {
            return ComObject.SetTextStyle(value);
        }
    }
}