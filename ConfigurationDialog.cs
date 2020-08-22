using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vJoyInterfaceWrap;

namespace EDStatusFeeder
{
    public partial class ConfigurationDialog : Form
    {
        readonly vJoy vjoy = new vJoy();
        readonly List<TargetDeviceItem> targetItems = new List<TargetDeviceItem>();
        readonly List<ButtonItem> buttonItems = new List<ButtonItem>();
        readonly List<ButtonSelection> gridItems = new List<ButtonSelection>()
        {
            new ButtonSelection("docked", "Docked"),
            new ButtonSelection("landed", "Landed"),
            new ButtonSelection("landing_gear", "Landing Gear"),
            new ButtonSelection("shields", "Shields"),
            new ButtonSelection("supercruise", "Supercruise"),
            new ButtonSelection("fa_off", "Flight Assist"),
            new ButtonSelection("hardpoints", "Hardpoints"),
            new ButtonSelection("wing", "Wing"),
            new ButtonSelection("lights", "Lights"),
            new ButtonSelection("cargo_scoop", "Cargo Scoop"),
            new ButtonSelection("silent_run", "Silent Running"),
            new ButtonSelection("fuel_scoop", "Fuel Scoop"),
            new ButtonSelection("srv_brake", "SRV Handbrake"),
            new ButtonSelection("srv_turret", "SRV Turret"),
            new ButtonSelection("srv_board", "SRV Turret Allowed"),
            new ButtonSelection("srv_da", "SRV Drive Assist"),
            new ButtonSelection("fsd_masslock", "Mass Locked"),
            new ButtonSelection("fsd_charge", "FSD Charging"),
            new ButtonSelection("fsd_cool", "FSD Cooldown"),
            new ButtonSelection("low_fuel", "Low Fuel"),
            new ButtonSelection("overheat", "Overheating"),
            new ButtonSelection("has_lat_long", "Planetary Flight"),
            new ButtonSelection("in_danger", "In Danger"),
            new ButtonSelection("interdiction", "Interdiction"),
            new ButtonSelection("in_ship", "In Main Ship"),
            new ButtonSelection("in_fighter", "In Fighter"),
            new ButtonSelection("in_srv", "In SRV"),
            new ButtonSelection("analysis_mode", "Analysis Mode"),
            new ButtonSelection("nightvision", "Night Vision"),
            new ButtonSelection("alt_from_avg_radius", "Orbital Cruise"),
            new ButtonSelection("fsd_jump", "FSD Activating"),
            new ButtonSelection("srv_high_beam", "SRV High Beam"),
        };
        readonly Dictionary<string, int> selectedButtons = new Dictionary<string, int>()
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

            List<int> available = AvailableDevices();
            if (Configuration.Data.DeviceId > 0 && !available.Contains(Configuration.Data.DeviceId))
            {
                available.Add(Configuration.Data.DeviceId);
                available.Sort();
            }
            targetItems.Clear();
            TargetDeviceItem selectedItem = null;
            foreach (int i in available)
            {
                TargetDeviceItem item = new TargetDeviceItem(i);
                targetItems.Add(item);
                if (item.Value == Configuration.Data.DeviceId)
                {
                    selectedItem = item;
                }
            }
            cmbTarget.DisplayMember = "Text";
            cmbTarget.ValueMember = "Value";
            cmbTarget.DataSource = new BindingSource(targetItems, null);
            cmbTarget.SelectedItem = selectedItem;
            ((BindingSource)cmbTarget.DataSource).RaiseListChangedEvents = false;

            this.gridButtons1.DataSource = gridItems.GetRange(0, gridItems.Count / 2);
            this.gridButtons2.DataSource = gridItems.GetRange(gridItems.Count / 2, gridItems.Count - (gridItems.Count / 2));
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

        private void BtnApply_Click(object sender, EventArgs e)
        {
            if (cmbTarget.SelectedIndex < 0)
                MessageBox.Show("Please select a target device", "ED Status Feeder");
            else
                this.Close();

            Configuration.Data.DeviceId = ((TargetDeviceItem)cmbTarget.SelectedItem).Value;
            foreach (string flag in selectedButtons.Keys)
            {
                Configuration.Data[flag] = gridItems.Where(i => i.Key.Equals(flag)).First().Selection;
            }
        }

        private void ConfigurationDialog_Show(object sender, EventArgs e)
        {
            foreach (var item in targetItems)
            {
                if (item.Value == Configuration.Data.DeviceId)
                {
                    cmbTarget.SelectedItem = item;
                }
            }
            UpdateButtons(Configuration.Data);
            StatusChanged();
            btnApply.Focus();
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
            foreach(DataGridViewRow row in gridButtons1.Rows)
            {
                string flag = (string)row.Cells["gridButtons1Key"].Value;
                if(!flag.Equals("ignore"))
                {
                    DataGridViewCell label = row.Cells["gridButtons1ButtonName"];
                    label.Style.Font = new Font(label.Style.Font ?? gridButtons1.Font, EDStatusMonitor.MonitorInstance[flag] ? FontStyle.Bold : FontStyle.Regular);
                }
            }

            foreach (DataGridViewRow row in gridButtons2.Rows)
            {
                string flag = (string)row.Cells["gridButtons2Key"].Value;
                if (!flag.Equals("ignore"))
                {
                    DataGridViewCell label = row.Cells["gridButtons2ButtonName"];
                    label.Style.Font = new Font(label.Style.Font ?? gridButtons2.Font, EDStatusMonitor.MonitorInstance[flag] ? FontStyle.Bold : FontStyle.Regular);
                }
            }
        }

        private void CmbTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void UpdateButtons(Configuration config = null)
        {
            if (cmbTarget.SelectedIndex < 0)
                cmbTarget.SelectedIndex = 0;

            int deviceId = ((TargetDeviceItem)cmbTarget.SelectedItem).Value;
            int buttons = vjoy.GetVJDButtonNumber((uint)deviceId);

            if (config != null)
            {
                foreach (string flag in selectedButtons.Keys.ToArray())
                {
                    selectedButtons[flag] = config[flag];
                }
            }
            else
            {
                foreach (string flag in selectedButtons.Keys.ToArray())
                {
                    selectedButtons[flag] = gridItems.Where(i => i.Key.Equals(flag)).First().Selection;
                }
            }

            buttonItems.Clear();
            for (int i=0; i<=buttons; i++)
            {
                buttonItems.Add(new ButtonItem(i));
            }
            var buttonSelectionColumn1 = (DataGridViewComboBoxColumn)this.gridButtons1.Columns["gridButtons1Selection"];
            buttonSelectionColumn1.DisplayMember = "Text";
            buttonSelectionColumn1.ValueMember = "Value";
            buttonSelectionColumn1.DataSource = buttonItems;
            var buttonSelectionColumn2 = (DataGridViewComboBoxColumn)this.gridButtons2.Columns["gridButtons2Selection"];
            buttonSelectionColumn2.DisplayMember = "Text";
            buttonSelectionColumn2.ValueMember = "Value";
            buttonSelectionColumn2.DataSource = buttonItems;

            foreach (string flag in selectedButtons.Keys.ToArray())
            {
                if (selectedButtons[flag] > buttons)
                    selectedButtons[flag] = 0;
                gridItems.Where(i => i.Key.Equals(flag)).First().Selection = selectedButtons[flag];
            }
        }

        private void BtnAutoSelect_Click(object sender, EventArgs e)
        {
            int deviceId = ((TargetDeviceItem)cmbTarget.SelectedItem).Value;
            int buttons = vjoy.GetVJDButtonNumber((uint)deviceId);
            int index = 1;

            foreach (string flag in selectedButtons.Keys)
            {
                if (index <= buttons)
                    gridItems.Where(i => i.Key.Equals(flag)).First().Selection = index;
                else
                    gridItems.Where(i => i.Key.Equals(flag)).First().Selection = 0;

                index++;
            }

            this.gridButtons1.InvalidateColumn(gridButtons1.Columns["gridButtons1Selection"].Index);
            this.gridButtons2.InvalidateColumn(gridButtons2.Columns["gridButtons2Selection"].Index);
        }

        private void ConfigurationDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Configuration.Data.DeviceId == 0)
            {
                MessageBox.Show("No target device saved. The ED Status Feeder application will now close.", "ED Status Feeder");
                Application.Exit();
            }
        }

        private void GridButtons1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = gridButtons1.CurrentCell;
            if (cell != null && cell.OwningColumn.Name.Equals("gridButtons1Selection"))
            {
                gridButtons1.BeginEdit(true);
                ((ComboBox)gridButtons1.EditingControl).DroppedDown = true;
            }
        }

        private void GridButtons1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var cell = gridButtons1.CurrentCell;
            if (cell != null && cell.OwningColumn.Name.Equals("gridButtons1Selection"))
            {
                ((ComboBox)gridButtons1.EditingControl).DropDownClosed += GridButtons1_DropDownClosed;
            }
        }

        private void GridButtons1_DropDownClosed(object sender, EventArgs e)
        {
            gridButtons1.CurrentCell = null;
            ((ComboBox)sender).DropDownClosed -= GridButtons1_DropDownClosed;
            gridButtons1.InvalidateColumn(gridButtons1Selection.Index);
        }

        private void GridButtons2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = gridButtons2.CurrentCell;
            if (cell != null && cell.OwningColumn.Name.Equals("gridButtons2Selection"))
            {
                gridButtons2.BeginEdit(true);
                ((ComboBox)gridButtons2.EditingControl).DroppedDown = true;
            }
        }

        private void GridButtons2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var cell = gridButtons2.CurrentCell;
            if (cell != null && cell.OwningColumn.Name.Equals("gridButtons2Selection"))
            {
                ((ComboBox)gridButtons2.EditingControl).DropDownClosed += GridButtons2_DropDownClosed;
            }
        }

        private void GridButtons2_DropDownClosed(object sender, EventArgs e)
        {
            gridButtons2.CurrentCell = null;
            ((ComboBox)sender).DropDownClosed -= GridButtons2_DropDownClosed;
            gridButtons2.InvalidateColumn(gridButtons2Selection.Index);
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

    class ButtonSelection
    {
        public ButtonSelection(string key, string name, int selection = 0)
        {
            this.Key = key;
            this.ButtonName = name;
            this.Selection = selection;
        }

        public string Key { get; set; }
        public string ButtonName { get; set; }
        public int Selection { get; set; }
    }
}
