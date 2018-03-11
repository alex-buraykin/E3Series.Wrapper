using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3OptionProxy : E3ProxyBase
    {
        public E3OptionProxy(object comObject) : base(comObject)
        {
        }

        public int Activate()
        {
            return ComObject.Activate();
        }

        public int ActivateAndLockOtherActivations()
        {
            return ComObject.ActivateAndLockOtherActivations();
        }

        public int Add(int devi)
        {
            return ComObject.Add(devi);
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int AssignToID(int parentid, int how)
        {
            return ComObject.AssignToID(parentid, how);
        }

        public int Create(string name, int parent = 0, int position = 0, int before = 0)
        {
            return ComObject.Create(name, parent, position, before);
        }

        public int CreateConfiguration(string name, int posId, int before)
        {
            return ComObject.CreateConfiguration(name, posId, before);
        }

        public int CreateHarnessDerivative(string name, int posId, int before)
        {
            return ComObject.CreateHarnessDerivative(name, posId, before);
        }

        public int CreateHarnessFamily(string name, int posId, int before)
        {
            return ComObject.CreateHarnessFamily(name, posId, before);
        }

        public int CreatePackage(string name, int posId, int before)
        {
            return ComObject.CreatePackage(name, posId, before);
        }

        public int Deactivate()
        {
            return ComObject.Deactivate();
        }

        public int Delete(int del)
        {
            return ComObject.Delete(del);
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int GetAllDeviceIds(ref object ids)
        {
            return ComObject.GetAllDeviceIds(ref ids);
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

        public string GetDescription()
        {
            return ComObject.GetDescription();
        }

        public int GetExclusiveOptionIds(ref object ids)
        {
            return ComObject.GetExclusiveOptionIds(ref ids);
        }

        public int GetFieldIds(ref object ids)
        {
            return ComObject.GetFieldIds(ref ids);
        }

        public string GetFullInternalName()
        {
            return ComObject.GetFullInternalName();
        }

        public string GetFullName()
        {
            return ComObject.GetFullName();
        }

        public int GetGraphIds(ref object ids)
        {
            return ComObject.GetGraphIds(ref ids);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetInclusiveOptionIds(ref object ids)
        {
            return ComObject.GetInclusiveOptionIds(ref ids);
        }

        public string GetInternalDescription()
        {
            return ComObject.GetInternalDescription();
        }

        public string GetInternalName()
        {
            return ComObject.GetInternalName();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetNetSegmentIds(ref object ids)
        {
            return ComObject.GetNetSegmentIds(ref ids);
        }

        public int GetOptionIds(ref object ids)
        {
            return ComObject.GetOptionIds(ref ids);
        }

        public int GetParentOptionId()
        {
            return ComObject.GetParentOptionId();
        }

        public int GetPinIds(ref object ids)
        {
            return ComObject.GetPinIds(ref ids);
        }

        public int GetPropertyFlags()
        {
            return ComObject.GetPropertyFlags();
        }

        public int GetSheetIds(ref object ids)
        {
            return ComObject.GetSheetIds(ref ids);
        }

        public int GetSymbolIds(ref object ids)
        {
            return ComObject.GetSymbolIds(ref ids);
        }

        public int GetTextIds(ref object ids, int txttyp = 0, string search_string = "")
        {
            return ComObject.GetTextIds(ref ids, txttyp, search_string);
        }

        public string GetXMLVariantID()
        {
            return ComObject.GetXMLVariantID();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int Highlight()
        {
            return ComObject.Highlight();
        }

        public int IsActive()
        {
            return ComObject.IsActive();
        }

        public int IsAssignable()
        {
            return ComObject.IsAssignable();
        }

        public int IsConfiguration()
        {
            return ComObject.IsConfiguration();
        }

        public int IsHarnessDerivative()
        {
            return ComObject.IsHarnessDerivative();
        }

        public int IsHarnessFamily()
        {
            return ComObject.IsHarnessFamily();
        }

        public int IsHighlighted()
        {
            return ComObject.IsHighlighted();
        }

        public int IsObjectActive(int objid)
        {
            return ComObject.IsObjectActive(objid);
        }

        public int IsPackage()
        {
            return ComObject.IsPackage();
        }

        public int IsVariant()
        {
            return ComObject.IsVariant();
        }

        public int MoveTo(int vari, int before = 0)
        {
            return ComObject.MoveTo(vari, before);
        }

        public int Remove(int devi)
        {
            return ComObject.Remove(devi);
        }

        public int ResetHighlight()
        {
            return ComObject.ResetHighlight();
        }

        public int Search(string name)
        {
            return ComObject.Search(name);
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetDescription(string newval)
        {
            return ComObject.SetDescription(newval);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetName(string name)
        {
            return ComObject.SetName(name);
        }

        public int SetPropertyFlags(int newflags)
        {
            return ComObject.SetPropertyFlags(newflags);
        }

        public int SetXMLVariantID(string name)
        {
            return ComObject.SetXMLVariantID(name);
        }

        public int Sort(int @ascending = 0)
        {
            return ComObject.Sort(@ascending);
        }

        public int UnassignFromID(int parentid)
        {
            return ComObject.UnassignFromID(parentid);
        }

        public int UnLockOtherActivations()
        {
            return ComObject.UnLockOtherActivations();
        }
    }
}