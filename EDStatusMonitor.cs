using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace EDStatusFeeder
{
    public delegate void ChangedEvent();

    class EDStatusMonitor
    {
        public event ChangedEvent Changed;

        public static string[] flagNames = {
            "docked",
            "landed",
            "landing_gear",
            "shields",
            "supercruise",
            "fa_off",
            "hardpoints",
            "wing",
            "lights",
            "cargo_scoop",
            "silent_run",
            "fuel_scoop",
            "srv_brake",
            "srv_turret",
            "srv_board",
            "srv_da",
            "fsd_masslock",
            "fsd_charge",
            "fsd_cool",
            "low_fuel",
            "overheat",
            "has_lat_long",
            "in_danger",
            "interdiction",
            "in_ship",
            "in_fighter",
            "in_srv",
            "analysis_mode",
            "nightvision",
            "alt_from_avg_radius",
            "fsd_jump",
            "srv_high_beam"
        };

        private static readonly Dictionary<string, bool> flags = new Dictionary<string, bool>();

        private static readonly FileSystemWatcher watcher = new FileSystemWatcher();

        private static readonly EDStatusMonitor monitor = new EDStatusMonitor();

        public static EDStatusMonitor MonitorInstance
        {
            get
            {
                return EDStatusMonitor.monitor;
            }
        }

        [DllImport("Shell32.dll")]
        private static extern int SHGetKnownFolderPath(
            [MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken,
           out IntPtr ppszPath);

        private EDStatusMonitor()
        {
            System.Diagnostics.Debug.WriteLine("Status Monitor Init");
            foreach (string name in flagNames)
            {
                flags[name] = false;
            }

            Guid guid = new Guid("{4C5C32FF-BB9D-43b0-B5B4-2D72E54EAAA4}");
            if (SHGetKnownFolderPath(guid, 0, new IntPtr(0), out IntPtr outPath) == 0)
            {
                string savedGamesPath = Marshal.PtrToStringUni(outPath);
                Marshal.FreeCoTaskMem(outPath);

                watcher.Path = $"{savedGamesPath}\\Frontier Developments\\Elite Dangerous";
                UpdateFlags();
                watcher.Filter = "Status.json";
                watcher.Changed += StatusFileChanged;
                watcher.EnableRaisingEvents = true;
            }
        }

        private static void StatusFileChanged(object sender, FileSystemEventArgs eventArgs)
        {
            try
            {
                UpdateFlags();
                MonitorInstance.Changed?.Invoke();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }

        private static void UpdateFlags()
        {
            Thread.Sleep(10);
            string statusJson = "";
            int retries = 30;
            while (retries > 0)
            {
                try
                {
                    statusJson = File.ReadAllText($"{watcher.Path}\\Status.json");
                    break;
                }
                catch (IOException)
                {
                    Thread.Sleep(10);
                    retries--;
                }
            }

            if (retries == 0)
            {
                throw new EDStatusMonitorException("Could not read flags.");
            }

            JObject status = JObject.Parse(statusJson);
            int flagInt = (int)status["Flags"];

            System.Diagnostics.Debug.WriteLine($"Flags: {flagInt}");

            for (int i = 0; i < flagNames.Length; i++)
            {
                string flagName = flagNames[i];
                bool flag = (flagInt & (1 << i)) > 0;
                if (flagName.Equals("fa_off")) flag = !flag;
                flags[flagName] = flag;
            }
        }

        public bool this[string index]
        {
            get
            {
                return flags[index];
            }
            private set
            {
                flags[index] = value;
            }
        }

        public Dictionary<string, bool> StatusCopy
        {
            get
            {
                return new Dictionary<string, bool>(flags);
            }
        }
    }
}
