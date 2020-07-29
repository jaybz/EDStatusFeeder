namespace EDStatus_Feeder
{
    partial class ConfigurationDialog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTarget = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSRVHighBeam = new System.Windows.Forms.ComboBox();
            this.lblSRVHighBeam = new System.Windows.Forms.Label();
            this.cmbJumping = new System.Windows.Forms.ComboBox();
            this.lblJumping = new System.Windows.Forms.Label();
            this.cmbUnknown = new System.Windows.Forms.ComboBox();
            this.lblUnknown = new System.Windows.Forms.Label();
            this.lblDocked = new System.Windows.Forms.Label();
            this.cmbDocked = new System.Windows.Forms.ComboBox();
            this.lblLanded = new System.Windows.Forms.Label();
            this.cmbLanded = new System.Windows.Forms.ComboBox();
            this.lblLandingGear = new System.Windows.Forms.Label();
            this.cmbLandingGear = new System.Windows.Forms.ComboBox();
            this.lblShields = new System.Windows.Forms.Label();
            this.cmbShields = new System.Windows.Forms.ComboBox();
            this.lblSupercruise = new System.Windows.Forms.Label();
            this.cmbSupercruise = new System.Windows.Forms.ComboBox();
            this.lblFlightAssist = new System.Windows.Forms.Label();
            this.cmbFlightAssist = new System.Windows.Forms.ComboBox();
            this.lblHardpoints = new System.Windows.Forms.Label();
            this.cmbHardpoints = new System.Windows.Forms.ComboBox();
            this.lblWing = new System.Windows.Forms.Label();
            this.cmbWing = new System.Windows.Forms.ComboBox();
            this.cmbSRVDriveAssist = new System.Windows.Forms.ComboBox();
            this.lblSRVDriveAssist = new System.Windows.Forms.Label();
            this.cmbSRVTurretAllowed = new System.Windows.Forms.ComboBox();
            this.lblSRVTurretAllowed = new System.Windows.Forms.Label();
            this.cmbSRVTurret = new System.Windows.Forms.ComboBox();
            this.lblSRVTurret = new System.Windows.Forms.Label();
            this.cmbSRVHandbrake = new System.Windows.Forms.ComboBox();
            this.lblSRVHandbrake = new System.Windows.Forms.Label();
            this.cmbFuelScoop = new System.Windows.Forms.ComboBox();
            this.lblFuelScoop = new System.Windows.Forms.Label();
            this.cmbSilentRunning = new System.Windows.Forms.ComboBox();
            this.lblSilentRunning = new System.Windows.Forms.Label();
            this.cmbCargoScoop = new System.Windows.Forms.ComboBox();
            this.lblCargoScoop = new System.Windows.Forms.Label();
            this.cmbLights = new System.Windows.Forms.ComboBox();
            this.lblLights = new System.Windows.Forms.Label();
            this.lblMassLocked = new System.Windows.Forms.Label();
            this.cmbMassLocked = new System.Windows.Forms.ComboBox();
            this.lblFSDCharging = new System.Windows.Forms.Label();
            this.cmbFSDCharging = new System.Windows.Forms.ComboBox();
            this.lblFSDCooldown = new System.Windows.Forms.Label();
            this.cmbFSDCooldown = new System.Windows.Forms.ComboBox();
            this.lblLowFuel = new System.Windows.Forms.Label();
            this.cmbLowFuel = new System.Windows.Forms.ComboBox();
            this.lblOverheating = new System.Windows.Forms.Label();
            this.cmbOverheating = new System.Windows.Forms.ComboBox();
            this.lblLatLong = new System.Windows.Forms.Label();
            this.cmbLatLong = new System.Windows.Forms.ComboBox();
            this.lblDanger = new System.Windows.Forms.Label();
            this.cmbDanger = new System.Windows.Forms.ComboBox();
            this.lblInterdiction = new System.Windows.Forms.Label();
            this.cmbInterdiction = new System.Windows.Forms.ComboBox();
            this.cmbNightvision = new System.Windows.Forms.ComboBox();
            this.lblNightvision = new System.Windows.Forms.Label();
            this.cmbAnalysisMode = new System.Windows.Forms.ComboBox();
            this.lblAnalysisMode = new System.Windows.Forms.Label();
            this.cmbInSRV = new System.Windows.Forms.ComboBox();
            this.lblInSRV = new System.Windows.Forms.Label();
            this.cmbInFighter = new System.Windows.Forms.ComboBox();
            this.lblInFighter = new System.Windows.Forms.Label();
            this.cmbInMainShip = new System.Windows.Forms.ComboBox();
            this.lblInMainShip = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAutoSelect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Target Device";
            // 
            // cmbTarget
            // 
            this.cmbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarget.FormattingEnabled = true;
            this.cmbTarget.Location = new System.Drawing.Point(112, 10);
            this.cmbTarget.Name = "cmbTarget";
            this.cmbTarget.Size = new System.Drawing.Size(132, 21);
            this.cmbTarget.TabIndex = 3;
            this.cmbTarget.SelectedIndexChanged += new System.EventHandler(this.cmbTarget_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSRVHighBeam);
            this.groupBox1.Controls.Add(this.lblSRVHighBeam);
            this.groupBox1.Controls.Add(this.cmbJumping);
            this.groupBox1.Controls.Add(this.lblJumping);
            this.groupBox1.Controls.Add(this.cmbUnknown);
            this.groupBox1.Controls.Add(this.lblUnknown);
            this.groupBox1.Controls.Add(this.lblDocked);
            this.groupBox1.Controls.Add(this.cmbDocked);
            this.groupBox1.Controls.Add(this.lblLanded);
            this.groupBox1.Controls.Add(this.cmbLanded);
            this.groupBox1.Controls.Add(this.lblLandingGear);
            this.groupBox1.Controls.Add(this.cmbLandingGear);
            this.groupBox1.Controls.Add(this.lblShields);
            this.groupBox1.Controls.Add(this.cmbShields);
            this.groupBox1.Controls.Add(this.lblSupercruise);
            this.groupBox1.Controls.Add(this.cmbSupercruise);
            this.groupBox1.Controls.Add(this.lblFlightAssist);
            this.groupBox1.Controls.Add(this.cmbFlightAssist);
            this.groupBox1.Controls.Add(this.lblHardpoints);
            this.groupBox1.Controls.Add(this.cmbHardpoints);
            this.groupBox1.Controls.Add(this.lblWing);
            this.groupBox1.Controls.Add(this.cmbWing);
            this.groupBox1.Controls.Add(this.cmbSRVDriveAssist);
            this.groupBox1.Controls.Add(this.lblSRVDriveAssist);
            this.groupBox1.Controls.Add(this.cmbSRVTurretAllowed);
            this.groupBox1.Controls.Add(this.lblSRVTurretAllowed);
            this.groupBox1.Controls.Add(this.cmbSRVTurret);
            this.groupBox1.Controls.Add(this.lblSRVTurret);
            this.groupBox1.Controls.Add(this.cmbSRVHandbrake);
            this.groupBox1.Controls.Add(this.lblSRVHandbrake);
            this.groupBox1.Controls.Add(this.cmbFuelScoop);
            this.groupBox1.Controls.Add(this.lblFuelScoop);
            this.groupBox1.Controls.Add(this.cmbSilentRunning);
            this.groupBox1.Controls.Add(this.lblSilentRunning);
            this.groupBox1.Controls.Add(this.cmbCargoScoop);
            this.groupBox1.Controls.Add(this.lblCargoScoop);
            this.groupBox1.Controls.Add(this.cmbLights);
            this.groupBox1.Controls.Add(this.lblLights);
            this.groupBox1.Controls.Add(this.lblMassLocked);
            this.groupBox1.Controls.Add(this.cmbMassLocked);
            this.groupBox1.Controls.Add(this.lblFSDCharging);
            this.groupBox1.Controls.Add(this.cmbFSDCharging);
            this.groupBox1.Controls.Add(this.lblFSDCooldown);
            this.groupBox1.Controls.Add(this.cmbFSDCooldown);
            this.groupBox1.Controls.Add(this.lblLowFuel);
            this.groupBox1.Controls.Add(this.cmbLowFuel);
            this.groupBox1.Controls.Add(this.lblOverheating);
            this.groupBox1.Controls.Add(this.cmbOverheating);
            this.groupBox1.Controls.Add(this.lblLatLong);
            this.groupBox1.Controls.Add(this.cmbLatLong);
            this.groupBox1.Controls.Add(this.lblDanger);
            this.groupBox1.Controls.Add(this.cmbDanger);
            this.groupBox1.Controls.Add(this.lblInterdiction);
            this.groupBox1.Controls.Add(this.cmbInterdiction);
            this.groupBox1.Controls.Add(this.cmbNightvision);
            this.groupBox1.Controls.Add(this.lblNightvision);
            this.groupBox1.Controls.Add(this.cmbAnalysisMode);
            this.groupBox1.Controls.Add(this.lblAnalysisMode);
            this.groupBox1.Controls.Add(this.cmbInSRV);
            this.groupBox1.Controls.Add(this.lblInSRV);
            this.groupBox1.Controls.Add(this.cmbInFighter);
            this.groupBox1.Controls.Add(this.lblInFighter);
            this.groupBox1.Controls.Add(this.cmbInMainShip);
            this.groupBox1.Controls.Add(this.lblInMainShip);
            this.groupBox1.Location = new System.Drawing.Point(10, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 425);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Buttons";
            // 
            // cmbSRVHighBeam
            // 
            this.cmbSRVHighBeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSRVHighBeam.FormattingEnabled = true;
            this.cmbSRVHighBeam.Location = new System.Drawing.Point(329, 397);
            this.cmbSRVHighBeam.Name = "cmbSRVHighBeam";
            this.cmbSRVHighBeam.Size = new System.Drawing.Size(103, 21);
            this.cmbSRVHighBeam.TabIndex = 7;
            // 
            // lblSRVHighBeam
            // 
            this.lblSRVHighBeam.AutoSize = true;
            this.lblSRVHighBeam.Location = new System.Drawing.Point(232, 399);
            this.lblSRVHighBeam.Name = "lblSRVHighBeam";
            this.lblSRVHighBeam.Size = new System.Drawing.Size(84, 13);
            this.lblSRVHighBeam.TabIndex = 4;
            this.lblSRVHighBeam.Text = "SRV High Beam";
            // 
            // cmbJumping
            // 
            this.cmbJumping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJumping.FormattingEnabled = true;
            this.cmbJumping.Location = new System.Drawing.Point(329, 372);
            this.cmbJumping.Name = "cmbJumping";
            this.cmbJumping.Size = new System.Drawing.Size(103, 21);
            this.cmbJumping.TabIndex = 8;
            // 
            // lblJumping
            // 
            this.lblJumping.AutoSize = true;
            this.lblJumping.Location = new System.Drawing.Point(232, 374);
            this.lblJumping.Name = "lblJumping";
            this.lblJumping.Size = new System.Drawing.Size(46, 13);
            this.lblJumping.TabIndex = 5;
            this.lblJumping.Text = "Jumping";
            // 
            // cmbUnknown
            // 
            this.cmbUnknown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnknown.FormattingEnabled = true;
            this.cmbUnknown.Location = new System.Drawing.Point(329, 346);
            this.cmbUnknown.Name = "cmbUnknown";
            this.cmbUnknown.Size = new System.Drawing.Size(103, 21);
            this.cmbUnknown.TabIndex = 9;
            // 
            // lblUnknown
            // 
            this.lblUnknown.AutoSize = true;
            this.lblUnknown.Location = new System.Drawing.Point(232, 349);
            this.lblUnknown.Name = "lblUnknown";
            this.lblUnknown.Size = new System.Drawing.Size(76, 13);
            this.lblUnknown.TabIndex = 6;
            this.lblUnknown.Text = "Unknown Flag";
            // 
            // lblDocked
            // 
            this.lblDocked.AutoSize = true;
            this.lblDocked.Location = new System.Drawing.Point(5, 23);
            this.lblDocked.Name = "lblDocked";
            this.lblDocked.Size = new System.Drawing.Size(45, 13);
            this.lblDocked.TabIndex = 2;
            this.lblDocked.Text = "Docked";
            // 
            // cmbDocked
            // 
            this.cmbDocked.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocked.FormattingEnabled = true;
            this.cmbDocked.Location = new System.Drawing.Point(102, 19);
            this.cmbDocked.Name = "cmbDocked";
            this.cmbDocked.Size = new System.Drawing.Size(103, 21);
            this.cmbDocked.TabIndex = 3;
            // 
            // lblLanded
            // 
            this.lblLanded.AutoSize = true;
            this.lblLanded.Location = new System.Drawing.Point(5, 47);
            this.lblLanded.Name = "lblLanded";
            this.lblLanded.Size = new System.Drawing.Size(43, 13);
            this.lblLanded.TabIndex = 2;
            this.lblLanded.Text = "Landed";
            // 
            // cmbLanded
            // 
            this.cmbLanded.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanded.FormattingEnabled = true;
            this.cmbLanded.Location = new System.Drawing.Point(102, 44);
            this.cmbLanded.Name = "cmbLanded";
            this.cmbLanded.Size = new System.Drawing.Size(103, 21);
            this.cmbLanded.TabIndex = 3;
            // 
            // lblLandingGear
            // 
            this.lblLandingGear.AutoSize = true;
            this.lblLandingGear.Location = new System.Drawing.Point(5, 72);
            this.lblLandingGear.Name = "lblLandingGear";
            this.lblLandingGear.Size = new System.Drawing.Size(71, 13);
            this.lblLandingGear.TabIndex = 2;
            this.lblLandingGear.Text = "Landing Gear";
            // 
            // cmbLandingGear
            // 
            this.cmbLandingGear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLandingGear.FormattingEnabled = true;
            this.cmbLandingGear.Location = new System.Drawing.Point(102, 69);
            this.cmbLandingGear.Name = "cmbLandingGear";
            this.cmbLandingGear.Size = new System.Drawing.Size(103, 21);
            this.cmbLandingGear.TabIndex = 3;
            // 
            // lblShields
            // 
            this.lblShields.AutoSize = true;
            this.lblShields.Location = new System.Drawing.Point(5, 97);
            this.lblShields.Name = "lblShields";
            this.lblShields.Size = new System.Drawing.Size(41, 13);
            this.lblShields.TabIndex = 2;
            this.lblShields.Text = "Shields";
            // 
            // cmbShields
            // 
            this.cmbShields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShields.FormattingEnabled = true;
            this.cmbShields.Location = new System.Drawing.Point(102, 94);
            this.cmbShields.Name = "cmbShields";
            this.cmbShields.Size = new System.Drawing.Size(103, 21);
            this.cmbShields.TabIndex = 3;
            // 
            // lblSupercruise
            // 
            this.lblSupercruise.AutoSize = true;
            this.lblSupercruise.Location = new System.Drawing.Point(5, 122);
            this.lblSupercruise.Name = "lblSupercruise";
            this.lblSupercruise.Size = new System.Drawing.Size(63, 13);
            this.lblSupercruise.TabIndex = 2;
            this.lblSupercruise.Text = "Supercruise";
            // 
            // cmbSupercruise
            // 
            this.cmbSupercruise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupercruise.FormattingEnabled = true;
            this.cmbSupercruise.Location = new System.Drawing.Point(102, 120);
            this.cmbSupercruise.Name = "cmbSupercruise";
            this.cmbSupercruise.Size = new System.Drawing.Size(103, 21);
            this.cmbSupercruise.TabIndex = 3;
            // 
            // lblFlightAssist
            // 
            this.lblFlightAssist.AutoSize = true;
            this.lblFlightAssist.Location = new System.Drawing.Point(5, 147);
            this.lblFlightAssist.Name = "lblFlightAssist";
            this.lblFlightAssist.Size = new System.Drawing.Size(62, 13);
            this.lblFlightAssist.TabIndex = 2;
            this.lblFlightAssist.Text = "Flight Assist";
            // 
            // cmbFlightAssist
            // 
            this.cmbFlightAssist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlightAssist.FormattingEnabled = true;
            this.cmbFlightAssist.Location = new System.Drawing.Point(102, 145);
            this.cmbFlightAssist.Name = "cmbFlightAssist";
            this.cmbFlightAssist.Size = new System.Drawing.Size(103, 21);
            this.cmbFlightAssist.TabIndex = 3;
            // 
            // lblHardpoints
            // 
            this.lblHardpoints.AutoSize = true;
            this.lblHardpoints.Location = new System.Drawing.Point(5, 172);
            this.lblHardpoints.Name = "lblHardpoints";
            this.lblHardpoints.Size = new System.Drawing.Size(58, 13);
            this.lblHardpoints.TabIndex = 2;
            this.lblHardpoints.Text = "Hardpoints";
            // 
            // cmbHardpoints
            // 
            this.cmbHardpoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHardpoints.FormattingEnabled = true;
            this.cmbHardpoints.Location = new System.Drawing.Point(102, 170);
            this.cmbHardpoints.Name = "cmbHardpoints";
            this.cmbHardpoints.Size = new System.Drawing.Size(103, 21);
            this.cmbHardpoints.TabIndex = 3;
            // 
            // lblWing
            // 
            this.lblWing.AutoSize = true;
            this.lblWing.Location = new System.Drawing.Point(5, 198);
            this.lblWing.Name = "lblWing";
            this.lblWing.Size = new System.Drawing.Size(32, 13);
            this.lblWing.TabIndex = 2;
            this.lblWing.Text = "Wing";
            // 
            // cmbWing
            // 
            this.cmbWing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWing.FormattingEnabled = true;
            this.cmbWing.Location = new System.Drawing.Point(102, 195);
            this.cmbWing.Name = "cmbWing";
            this.cmbWing.Size = new System.Drawing.Size(103, 21);
            this.cmbWing.TabIndex = 3;
            // 
            // cmbSRVDriveAssist
            // 
            this.cmbSRVDriveAssist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSRVDriveAssist.FormattingEnabled = true;
            this.cmbSRVDriveAssist.Location = new System.Drawing.Point(102, 396);
            this.cmbSRVDriveAssist.Name = "cmbSRVDriveAssist";
            this.cmbSRVDriveAssist.Size = new System.Drawing.Size(103, 21);
            this.cmbSRVDriveAssist.TabIndex = 3;
            // 
            // lblSRVDriveAssist
            // 
            this.lblSRVDriveAssist.AutoSize = true;
            this.lblSRVDriveAssist.Location = new System.Drawing.Point(5, 399);
            this.lblSRVDriveAssist.Name = "lblSRVDriveAssist";
            this.lblSRVDriveAssist.Size = new System.Drawing.Size(87, 13);
            this.lblSRVDriveAssist.TabIndex = 2;
            this.lblSRVDriveAssist.Text = "SRV Drive Assist";
            // 
            // cmbSRVTurretAllowed
            // 
            this.cmbSRVTurretAllowed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSRVTurretAllowed.FormattingEnabled = true;
            this.cmbSRVTurretAllowed.Location = new System.Drawing.Point(102, 371);
            this.cmbSRVTurretAllowed.Name = "cmbSRVTurretAllowed";
            this.cmbSRVTurretAllowed.Size = new System.Drawing.Size(103, 21);
            this.cmbSRVTurretAllowed.TabIndex = 3;
            // 
            // lblSRVTurretAllowed
            // 
            this.lblSRVTurretAllowed.AutoSize = true;
            this.lblSRVTurretAllowed.Location = new System.Drawing.Point(5, 374);
            this.lblSRVTurretAllowed.Name = "lblSRVTurretAllowed";
            this.lblSRVTurretAllowed.Size = new System.Drawing.Size(100, 13);
            this.lblSRVTurretAllowed.TabIndex = 2;
            this.lblSRVTurretAllowed.Text = "SRV Turret Allowed";
            // 
            // cmbSRVTurret
            // 
            this.cmbSRVTurret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSRVTurret.FormattingEnabled = true;
            this.cmbSRVTurret.Location = new System.Drawing.Point(102, 346);
            this.cmbSRVTurret.Name = "cmbSRVTurret";
            this.cmbSRVTurret.Size = new System.Drawing.Size(103, 21);
            this.cmbSRVTurret.TabIndex = 3;
            // 
            // lblSRVTurret
            // 
            this.lblSRVTurret.AutoSize = true;
            this.lblSRVTurret.Location = new System.Drawing.Point(5, 348);
            this.lblSRVTurret.Name = "lblSRVTurret";
            this.lblSRVTurret.Size = new System.Drawing.Size(60, 13);
            this.lblSRVTurret.TabIndex = 2;
            this.lblSRVTurret.Text = "SRV Turret";
            // 
            // cmbSRVHandbrake
            // 
            this.cmbSRVHandbrake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSRVHandbrake.FormattingEnabled = true;
            this.cmbSRVHandbrake.Location = new System.Drawing.Point(102, 321);
            this.cmbSRVHandbrake.Name = "cmbSRVHandbrake";
            this.cmbSRVHandbrake.Size = new System.Drawing.Size(103, 21);
            this.cmbSRVHandbrake.TabIndex = 3;
            // 
            // lblSRVHandbrake
            // 
            this.lblSRVHandbrake.AutoSize = true;
            this.lblSRVHandbrake.Location = new System.Drawing.Point(5, 323);
            this.lblSRVHandbrake.Name = "lblSRVHandbrake";
            this.lblSRVHandbrake.Size = new System.Drawing.Size(85, 13);
            this.lblSRVHandbrake.TabIndex = 2;
            this.lblSRVHandbrake.Text = "SRV Handbrake";
            // 
            // cmbFuelScoop
            // 
            this.cmbFuelScoop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuelScoop.FormattingEnabled = true;
            this.cmbFuelScoop.Location = new System.Drawing.Point(102, 296);
            this.cmbFuelScoop.Name = "cmbFuelScoop";
            this.cmbFuelScoop.Size = new System.Drawing.Size(103, 21);
            this.cmbFuelScoop.TabIndex = 3;
            // 
            // lblFuelScoop
            // 
            this.lblFuelScoop.AutoSize = true;
            this.lblFuelScoop.Location = new System.Drawing.Point(5, 298);
            this.lblFuelScoop.Name = "lblFuelScoop";
            this.lblFuelScoop.Size = new System.Drawing.Size(61, 13);
            this.lblFuelScoop.TabIndex = 2;
            this.lblFuelScoop.Text = "Fuel Scoop";
            // 
            // cmbSilentRunning
            // 
            this.cmbSilentRunning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSilentRunning.FormattingEnabled = true;
            this.cmbSilentRunning.Location = new System.Drawing.Point(102, 270);
            this.cmbSilentRunning.Name = "cmbSilentRunning";
            this.cmbSilentRunning.Size = new System.Drawing.Size(103, 21);
            this.cmbSilentRunning.TabIndex = 3;
            // 
            // lblSilentRunning
            // 
            this.lblSilentRunning.AutoSize = true;
            this.lblSilentRunning.Location = new System.Drawing.Point(5, 273);
            this.lblSilentRunning.Name = "lblSilentRunning";
            this.lblSilentRunning.Size = new System.Drawing.Size(76, 13);
            this.lblSilentRunning.TabIndex = 2;
            this.lblSilentRunning.Text = "Silent Running";
            // 
            // cmbCargoScoop
            // 
            this.cmbCargoScoop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargoScoop.FormattingEnabled = true;
            this.cmbCargoScoop.Location = new System.Drawing.Point(102, 245);
            this.cmbCargoScoop.Name = "cmbCargoScoop";
            this.cmbCargoScoop.Size = new System.Drawing.Size(103, 21);
            this.cmbCargoScoop.TabIndex = 3;
            // 
            // lblCargoScoop
            // 
            this.lblCargoScoop.AutoSize = true;
            this.lblCargoScoop.Location = new System.Drawing.Point(5, 248);
            this.lblCargoScoop.Name = "lblCargoScoop";
            this.lblCargoScoop.Size = new System.Drawing.Size(69, 13);
            this.lblCargoScoop.TabIndex = 2;
            this.lblCargoScoop.Text = "Cargo Scoop";
            // 
            // cmbLights
            // 
            this.cmbLights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLights.FormattingEnabled = true;
            this.cmbLights.Location = new System.Drawing.Point(102, 220);
            this.cmbLights.Name = "cmbLights";
            this.cmbLights.Size = new System.Drawing.Size(103, 21);
            this.cmbLights.TabIndex = 3;
            // 
            // lblLights
            // 
            this.lblLights.AutoSize = true;
            this.lblLights.Location = new System.Drawing.Point(5, 224);
            this.lblLights.Name = "lblLights";
            this.lblLights.Size = new System.Drawing.Size(35, 13);
            this.lblLights.TabIndex = 2;
            this.lblLights.Text = "Lights";
            // 
            // lblMassLocked
            // 
            this.lblMassLocked.AutoSize = true;
            this.lblMassLocked.Location = new System.Drawing.Point(232, 23);
            this.lblMassLocked.Name = "lblMassLocked";
            this.lblMassLocked.Size = new System.Drawing.Size(71, 13);
            this.lblMassLocked.TabIndex = 2;
            this.lblMassLocked.Text = "Mass Locked";
            // 
            // cmbMassLocked
            // 
            this.cmbMassLocked.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMassLocked.FormattingEnabled = true;
            this.cmbMassLocked.Location = new System.Drawing.Point(329, 19);
            this.cmbMassLocked.Name = "cmbMassLocked";
            this.cmbMassLocked.Size = new System.Drawing.Size(103, 21);
            this.cmbMassLocked.TabIndex = 3;
            // 
            // lblFSDCharging
            // 
            this.lblFSDCharging.AutoSize = true;
            this.lblFSDCharging.Location = new System.Drawing.Point(232, 47);
            this.lblFSDCharging.Name = "lblFSDCharging";
            this.lblFSDCharging.Size = new System.Drawing.Size(73, 13);
            this.lblFSDCharging.TabIndex = 2;
            this.lblFSDCharging.Text = "FSD Charging";
            // 
            // cmbFSDCharging
            // 
            this.cmbFSDCharging.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFSDCharging.FormattingEnabled = true;
            this.cmbFSDCharging.Location = new System.Drawing.Point(329, 44);
            this.cmbFSDCharging.Name = "cmbFSDCharging";
            this.cmbFSDCharging.Size = new System.Drawing.Size(103, 21);
            this.cmbFSDCharging.TabIndex = 3;
            // 
            // lblFSDCooldown
            // 
            this.lblFSDCooldown.AutoSize = true;
            this.lblFSDCooldown.Location = new System.Drawing.Point(232, 72);
            this.lblFSDCooldown.Name = "lblFSDCooldown";
            this.lblFSDCooldown.Size = new System.Drawing.Size(78, 13);
            this.lblFSDCooldown.TabIndex = 2;
            this.lblFSDCooldown.Text = "FSD Cooldown";
            // 
            // cmbFSDCooldown
            // 
            this.cmbFSDCooldown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFSDCooldown.FormattingEnabled = true;
            this.cmbFSDCooldown.Location = new System.Drawing.Point(329, 69);
            this.cmbFSDCooldown.Name = "cmbFSDCooldown";
            this.cmbFSDCooldown.Size = new System.Drawing.Size(103, 21);
            this.cmbFSDCooldown.TabIndex = 3;
            // 
            // lblLowFuel
            // 
            this.lblLowFuel.AutoSize = true;
            this.lblLowFuel.Location = new System.Drawing.Point(232, 97);
            this.lblLowFuel.Name = "lblLowFuel";
            this.lblLowFuel.Size = new System.Drawing.Size(50, 13);
            this.lblLowFuel.TabIndex = 2;
            this.lblLowFuel.Text = "Low Fuel";
            // 
            // cmbLowFuel
            // 
            this.cmbLowFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLowFuel.FormattingEnabled = true;
            this.cmbLowFuel.Location = new System.Drawing.Point(329, 94);
            this.cmbLowFuel.Name = "cmbLowFuel";
            this.cmbLowFuel.Size = new System.Drawing.Size(103, 21);
            this.cmbLowFuel.TabIndex = 3;
            // 
            // lblOverheating
            // 
            this.lblOverheating.AutoSize = true;
            this.lblOverheating.Location = new System.Drawing.Point(232, 122);
            this.lblOverheating.Name = "lblOverheating";
            this.lblOverheating.Size = new System.Drawing.Size(65, 13);
            this.lblOverheating.TabIndex = 2;
            this.lblOverheating.Text = "Overheating";
            // 
            // cmbOverheating
            // 
            this.cmbOverheating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOverheating.FormattingEnabled = true;
            this.cmbOverheating.Location = new System.Drawing.Point(329, 120);
            this.cmbOverheating.Name = "cmbOverheating";
            this.cmbOverheating.Size = new System.Drawing.Size(103, 21);
            this.cmbOverheating.TabIndex = 3;
            // 
            // lblLatLong
            // 
            this.lblLatLong.AutoSize = true;
            this.lblLatLong.Location = new System.Drawing.Point(232, 147);
            this.lblLatLong.Name = "lblLatLong";
            this.lblLatLong.Size = new System.Drawing.Size(95, 13);
            this.lblLatLong.TabIndex = 2;
            this.lblLatLong.Text = "Latitude Longitude";
            // 
            // cmbLatLong
            // 
            this.cmbLatLong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLatLong.FormattingEnabled = true;
            this.cmbLatLong.Location = new System.Drawing.Point(329, 145);
            this.cmbLatLong.Name = "cmbLatLong";
            this.cmbLatLong.Size = new System.Drawing.Size(103, 21);
            this.cmbLatLong.TabIndex = 3;
            // 
            // lblDanger
            // 
            this.lblDanger.AutoSize = true;
            this.lblDanger.Location = new System.Drawing.Point(232, 172);
            this.lblDanger.Name = "lblDanger";
            this.lblDanger.Size = new System.Drawing.Size(54, 13);
            this.lblDanger.TabIndex = 2;
            this.lblDanger.Text = "In Danger";
            // 
            // cmbDanger
            // 
            this.cmbDanger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDanger.FormattingEnabled = true;
            this.cmbDanger.Location = new System.Drawing.Point(329, 170);
            this.cmbDanger.Name = "cmbDanger";
            this.cmbDanger.Size = new System.Drawing.Size(103, 21);
            this.cmbDanger.TabIndex = 3;
            // 
            // lblInterdiction
            // 
            this.lblInterdiction.AutoSize = true;
            this.lblInterdiction.Location = new System.Drawing.Point(232, 198);
            this.lblInterdiction.Name = "lblInterdiction";
            this.lblInterdiction.Size = new System.Drawing.Size(59, 13);
            this.lblInterdiction.TabIndex = 2;
            this.lblInterdiction.Text = "Interdiction";
            // 
            // cmbInterdiction
            // 
            this.cmbInterdiction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterdiction.FormattingEnabled = true;
            this.cmbInterdiction.Location = new System.Drawing.Point(329, 195);
            this.cmbInterdiction.Name = "cmbInterdiction";
            this.cmbInterdiction.Size = new System.Drawing.Size(103, 21);
            this.cmbInterdiction.TabIndex = 3;
            // 
            // cmbNightvision
            // 
            this.cmbNightvision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNightvision.FormattingEnabled = true;
            this.cmbNightvision.Location = new System.Drawing.Point(329, 321);
            this.cmbNightvision.Name = "cmbNightvision";
            this.cmbNightvision.Size = new System.Drawing.Size(103, 21);
            this.cmbNightvision.TabIndex = 3;
            // 
            // lblNightvision
            // 
            this.lblNightvision.AutoSize = true;
            this.lblNightvision.Location = new System.Drawing.Point(232, 323);
            this.lblNightvision.Name = "lblNightvision";
            this.lblNightvision.Size = new System.Drawing.Size(63, 13);
            this.lblNightvision.TabIndex = 2;
            this.lblNightvision.Text = "Night Vision";
            // 
            // cmbAnalysisMode
            // 
            this.cmbAnalysisMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnalysisMode.FormattingEnabled = true;
            this.cmbAnalysisMode.Location = new System.Drawing.Point(329, 296);
            this.cmbAnalysisMode.Name = "cmbAnalysisMode";
            this.cmbAnalysisMode.Size = new System.Drawing.Size(103, 21);
            this.cmbAnalysisMode.TabIndex = 3;
            // 
            // lblAnalysisMode
            // 
            this.lblAnalysisMode.AutoSize = true;
            this.lblAnalysisMode.Location = new System.Drawing.Point(232, 298);
            this.lblAnalysisMode.Name = "lblAnalysisMode";
            this.lblAnalysisMode.Size = new System.Drawing.Size(75, 13);
            this.lblAnalysisMode.TabIndex = 2;
            this.lblAnalysisMode.Text = "Analysis Mode";
            // 
            // cmbInSRV
            // 
            this.cmbInSRV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInSRV.FormattingEnabled = true;
            this.cmbInSRV.Location = new System.Drawing.Point(329, 270);
            this.cmbInSRV.Name = "cmbInSRV";
            this.cmbInSRV.Size = new System.Drawing.Size(103, 21);
            this.cmbInSRV.TabIndex = 3;
            // 
            // lblInSRV
            // 
            this.lblInSRV.AutoSize = true;
            this.lblInSRV.Location = new System.Drawing.Point(232, 273);
            this.lblInSRV.Name = "lblInSRV";
            this.lblInSRV.Size = new System.Drawing.Size(41, 13);
            this.lblInSRV.TabIndex = 2;
            this.lblInSRV.Text = "In SRV";
            // 
            // cmbInFighter
            // 
            this.cmbInFighter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInFighter.FormattingEnabled = true;
            this.cmbInFighter.Location = new System.Drawing.Point(329, 245);
            this.cmbInFighter.Name = "cmbInFighter";
            this.cmbInFighter.Size = new System.Drawing.Size(103, 21);
            this.cmbInFighter.TabIndex = 3;
            // 
            // lblInFighter
            // 
            this.lblInFighter.AutoSize = true;
            this.lblInFighter.Location = new System.Drawing.Point(232, 248);
            this.lblInFighter.Name = "lblInFighter";
            this.lblInFighter.Size = new System.Drawing.Size(51, 13);
            this.lblInFighter.TabIndex = 2;
            this.lblInFighter.Text = "In Fighter";
            // 
            // cmbInMainShip
            // 
            this.cmbInMainShip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInMainShip.FormattingEnabled = true;
            this.cmbInMainShip.Location = new System.Drawing.Point(329, 220);
            this.cmbInMainShip.Name = "cmbInMainShip";
            this.cmbInMainShip.Size = new System.Drawing.Size(103, 21);
            this.cmbInMainShip.TabIndex = 3;
            // 
            // lblInMainShip
            // 
            this.lblInMainShip.AutoSize = true;
            this.lblInMainShip.Location = new System.Drawing.Point(232, 223);
            this.lblInMainShip.Name = "lblInMainShip";
            this.lblInMainShip.Size = new System.Drawing.Size(66, 13);
            this.lblInMainShip.TabIndex = 2;
            this.lblInMainShip.Text = "In Main Ship";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(383, 466);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(64, 24);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(314, 466);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAutoSelect
            // 
            this.btnAutoSelect.Location = new System.Drawing.Point(195, 466);
            this.btnAutoSelect.Name = "btnAutoSelect";
            this.btnAutoSelect.Size = new System.Drawing.Size(113, 24);
            this.btnAutoSelect.TabIndex = 5;
            this.btnAutoSelect.Text = "Auto Select Buttons";
            this.btnAutoSelect.UseVisualStyleBackColor = true;
            this.btnAutoSelect.Click += new System.EventHandler(this.btnAutoSelect_Click);
            // 
            // ConfigurationDialog
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(458, 502);
            this.ControlBox = false;
            this.Controls.Add(this.btnAutoSelect);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbTarget);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationDialog";
            this.Text = "Elite Dangerous Status Feeder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigurationDialog_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigurationDialog_FormClosed);
            this.Shown += new System.EventHandler(this.ConfigurationDialog_Show);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTarget;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDocked;
        private System.Windows.Forms.ComboBox cmbDocked;
        private System.Windows.Forms.Label lblLanded;
        private System.Windows.Forms.ComboBox cmbLanded;
        private System.Windows.Forms.Label lblLandingGear;
        private System.Windows.Forms.ComboBox cmbLandingGear;
        private System.Windows.Forms.Label lblShields;
        private System.Windows.Forms.ComboBox cmbShields;
        private System.Windows.Forms.Label lblSupercruise;
        private System.Windows.Forms.ComboBox cmbSupercruise;
        private System.Windows.Forms.Label lblFlightAssist;
        private System.Windows.Forms.ComboBox cmbFlightAssist;
        private System.Windows.Forms.Label lblHardpoints;
        private System.Windows.Forms.ComboBox cmbHardpoints;
        private System.Windows.Forms.Label lblWing;
        private System.Windows.Forms.ComboBox cmbWing;
        private System.Windows.Forms.ComboBox cmbSRVDriveAssist;
        private System.Windows.Forms.Label lblSRVDriveAssist;
        private System.Windows.Forms.ComboBox cmbSRVTurretAllowed;
        private System.Windows.Forms.Label lblSRVTurretAllowed;
        private System.Windows.Forms.ComboBox cmbSRVTurret;
        private System.Windows.Forms.Label lblSRVTurret;
        private System.Windows.Forms.ComboBox cmbSRVHandbrake;
        private System.Windows.Forms.Label lblSRVHandbrake;
        private System.Windows.Forms.ComboBox cmbFuelScoop;
        private System.Windows.Forms.Label lblFuelScoop;
        private System.Windows.Forms.ComboBox cmbSilentRunning;
        private System.Windows.Forms.Label lblSilentRunning;
        private System.Windows.Forms.ComboBox cmbCargoScoop;
        private System.Windows.Forms.Label lblCargoScoop;
        private System.Windows.Forms.ComboBox cmbLights;
        private System.Windows.Forms.Label lblLights;
        private System.Windows.Forms.Label lblMassLocked;
        private System.Windows.Forms.ComboBox cmbMassLocked;
        private System.Windows.Forms.Label lblFSDCharging;
        private System.Windows.Forms.ComboBox cmbFSDCharging;
        private System.Windows.Forms.Label lblFSDCooldown;
        private System.Windows.Forms.ComboBox cmbFSDCooldown;
        private System.Windows.Forms.Label lblLowFuel;
        private System.Windows.Forms.ComboBox cmbLowFuel;
        private System.Windows.Forms.Label lblOverheating;
        private System.Windows.Forms.ComboBox cmbOverheating;
        private System.Windows.Forms.Label lblLatLong;
        private System.Windows.Forms.ComboBox cmbLatLong;
        private System.Windows.Forms.Label lblDanger;
        private System.Windows.Forms.ComboBox cmbDanger;
        private System.Windows.Forms.Label lblInterdiction;
        private System.Windows.Forms.ComboBox cmbInterdiction;
        private System.Windows.Forms.ComboBox cmbNightvision;
        private System.Windows.Forms.Label lblNightvision;
        private System.Windows.Forms.ComboBox cmbAnalysisMode;
        private System.Windows.Forms.Label lblAnalysisMode;
        private System.Windows.Forms.ComboBox cmbInSRV;
        private System.Windows.Forms.Label lblInSRV;
        private System.Windows.Forms.Label lblInFighter;
        private System.Windows.Forms.ComboBox cmbInMainShip;
        private System.Windows.Forms.Label lblInMainShip;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbInFighter;
        private System.Windows.Forms.ComboBox cmbSRVHighBeam;
        private System.Windows.Forms.Label lblSRVHighBeam;
        private System.Windows.Forms.ComboBox cmbJumping;
        private System.Windows.Forms.Label lblJumping;
        private System.Windows.Forms.ComboBox cmbUnknown;
        private System.Windows.Forms.Label lblUnknown;
        private System.Windows.Forms.Button btnAutoSelect;
    }
}

