using System.Collections.Generic;
using E3Series.Proxy;
using E3Series.Wrapper.Entities.Models;

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

        /// <summary>
        /// Get pin ids for device
        /// </summary>
        /// <param name="device">E3.series IDeviceInterface COM object</param>
        /// <returns>IEnumerable of ids or empty collection</returns>
        public static IEnumerable<int> GetPinIdsEnumerable(this E3DeviceProxy device)
        {
            if (device.GetPinCount() == 0)
                return new int[] { };

            object pinIds = null;
            device.GetPinIds(ref pinIds);

            return pinIds.ToIEnumerable();
        }

        /// <summary>
        /// Get symbol ids for device
        /// </summary>
        /// <param name="device">E3.series IDeviceInterface COM object</param>
        /// <param name="mode">Symbol type</param>
        /// <returns>IEnumerable of ids or empty collection</returns>
        public static IEnumerable<int> GetSymbolIdsEnumerable(
            this E3DeviceProxy device,
            SymbolModeEnum mode = SymbolModeEnum.AllSymbols)
        {
            if (device.GetSymbolCount((int) mode) == 0)
                return new int[] { };

            object symIds = null;
            device.GetSymbolIds(ref symIds, (int) mode);

            return symIds.ToIEnumerable();
        }

        /// <summary>
        /// Get panel location for device
        /// </summary>
        /// <param name="device">E3.series IDeviceInterface COM object</param>
        /// <returns>Panel location struct or null if not placed</returns>
        public static PanelLocationStruct? GetPanelLocation(this E3DeviceProxy device)
        {
            if (device.GetPanelLocation(out var x, out var y, out var z, out var rot) == 0)
                return null;

            return new PanelLocationStruct((double)x, (double)y, (double)z, rot as string);
        }
    }
}