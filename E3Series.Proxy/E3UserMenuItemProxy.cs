using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3UserMenuItemProxy : E3ProxyBase
    {
        public E3UserMenuItemProxy(object comObject) : base(comObject)
        {
        }

        public int Create(int id, string text, string command, string parameters, string folder, string image, string shortcut,
            int Visible, int wait, int flags = 1)
        {
            return ComObject.Create(id, text, command, parameters, folder, image, shortcut, Visible, wait, flags);
        }

        public int CreateContextSeparator(string text)
        {
            return ComObject.CreateContextSeparator(text);
        }

        public int CreateContextUserTool(string text, string command)
        {
            return ComObject.CreateContextUserTool(text, command);
        }

        public int CreateSeparator(string text)
        {
            return ComObject.CreateSeparator(text);
        }

        public int CreateUserTool(string text, string command)
        {
            return ComObject.CreateUserTool(text, command);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteContext()
        {
            return ComObject.DeleteContext();
        }

        public int DeleteUserTool()
        {
            return ComObject.DeleteUserTool();
        }

        public string GetCommand()
        {
            return ComObject.GetCommand();
        }

        public string GetDescription()
        {
            return ComObject.GetDescription();
        }

        public int GetEnable()
        {
            return ComObject.GetEnable();
        }

        public string GetFolder()
        {
            return ComObject.GetFolder();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetImage()
        {
            return ComObject.GetImage();
        }

        public string GetParameters()
        {
            return ComObject.GetParameters();
        }

        public string GetShortCut()
        {
            return ComObject.GetShortCut();
        }

        public string GetText()
        {
            return ComObject.GetText();
        }

        public int GetVisible()
        {
            return ComObject.GetVisible();
        }

        public int GetWaitForEndOfCommand()
        {
            return ComObject.GetWaitForEndOfCommand();
        }

        public int IsDeleted()
        {
            return ComObject.IsDeleted();
        }

        public int SetCommand(string newval)
        {
            return ComObject.SetCommand(newval);
        }

        public int SetDescription(string newval)
        {
            return ComObject.SetDescription(newval);
        }

        public int SetEnable(int newval)
        {
            return ComObject.SetEnable(newval);
        }

        public int SetFolder(string newval)
        {
            return ComObject.SetFolder(newval);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetImage(string newval)
        {
            return ComObject.SetImage(newval);
        }

        public int SetParameters(string newval)
        {
            return ComObject.SetParameters(newval);
        }

        public int SetShortCut(string newval)
        {
            return ComObject.SetShortCut(newval);
        }

        public int SetText(string newval)
        {
            return ComObject.SetText(newval);
        }

        public int SetVisible(int newval)
        {
            return ComObject.SetVisible(newval);
        }

        public int SetWaitForEndOfCommand(int newval)
        {
            return ComObject.SetWaitForEndOfCommand(newval);
        }

        public int UnDelete()
        {
            return ComObject.UnDelete();
        }

        public int UpdateUserInterface()
        {
            return ComObject.UpdateUserInterface();
        }
    }
}