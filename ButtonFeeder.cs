using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vJoyInterfaceWrap;

namespace EDStatus_Feeder
{
    class ButtonFeeder
    {
        public static void Feed(vJoy vjoy, Configuration config, EDStatusMonitor monitor)
        {
            // copy configuration and status to prevent changes from taking effect during the feed process
            uint deviceId = (uint)config.DeviceId;
            Dictionary<string, int> buttonIds = config.ButtonConfigurationCopy;
            Dictionary<string, bool> statusFlags = monitor.StatusCopy;

            if (!vjoy.AcquireVJD(deviceId))
                throw new ButtonFeederException($"vJoy error: Unable to acquire vJoy device #{deviceId}");

            foreach(string flag in statusFlags.Keys)
            {
                bool status = statusFlags[flag];
                char buttonId = (char)buttonIds[flag];
                vjoy.SetBtn(status, deviceId, buttonId);
            }

            vjoy.RelinquishVJD(deviceId);
        }
    }
}
