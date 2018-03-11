using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3GroupProxy : E3ProxyBase
    {
        public E3GroupProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int AddItems(ref object ids)
        {
            return ComObject.AddItems(ref ids);
        }

        public int Create(ref object ids, string name = null)
        {
            return ComObject.Create(ref ids, name);
        }

        public int Delete(ref object ids)
        {
            return ComObject.Delete(ref ids);
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int DeleteContents()
        {
            return ComObject.DeleteContents();
        }

        public int DeleteUnplaced()
        {
            return ComObject.DeleteUnplaced();
        }

        public int GetAttributeIds(ref object ids, string name = null)
        {
            return ComObject.GetAttributeIds(ref ids, name);
        }

        public string GetAttributeValue(string name)
        {
            return ComObject.GetAttributeValue(name);
        }

        public int GetGroupId(int id)
        {
            return ComObject.GetGroupId(id);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetItems(ref object ids)
        {
            return ComObject.GetItems(ref ids);
        }

        public int GetLocation(ref object x, ref object y, ref object z, ref object grid)
        {
            return ComObject.GetLocation(ref x, ref y, ref z, ref grid);
        }

        public int GetLocation(ref object x, ref object y, ref object z, ref object grid, ref object column_value)
        {
            return ComObject.GetLocation(ref x, ref y, ref z, ref grid, ref column_value);
        }

        public int GetLocation(ref object x, ref object y, ref object z, ref object grid, ref object column_value,
            ref object row_value)
        {
            return ComObject.GetLocation(ref x, ref y, ref z, ref grid, ref column_value, ref row_value);
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public string GetPartName()
        {
            return ComObject.GetPartName();
        }

        public int IsPart()
        {
            return ComObject.IsPart();
        }

        public int IsSubCircuit()
        {
            return ComObject.IsSubCircuit();
        }

        public int IsUnplaced()
        {
            return ComObject.IsUnplaced();
        }

        public int Place(int shtId, double x, double y, double z, double rotation)
        {
            return ComObject.Place(shtId, x, y, z, rotation);
        }

        public int PlaceInteractively()
        {
            return ComObject.PlaceInteractively();
        }

        public int RemoveItems(ref object ids)
        {
            return ComObject.RemoveItems(ref ids);
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

        public int SetPartName(string name)
        {
            return ComObject.SetPartName(name);
        }

        public int Unplace()
        {
            return ComObject.Unplace();
        }

        public int UpdatePart()
        {
            return ComObject.UpdatePart();
        }
    }
}