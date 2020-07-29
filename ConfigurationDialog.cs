using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vJoyInterfaceWrap;

namespace EDStatus_Feeder
{
    public partial class ConfigurationDialog : Form
    {
        vJoy vjoy = new vJoy();
        Dictionary<string, Label> _flagLabels;
        Dictionary<string, ComboBox> _flagSelections;
        List<TargetDeviceItem> _targetItems = new List<TargetDeviceItem>();
        List<ButtonItem> _buttonItems = new List<ButtonItem>();
        Dictionary<string, int> _selectedButtons = new Dictionary<string, int>()
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

        public ConfigurationDialog()
        {
            InitializeComponent();

            this._flagLabels = new Dictionary<string, Label>()
            {
                { "docked", this.lblDocked },
                { "landed", this.lblLanded },
                { "landing_gear", this.lblLandingGear },
                { "shields", this.lblShields },
                { "supercruise", this.lblSupercruise },
                { "fa_off", this.lblFlightAssist },
                { "hardpoints", this.lblHardpoints },
                { "wing", this.lblWing },
                { "lights", this.lblLights },
                { "cargo_scoop", this.lblCargoScoop },
                { "silent_run", this.lblSilentRunning },
                { "fuel_scoop", this.lblFuelScoop },
                { "srv_brake", this.lblSRVHandbrake },
                { "srv_turret", this.lblSRVTurret },
                { "srv_board", this.lblSRVTurretAllowed },
                { "srv_da", this.lblSRVDriveAssist },
                { "fsd_masslock", this.lblMassLocked },
                { "fsd_charge", this.lblFSDCharging },
                { "fsd_cool", this.lblFSDCooldown },
                { "low_fuel", this.lblLowFuel },
                { "overheat", this.lblOverheating },
                { "has_lat_long", this.lblLatLong },
                { "in_danger", this.lblDanger },
                { "interdiction", this.lblInterdiction },
                { "in_ship", this.lblInMainShip },
                { "in_fighter", this.lblInFighter },
                { "in_srv", this.lblInSRV },
                { "analysis_mode", this.lblAnalysisMode },
                { "nightvision", this.lblNightvision },
                { "alt_from_avg_radius", this.lblOrbitalCruise },
                { "fsd_jump", this.lblFSDActivating },
                { "srv_high_beam", this.lblSRVHighBeam }
            };

            this._flagSelections = new Dictionary<string, ComboBox>()
            {
                { "docked", this.cmbDocked },
                { "landed", this.cmbLanded },
                { "landing_gear", this.cmbLandingGear },
                { "shields", this.cmbShields },
                { "supercruise", this.cmbSupercruise },
                { "fa_off", this.cmbFlightAssist },
                { "hardpoints", this.cmbHardpoints },
                { "wing", this.cmbWing },
                { "lights", this.cmbLights },
                { "cargo_scoop", this.cmbCargoScoop },
                { "silent_run", this.cmbSilentRunning },
                { "fuel_scoop", this.cmbFuelScoop },
                { "srv_brake", this.cmbSRVHandbrake },
                { "srv_turret", this.cmbSRVTurret },
                { "srv_board", this.cmbSRVTurretAllowed },
                { "srv_da", this.cmbSRVDriveAssist },
                { "fsd_masslock", this.cmbMassLocked },
                { "fsd_charge", this.cmbFSDCharging },
                { "fsd_cool", this.cmbFSDCooldown },
                { "low_fuel", this.cmbLowFuel },
                { "overheat", this.cmbOverheating },
                { "has_lat_long", this.cmbLatLong },
                { "in_danger", this.cmbDanger },
                { "interdiction", this.cmbInterdiction },
                { "in_ship", this.cmbInMainShip },
                { "in_fighter", this.cmbInFighter },
                { "in_srv", this.cmbInSRV },
                { "analysis_mode", this.cmbAnalysisMode },
                { "nightvision", this.cmbNightvision },
                { "alt_from_avg_radius", this.cmbOrbitalCruise },
                { "fsd_jump", this.cmbFSDActivating },
                { "srv_high_beam", this.cmbSRVHighBeam }
            };

            List<int> available = AvailableDevices();
            if (Configuration.Data.DeviceId > 0 && !available.Contains(Configuration.Data.DeviceId))
            {
                available.Add(Configuration.Data.DeviceId);
                available.Sort();
            }
            _targetItems.Clear();
            TargetDeviceItem selectedItem = null;
            foreach (int i in available)
            {
                TargetDeviceItem item = new TargetDeviceItem(i);
                _targetItems.Add(item);
                if (i == Configuration.Data.DeviceId)
                    selectedItem = item;
            }
            cmbTarget.DataSource = new BindingSource(_targetItems, null);
            cmbTarget.DisplayMember = "Text";
            cmbTarget.ValueMember = "Value";
            if (selectedItem != null)
                cmbTarget.SelectedItem = selectedItem;

            UpdateButtons(Configuration.Data);
        }

        private List<int> AvailableDevices()
        {
            List<int> available = new List<int>();

            for (uint i = 1; i <= 16; i++)
            {
                var stat = vjoy.GetVJDStatus(i);
                if ((int)stat < 2)
                    available.Add((int)i);
            }

            return available;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (cmbTarget.SelectedIndex < 0)
                MessageBox.Show("Please select a target device", "ED Status Feeder");
            else
                this.Close();

            Configuration.Data.DeviceId = ((TargetDeviceItem)cmbTarget.SelectedItem).Value;
            foreach (string flag in _flagSelections.Keys)
            {
                Configuration.Data[flag] = _flagSelections[flag].SelectedIndex;
            }
        }

        private void ConfigurationDialog_Show(object sender, EventArgs e)
        {
            btnApply.Focus();
            StatusChanged();
            EDStatusMonitor.MonitorInstance.Changed += StatusChanged;
        }

        private void ConfigurationDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            EDStatusMonitor.MonitorInstance.Changed -= StatusChanged;
        }

        delegate void SetBoldCallback(Label label, FontStyle style);
        private void SetBold(Label label, FontStyle style)
        {
            if (label.InvokeRequired)
            {
                SetBoldCallback d = new SetBoldCallback(SetBold);
                this.Invoke(d, new object[] { label, style });
            }
            else
            {
                label.Font = new Font(label.Font, style);
            }
        }
        private void StatusChanged()
        {
            foreach (string flag in _flagLabels.Keys)
            {
                SetBold(_flagLabels[flag], EDStatusMonitor.MonitorInstance[flag] ? FontStyle.Bold : FontStyle.Regular);
            }
        }

        private void cmbTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void UpdateButtons(Configuration config = null)
        {
            if (cmbTarget.SelectedIndex < 0)
                cmbTarget.SelectedIndex = 0;

            int deviceId = ((TargetDeviceItem)cmbTarget.SelectedItem).Value;
            int buttons = vjoy.GetVJDButtonNumber((uint)deviceId);

            if(config != null)
            {
                foreach (string flag in _flagSelections.Keys)
                {
                    _selectedButtons[flag] = config[flag];
                }
            }
            else
            {
                foreach (string flag in _flagSelections.Keys)
                {
                    _selectedButtons[flag] = _flagSelections[flag].SelectedIndex;
                }
            }

            _buttonItems.Clear();
            for (int i=0; i<=buttons; i++)
            {
                _buttonItems.Add(new ButtonItem(i));
            }

            foreach (string flag in _flagSelections.Keys)
            {
                _flagSelections[flag].DataSource = new BindingSource(_buttonItems, null);
                _flagSelections[flag].DisplayMember = "Text";
                _flagSelections[flag].ValueMember = "Value";
            }

            foreach (string flag in _flagSelections.Keys)
            {
                if (_selectedButtons[flag] < _flagSelections[flag].Items.Count)
                    _flagSelections[flag].SelectedIndex = _selectedButtons[flag];
                if (_flagSelections[flag].SelectedIndex < 0)
                    _flagSelections[flag].SelectedIndex = 0;
            }
        }

        private void btnAutoSelect_Click(object sender, EventArgs e)
        {
            int index = 1;
            foreach (string flag in _flagSelections.Keys)
            {
                if (index < _flagSelections[flag].Items.Count)
                    _flagSelections[flag].SelectedIndex = index;
                else
                    _flagSelections[flag].SelectedIndex = 0;

                index++;
            }
        }

        private void ConfigurationDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Configuration.Data.DeviceId == 0)
            {
                MessageBox.Show("No target device saved. The ED Status Feeder application will now close.", "ED Status Feeder");
                Application.Exit();
            }
        }
    }

    class TargetDeviceItem
    {
        public int Value { get; set; }

        public TargetDeviceItem(int i)
        {
            this.Value = i;
        }

        public string Text
        {
            get
            {
                return $"vJoy Device #{this.Value}";
            }
        }

        public override string ToString()
        {
            return Text;
        }
    }

    class ButtonItem
    {
        public int Value { get; set; }

        public ButtonItem(int i)
        {
            this.Value = i;
        }

        public string Text
        {
            get
            {
                if (Value > 0)
                    return $"Button {this.Value}";
                else
                    return "Ignore";
            }
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
