using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3WespeProxy : E3ProxyBase
    {
        public E3WespeProxy(object comObject) : base(comObject)
        {
        }

        public int ChangeTextTo(int ttyp, int txtid)
        {
            return ComObject.ChangeTextTo(ttyp, txtid);
        }

        public object CreateProject(string name)
        {
            return ComObject.CreateProject(name);
        }

        public int CreateText(int ttyp, string value, int shtId, double x, double y)
        {
            return ComObject.CreateText(ttyp, value, shtId, x, y);
        }

        public int DeleteText(int txtid)
        {
            return ComObject.DeleteText(txtid);
        }

        public int DisintegrateDynamic(int symid, ref object ids)
        {
            return ComObject.DisintegrateDynamic(symid, ref ids);
        }

        public int GetCursorPosition(out object x, out object y, out object c, out object vk, out object modflg)
        {
            return ComObject.GetCursorPosition(out x, out y, out c, out vk, out modflg);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetInsideSymbolIds(int fldid, ref object ids)
        {
            return ComObject.GetInsideSymbolIds(fldid, ref ids);
        }

        public int GetNodeIds(int shti, ref object ids)
        {
            return ComObject.GetNodeIds(shti, ref ids);
        }

        public int IdentifyGraphIds(int shtId, ref object ids, double px, double py, double snap = 0, int Visible = 1)
        {
            return ComObject.IdentifyGraphIds(shtId, ref ids, px, py, snap, Visible);
        }

        public int IdentifyNetSegmentIds(int shtId, ref object ids, double px, double py, double snap = 0, int Visible = 1)
        {
            return ComObject.IdentifyNetSegmentIds(shtId, ref ids, px, py, snap, Visible);
        }

        public int IdentifyNodePoint(int shtId, out object fx, out object fy, double px, double py, double snap = 0, int Visible = 1)
        {
            return ComObject.IdentifyNodePoint(shtId, out fx, out fy, px, py, snap, Visible);
        }

        public int IdentifySymbolIds(int shtId, ref object ids, double px, double py, double snap = 0, int Visible = 1)
        {
            return ComObject.IdentifySymbolIds(shtId, ref ids, px, py, snap, Visible);
        }

        public int IdentifyTextIds(int shtId, ref object ids, double px, double py, double snap = 0, int Visible = 1)
        {
            return ComObject.IdentifyTextIds(shtId, ref ids, px, py, snap, Visible);
        }

        public object ImportSheet(string name, string filename)
        {
            return ComObject.ImportSheet(name, filename);
        }

        public int MergeIdsToDynamic(int symid, ref object ids)
        {
            return ComObject.MergeIdsToDynamic(symid, ref ids);
        }

        public int MoveIds(ref object ids, int inside_only, int structlimit, double offx, double offy, ref object modids)
        {
            return ComObject.MoveIds(ref ids, inside_only, structlimit, offx, offy, ref modids);
        }

        public int PlacePart(string name, string version, int symid, int shtId, double x, double y, double rot)
        {
            return ComObject.PlacePart(name, version, symid, shtId, x, y, rot);
        }

        public int PlacePartInteractively(string name, string version, int symid, out object x, out object y, out object rot)
        {
            return ComObject.PlacePartInteractively(name, version, symid, out x, out y, out rot);
        }

        public int PlacePolygonField(int shti, int pnts, ref object x, ref object y, int moveall = 0)
        {
            return ComObject.PlacePolygonField(shti, pnts, ref x, ref y, moveall);
        }

        public int SaveProject(string name)
        {
            return ComObject.SaveProject(name);
        }

        public int SetGraphLine(int gri, double x1, double y1, double x2, double y2)
        {
            return ComObject.SetGraphLine(gri, x1, y1, x2, y2);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetParentApp(object app)
        {
            return ComObject.SetParentApp(app);
        }
    }
}