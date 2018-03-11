using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3GraphProxy : E3ProxyBase
    {
        public E3GraphProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int CreateArc(int shti, double x, double y, double radius, double start, double end)
        {
            return ComObject.CreateArc(shti, x, y, radius, start, end);
        }

        public int CreateCircle(int shti, double x, double y, double radius)
        {
            return ComObject.CreateCircle(shti, x, y, radius);
        }

        public int CreateCurve(int shti, int pnts, ref object x, ref object y)
        {
            return ComObject.CreateCurve(shti, pnts, ref x, ref y);
        }

        public int CreateFromSymbol(int shti, double x, double y, string rot, double scale, int maintaintextsize, string symnam,
            string symver)
        {
            return ComObject.CreateFromSymbol(shti, x, y, rot, scale, maintaintextsize, symnam, symver);
        }

        public int CreateGroup(ref object ids)
        {
            return ComObject.CreateGroup(ref ids);
        }

        public int CreateImage(int sheetid, double xpos, double ypos, double xsize, double ysize, string filename, int embed = 1)
        {
            return ComObject.CreateImage(sheetid, xpos, ypos, xsize, ysize, filename, embed);
        }

        public int CreateLine(int shti, double x1, double y1, double x2, double y2)
        {
            return ComObject.CreateLine(shti, x1, y1, x2, y2);
        }

        public int CreateMeasure(int shti, double x1, double y1, double x2, double y2)
        {
            return ComObject.CreateMeasure(shti, x1, y1, x2, y2);
        }

        public int CreatePolygon(int shti, int pnts, ref object x, ref object y)
        {
            return ComObject.CreatePolygon(shti, pnts, ref x, ref y);
        }

        public int CreateRectangle(int shti, double x1, double y1, double x2, double y2)
        {
            return ComObject.CreateRectangle(shti, x1, y1, x2, y2);
        }

        public int CreateRotatedText(int shti, string text, double x, double y, double rotation)
        {
            return ComObject.CreateRotatedText(shti, text, x, y, rotation);
        }

        public int CreateText(int shti, string text, double x, double y)
        {
            return ComObject.CreateText(shti, text, x, y);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int GetArc(ref object xm, ref object ym, ref object rad, ref object startang, ref object endang)
        {
            return ComObject.GetArc(ref xm, ref ym, ref rad, ref startang, ref endang);
        }

        public int GetArrows()
        {
            return ComObject.GetArrows();
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

        public int GetCircle(ref object xm, ref object ym, ref object rad)
        {
            return ComObject.GetCircle(ref xm, ref ym, ref rad);
        }

        public int GetColour()
        {
            return ComObject.GetColour();
        }

        public int GetCurve(ref object npnts, ref object xarr, ref object yarr)
        {
            return ComObject.GetCurve(ref npnts, ref xarr, ref yarr);
        }

        public int GetGraphCount()
        {
            return ComObject.GetGraphCount();
        }

        public int GetGraphIds(ref object ids)
        {
            return ComObject.GetGraphIds(ref ids);
        }

        public int GetHatchColour()
        {
            return ComObject.GetHatchColour();
        }

        public double GetHatchLineDistance()
        {
            return ComObject.GetHatchLineDistance();
        }

        public int GetHatchLineStyle()
        {
            return ComObject.GetHatchLineStyle();
        }

        public double GetHatchLineWidth()
        {
            return ComObject.GetHatchLineWidth();
        }

        public int GetHatchPattern(out object angle1, out object angle2)
        {
            return ComObject.GetHatchPattern(out angle1, out angle2);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetImageInfo(ref object xpos, ref object ypos, ref object xsize, ref object ysize, ref object filename,
            ref object embed)
        {
            return ComObject.GetImageInfo(ref xpos, ref ypos, ref xsize, ref ysize, ref filename, ref embed);
        }

        public string GetInternalText()
        {
            return ComObject.GetInternalText();
        }

        public int GetLanguageId()
        {
            return ComObject.GetLanguageId();
        }

        public int GetLevel()
        {
            return ComObject.GetLevel();
        }

        public int GetLine(ref object x1, ref object y1, ref object x2, ref object y2)
        {
            return ComObject.GetLine(ref x1, ref y1, ref x2, ref y2);
        }

        public int GetLineColour()
        {
            return ComObject.GetLineColour();
        }

        public int GetLineStyle()
        {
            return ComObject.GetLineStyle();
        }

        public double GetLineWidth()
        {
            return ComObject.GetLineWidth();
        }

        public int GetParentID()
        {
            return ComObject.GetParentID();
        }

        public int GetPolygon(ref object npnts, ref object xarr, ref object yarr)
        {
            return ComObject.GetPolygon(ref npnts, ref xarr, ref yarr);
        }

        public int GetRectangle(ref object x1, ref object y1, ref object x2, ref object y2)
        {
            return ComObject.GetRectangle(ref x1, ref y1, ref x2, ref y2);
        }

        public string GetText()
        {
            return ComObject.GetText();
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

        public int GetTextLeftJustifiedSchemaLocation(ref object x, ref object y, ref object grid)
        {
            return ComObject.GetTextLeftJustifiedSchemaLocation(ref x, ref y, ref grid);
        }

        public int GetTextMode()
        {
            return ComObject.GetTextMode();
        }

        public double GetTextRotation()
        {
            return ComObject.GetTextRotation();
        }

        public int GetTextStyle()
        {
            return ComObject.GetTextStyle();
        }

        public int GetTypeId()
        {
            return ComObject.GetTypeId();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int IsRedlined()
        {
            return ComObject.IsRedlined();
        }

        public int Place(double x, double y)
        {
            return ComObject.Place(x, y);
        }

        public int SaveImage(string filename)
        {
            return ComObject.SaveImage(filename);
        }

        public int SetArrows(int newarrows)
        {
            return ComObject.SetArrows(newarrows);
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetColour(int newcol)
        {
            return ComObject.SetColour(newcol);
        }

        public int SetHatchColour(int newcol)
        {
            return ComObject.SetHatchColour(newcol);
        }

        public double SetHatchLineDistance(double newdist)
        {
            return ComObject.SetHatchLineDistance(newdist);
        }

        public int SetHatchLineStyle(int newstyle)
        {
            return ComObject.SetHatchLineStyle(newstyle);
        }

        public double SetHatchLineWidth(double newwid)
        {
            return ComObject.SetHatchLineWidth(newwid);
        }

        public int SetHatchPattern(int newpat, double angle1, double angle2)
        {
            return ComObject.SetHatchPattern(newpat, angle1, angle2);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetImageInfo(double xpos, double ypos, double xsize, double ysize, string filename = null, int embed = -1)
        {
            return ComObject.SetImageInfo(xpos, ypos, xsize, ysize, filename, embed);
        }

        public int SetLanguageId(int newval)
        {
            return ComObject.SetLanguageId(newval);
        }

        public int SetLevel(int newlev)
        {
            return ComObject.SetLevel(newlev);
        }

        public int SetLineColour(int newcol)
        {
            return ComObject.SetLineColour(newcol);
        }

        public int SetLineStyle(int newstyle)
        {
            return ComObject.SetLineStyle(newstyle);
        }

        public double SetLineWidth(double newwid)
        {
            return ComObject.SetLineWidth(newwid);
        }

        public int SetOptionExpressions(ref object expressions)
        {
            return ComObject.SetOptionExpressions(ref expressions);
        }

        public int SetParentID(int id)
        {
            return ComObject.SetParentID(id);
        }

        public int SetText(string newtext)
        {
            return ComObject.SetText(newtext);
        }

        public int SetTextColour(int newcol)
        {
            return ComObject.SetTextColour(newcol);
        }

        public int SetTextFontName(string newname)
        {
            return ComObject.SetTextFontName(newname);
        }

        public int SetTextHeight(double hgt)
        {
            return ComObject.SetTextHeight(hgt);
        }

        public int SetTextMode(int newmod)
        {
            return ComObject.SetTextMode(newmod);
        }

        public int SetTextStyle(int newstl)
        {
            return ComObject.SetTextStyle(newstl);
        }

        public int UnGroup(ref object ids)
        {
            return ComObject.UnGroup(ref ids);
        }
    }
}