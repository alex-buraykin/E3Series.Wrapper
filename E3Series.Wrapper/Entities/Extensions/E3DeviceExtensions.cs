using System.Collections.Generic;
using E3Series.Proxy;

namespace E3Series.Wrapper.Entities.Extensions
{
    public static class E3DeviceExtensions
    {
        /// <summary>
        /// Get assembly's child devices (with sub-devices)
        /// </summary>
        /// <param name="device">E3.series IDeviceInterface COM object</param>
        /// <param name="expandAll"><c>true</c> - with sub-devices, <c>false</c> - only top-level of child devices</param>
        /// <returns>IEnumerable of ids or empty collection</returns>
        public static IEnumerable<int> GetDeviceIdsEnumerable(this E3DeviceProxy device, bool expandAll)
        {
            if (device.GetDeviceCount() == 0)
                return new int[] { };

            object devIds = null;
            device.GetDeviceIds(ref devIds);

            if (!expandAll)
                return devIds.ToIEnumerable();

            var ret = new List<int>();
            foreach (var id in devIds.ToIEnumerable())
            {
                device.SetId(id);

                if (device.IsAssembly() == 1)
                    ret.AddRange(device.GetDeviceIdsEnumerable(true));
                else
                    ret.Add(id);
            }
            return ret;
        }
    }
}