using E3Series.Proxy.Abstract;

namespace E3Series.Proxy
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
    public sealed class E3TreeProxy : E3ProxyBase
    {
        public E3TreeProxy(object comObject) : base(comObject)
        {
        }

        public int Create(string name, int position = 0, int before = 0)
        {
            return ComObject.Create(name, position, before);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetNames(ref object names)
        {
            return ComObject.GetNames(ref names);
        }

        public int GetSelectedAllDeviceIds(ref object ids)
        {
            return ComObject.GetSelectedAllDeviceIds(ref ids);
        }

        public int GetSelectedAllDeviceIdsByFolder(ref object ids)
        {
            return ComObject.GetSelectedAllDeviceIdsByFolder(ref ids);
        }

        public int GetSelectedBlockIds(ref object ids)
        {
            return ComObject.GetSelectedBlockIds(ref ids);
        }

        public int GetSelectedBundleIds(ref object ids)
        {
            return ComObject.GetSelectedBundleIds(ref ids);
        }

        public int GetSelectedCableIds(ref object ids)
        {
            return ComObject.GetSelectedCableIds(ref ids);
        }

        public int GetSelectedConnectorIds(ref object ids)
        {
            return ComObject.GetSelectedConnectorIds(ref ids);
        }

        public int GetSelectedDeviceIds(ref object ids)
        {
            return ComObject.GetSelectedDeviceIds(ref ids);
        }

        public int GetSelectedExternalDocumentIds(ref object ids)
        {
            return ComObject.GetSelectedExternalDocumentIds(ref ids);
        }

        public int GetSelectedExternalDocumentIdsByFolder(ref object ids)
        {
            return ComObject.GetSelectedExternalDocumentIdsByFolder(ref ids);
        }

        public int GetSelectedPinIds(ref object ids)
        {
            return ComObject.GetSelectedPinIds(ref ids);
        }

        public int GetSelectedSheetIds(ref object ids)
        {
            return ComObject.GetSelectedSheetIds(ref ids);
        }

        public int GetSelectedSheetIdsByFolder(ref object ids)
        {
            return ComObject.GetSelectedSheetIdsByFolder(ref ids);
        }

        public int GetSelectedStructureNodeIds(ref object ids)
        {
            return ComObject.GetSelectedStructureNodeIds(ref ids);
        }

        public int GetSelectedSymbolIds(ref object ids)
        {
            return ComObject.GetSelectedSymbolIds(ref ids);
        }

        public int GetSelectedTerminalIds(ref object ids)
        {
            return ComObject.GetSelectedTerminalIds(ref ids);
        }

        public int GetSortingMethod(ref object flags, ref object structure, ref object freetab)
        {
            return ComObject.GetSortingMethod(ref flags, ref structure, ref freetab);
        }

        public int GetVisibleInfoTypes(ref object views, ref object schematic)
        {
            return ComObject.GetVisibleInfoTypes(ref views, ref schematic);
        }

        public int GetVisibleInfoTypesEx(ref object views, ref object schematicTypes, ref object formboardSheetIds)
        {
            return ComObject.GetVisibleInfoTypesEx(ref views, ref schematicTypes, ref formboardSheetIds);
        }

        public int GetVisibleObjectTypes(ref object type_array)
        {
            return ComObject.GetVisibleObjectTypes(ref type_array);
        }

        public int IsActive()
        {
            return ComObject.IsActive();
        }

        public int IsVisible()
        {
            return ComObject.IsVisible();
        }

        public int SetIcon(string filename, int index = 0)
        {
            return ComObject.SetIcon(filename, index);
        }

        public int SetId(int treeid)
        {
            return ComObject.SetId(treeid);
        }

        public int SetName(string name)
        {
            return ComObject.SetName(name);
        }

        public int SetNames(ref object names)
        {
            return ComObject.SetNames(ref names);
        }

        public int SetSortingMethod(int flags, ref object structure, ref object freetab)
        {
            return ComObject.SetSortingMethod(flags, ref structure, ref freetab);
        }

        public int SetVisibleInfoTypes(string views, string schematic)
        {
            return ComObject.SetVisibleInfoTypes(views, schematic);
        }

        public int SetVisibleInfoTypesEx(ref object views, ref object schematicTypes, ref object formboardSheetIds)
        {
            return ComObject.SetVisibleInfoTypesEx(ref views, ref schematicTypes, ref formboardSheetIds);
        }

        public int SetVisibleObjectTypes(ref object type_array)
        {
            return ComObject.SetVisibleObjectTypes(ref type_array);
        }

        public int ViewSignalTree(int bShowTree)
        {
            return ComObject.ViewSignalTree(bShowTree);
        }
    }
}