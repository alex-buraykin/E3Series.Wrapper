using System;
using System.Collections.Generic;
using E3Series.Proxy;

namespace E3Series.Wrapper.Entities.Extensions
{
    /// <summary>
    /// Extension methods for E3DeviceProxy interface
    /// </summary>
    public static class E3DeviceProxyExtensions
    {
        /// <summary>
        /// Get attributes ids for device
        /// </summary>
        /// <param name="device">E3.series e3Device proxy object</param>
        /// <param name="attributeName">Returns only attributes with name <c>attributeName</c></param>
        /// <returns>IEnumerable of ids or empty collection</returns>
        public static IEnumerable<int> GetAttributeIdsList(this E3DeviceProxy device, string attributeName = "")
        {
            if (attributeName == null)
                throw new ArgumentNullException(nameof(attributeName));

            object attIds = null;

            if (!string.IsNullOrWhiteSpace(attributeName))
            {
                if (!device.HasAttribute(attributeName).CastToBool())
                    return new int[] { };

                device.GetAttributeIds(ref attIds, attributeName);
                return attIds.ToIEnumerable();
            }

            if (device.GetAttributeCount() == 0)
                return new int[] { };

            device.GetAttributeIds(ref attIds);

            return attIds.ToIEnumerable();
        }
    }
}