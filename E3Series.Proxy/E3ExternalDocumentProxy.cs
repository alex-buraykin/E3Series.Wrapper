using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3ExternalDocumentProxy : E3ProxyBase
    {
        public E3ExternalDocumentProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int checkin(int unlock = 1)
        {
            return ComObject.checkin(unlock);
        }

        public int CheckOut(int @lock = 1)
        {
            return ComObject.CheckOut(@lock);
        }

        public int Create(int modi, string name, string file)
        {
            return ComObject.Create(modi, name, file);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int Display()
        {
            return ComObject.Display();
        }

        public string GetAssignment()
        {
            return ComObject.GetAssignment();
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

        public string GetFile()
        {
            return ComObject.GetFile();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetInternalName()
        {
            return ComObject.GetInternalName();
        }

        public string GetLocation()
        {
            return ComObject.GetLocation();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public string GetOwner()
        {
            return ComObject.GetOwner();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int InsertFile(int modi, string name, string file)
        {
            return ComObject.InsertFile(modi, name, file);
        }

        public int IsOffline()
        {
            return ComObject.IsOffline();
        }

        public int IsReadOnly()
        {
            return ComObject.IsReadOnly();
        }

        public int IsVisible()
        {
            return ComObject.IsVisible();
        }

        public int MoveTo(int position, int before = 0)
        {
            return ComObject.MoveTo(position, before);
        }

        public int Remove()
        {
            return ComObject.Remove();
        }

        public int Save()
        {
            return ComObject.Save();
        }

        public int Search(int modi, string name)
        {
            return ComObject.Search(modi, name);
        }

        public int SetAssignment(string newass)
        {
            return ComObject.SetAssignment(newass);
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetCompleteName(string newnam, string newass, string newloc)
        {
            return ComObject.SetCompleteName(newnam, newass, newloc);
        }

        public int SetCompleteNameEx(string newnam, string newass, string newloc, int onlygiven)
        {
            return ComObject.SetCompleteNameEx(newnam, newass, newloc, onlygiven);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetLocation(string newloc)
        {
            return ComObject.SetLocation(newloc);
        }

        public string SetName(string newname)
        {
            return ComObject.SetName(newname);
        }

        public int SetVisible(int Visible = 1)
        {
            return ComObject.SetVisible(Visible);
        }

        public int Visible()
        {
            return ComObject.Visible();
        }
    }
}