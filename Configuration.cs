﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;

namespace EDStatus_Feeder
{
    class Configuration
    {
        private static string key = "HKEY_CURRENT_USER\\Software\\ED Status Feeder";
        private static Lazy<Configuration> _config = new Lazy<Configuration>(() => new Configuration());
        private int _deviceId = 0;
        private static Dictionary<string, int> _buttonConfig = new Dictionary<string, int>()
            {
                { "docked", 0 },
                { "landed", 0 },
                { "landing_gear", 0 },
                { "shields", 0 },
                { "supercruise", 0 },
                { "fa_off", 0 },
                { "hardpoints", 0 },
                { "wing", 0 },
                { "lights", 0 },
                { "cargo_scoop", 0 },
                { "silent_run", 0 },
                { "fuel_scoop", 0 },
                { "srv_brake", 0 },
                { "srv_turret", 0 },
                { "srv_board", 0 },
                { "srv_da", 0 },
                { "fsd_masslock", 0 },
                { "fsd_charge", 0 },
                { "fsd_cool", 0 },
                { "low_fuel", 0 },
                { "overheat", 0 },
                { "has_lat_long", 0 },
                { "in_danger", 0 },
                { "interdiction", 0 },
                { "in_ship", 0 },
                { "in_fighter", 0 },
                { "in_srv", 0 },
                { "analysis_mode", 0 },
                { "nightvision", 0 },
                { "alt_from_avg_radius", 0 },
                { "fsd_jump", 0 },
                { "srv_high_beam", 0 }
            };

        private Configuration()
        {
            _deviceId = (int)(Registry.GetValue(key, "DeviceID", 0) ?? 0);

            foreach (string name in _buttonConfig.Keys.ToList())
            {
                _buttonConfig[name] = (int)(Registry.GetValue($"{key}\\Buttons", name, 0) ?? 0);
            }
        }

        public static Configuration Data
        {
            get
            {
                return Configuration._config.Value;
            }
        }

        public int DeviceId {
            get
            {
                return _deviceId;
            }
            set
            {
                _deviceId = value;
                Registry.SetValue(key, "DeviceID", value);
            }
        }

        public int this[string index]
        {
            get
            {
                return _buttonConfig[index];
            }
            set
            {
                _buttonConfig[index] = value;
                Registry.SetValue($"{key}\\Buttons", index, value);
            }
        }

        public Dictionary<string, int> ButtonConfigurationCopy
        {
            get
            {
                return new Dictionary<string, int>(_buttonConfig);
            }
        }
    }
}
