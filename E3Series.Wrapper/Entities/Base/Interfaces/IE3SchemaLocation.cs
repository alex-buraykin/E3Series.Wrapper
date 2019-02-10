using E3Series.Wrapper.Entities.Models;

namespace E3Series.Wrapper.Entities.Base.Interfaces
{
    public interface IE3SchemaLocation
    {
        /// <summary>
        /// Check for object is placed on the sheet
        /// </summary>
        /// <returns></returns>
        bool IsPlaced();

        /// <summary>
        /// Get coordinates of object on the sheet. Null if not placed
        /// </summary>
        /// <returns></returns>
        SchemaLocationStruct? GetSchemaLocationStruct();
    }
}