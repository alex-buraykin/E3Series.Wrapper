using E3Series.Proxy;
using E3Series.Wrapper.Entities.Models;

namespace E3Series.Wrapper.Entities.Extensions
{
    public static class E3FieldExtensions
    {
        /// <summary>
        /// Get schema location for field
        /// </summary>
        /// <param name="proxy">E3.series IFieldInterface COM proxy object</param>
        /// <returns>Schema location struct or null if not placed</returns>
        public static SchemaLocationStruct? GetSchemaLocationStruct(this E3FieldProxy proxy)
        {
            object x = null;
            object y = null;
            object grid = null;
            int sheetId = proxy.GetSchemaLocation(ref x, ref y, ref grid);
            if (sheetId == 0)
                return null;

            return new SchemaLocationStruct((double)x, (double)y, grid as string, sheetId);
        }


        /// <summary>
        /// Check for field is placed on the sheet
        /// </summary>
        /// <param name="proxy">E3.series IFieldInterface COM proxy object</param>
        /// <returns></returns>
        public static bool IsPlaced(this E3FieldProxy proxy) => proxy.GetSchemaLocationStruct().HasValue;
    }
}