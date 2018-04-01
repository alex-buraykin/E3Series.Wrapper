using System.Collections.Generic;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities.Base.Interfaces
{
    public interface IE3Attributed
    {
        /// <summary>
        /// Check existance of attribute
        /// </summary>
        /// <param name="attributeName">Attribute name</param>
        /// <returns>True if exists, false - if not</returns>
        bool HasAttribute(string attributeName);

        /// <summary>
        /// Get attribute value
        /// </summary>
        /// <param name="attributeName">Attribute name</param>
        /// <returns>Attribute value</returns>
        string GetAttributeValue(string attributeName);

        /// <summary>
        /// Set attribute value
        /// </summary>
        /// <param name="attributeName">Attribute name</param>
        /// <param name="attributeValue">New value</param>
        /// <returns>Id of attribute if successful, otherwise 0</returns>
        int SetAttributeValue(string attributeName, string attributeValue);

        /// <summary>
        /// Delete attribute
        /// </summary>
        /// <param name="attributeName">Attribute name</param>
        /// <returns>number of deleted attributes if successful, otherwise 0</returns>
        int DeleteAttribute(string attributeName);

        /// <summary>
        /// Returns identifiers of all attributes used
        /// </summary>
        /// <returns></returns>
        IEnumerable<int> GetAttributeIds();

        /// <summary>
        /// Returns iterator of all attributes used
        /// </summary>
        /// <param name="iterator">IAttribute iterator</param>
        /// <returns></returns>
        IEnumerable<IAttribute> GetAttributes(IAttribute iterator);

        /// <summary>
        /// Returns iterator of all attributes used by attribute name
        /// </summary>
        /// <param name="iterator">IAttribute iterator</param>
        /// <param name="attributeName">Attribute name</param>
        /// <returns></returns>
        IEnumerable<IAttribute> GetAttributes(IAttribute iterator, string attributeName);
    }
}