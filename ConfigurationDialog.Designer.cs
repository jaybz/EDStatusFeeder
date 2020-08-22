namespace EDStatusFeeder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTarget = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridButtons2 = new System.Windows.Forms.DataGridView();
            this.gridButtons2Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridButtons2ButtonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridButtons2Selection = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gridButtons1 = new System.Windows.Forms.DataGridView();
            this.gridButtons1Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridButtons1ButtonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridButtons1Selection = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAutoSelect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridButtons2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridButtons1)).BeginInit();
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
            this.cmbTarget.Location = new System.Drawing.Point(95, 10);
            this.cmbTarget.Name = "cmbTarget";
            this.cmbTarget.Size = new System.Drawing.Size(132, 21);
            this.cmbTarget.TabIndex = 3;
            this.cmbTarget.SelectedIndexChanged += new System.EventHandler(this.CmbTarget_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridButtons2);
            this.groupBox1.Controls.Add(this.gridButtons1);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 373);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Buttons";
            // 
            // gridButtons2
            // 
            this.gridButtons2.AllowUserToAddRows = false;
            this.gridButtons2.AllowUserToDeleteRows = false;
            this.gridButtons2.AllowUserToResizeColumns = false;
            this.gridButtons2.AllowUserToResizeRows = false;
            this.gridButtons2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridButtons2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridButtons2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridButtons2.ColumnHeadersVisible = false;
            this.gridButtons2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridButtons2Key,
            this.gridButtons2ButtonName,
            this.gridButtons2Selection});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridButtons2.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridButtons2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridButtons2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridButtons2.Location = new System.Drawing.Point(219, 16);
            this.gridButtons2.MultiSelect = false;
            this.gridButtons2.Name = "gridButtons2";
            this.gridButtons2.RowHeadersVisible = false;
            this.gridButtons2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridButtons2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridButtons2.Size = new System.Drawing.Size(212, 354);
            this.gridButtons2.TabIndex = 7;
            this.gridButtons2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridButtons2_CellClick);
            this.gridButtons2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.GridButtons2_EditingControlShowing);
            // 
            // gridButtons2Key
            // 
            this.gridButtons2Key.DataPropertyName = "Key";
            this.gridButtons2Key.HeaderText = "Key";
            this.gridButtons2Key.Name = "gridButtons2Key";
            this.gridButtons2Key.ReadOnly = true;
            this.gridButtons2Key.Visible = false;
            // 
            // gridButtons2ButtonName
            // 
            this.gridButtons2ButtonName.DataPropertyName = "ButtonName";
            this.gridButtons2ButtonName.HeaderText = "Status Name";
            this.gridButtons2ButtonName.Name = "gridButtons2ButtonName";
            this.gridButtons2ButtonName.ReadOnly = true;
            this.gridButtons2ButtonName.Width = 128;
            // 
            // gridButtons2Selection
            // 
            this.gridButtons2Selection.DataPropertyName = "Selection";
            this.gridButtons2Selection.HeaderText = "Status Button";
            this.gridButtons2Selection.Name = "gridButtons2Selection";
            this.gridButtons2Selection.Width = 83;
            // 
            // gridButtons1
            // 
            this.gridButtons1.AllowUserToAddRows = false;
            this.gridButtons1.AllowUserToDeleteRows = false;
            this.gridButtons1.AllowUserToResizeColumns = false;
            this.gridButtons1.AllowUserToResizeRows = false;
            this.gridButtons1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridButtons1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridButtons1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridButtons1.ColumnHeadersVisible = false;
            this.gridButtons1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridButtons1Key,
            this.gridButtons1ButtonName,
            this.gridButtons1Selection});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridButtons1.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridButtons1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridButtons1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridButtons1.Location = new System.Drawing.Point(3, 16);
            this.gridButtons1.MultiSelect = false;
            this.gridButtons1.Name = "gridButtons1";
            this.gridButtons1.RowHeadersVisible = false;
            this.gridButtons1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridButtons1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridButtons1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridButtons1.ShowCellErrors = false;
            this.gridButtons1.ShowCellToolTips = false;
            this.gridButtons1.ShowEditingIcon = false;
            this.gridButtons1.ShowRowErrors = false;
            this.gridButtons1.Size = new System.Drawing.Size(212, 354);
            this.gridButtons1.TabIndex = 6;
            this.gridButtons1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridButtons1_CellClick);
            this.gridButtons1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.GridButtons1_EditingControlShowing);
            // 
            // gridButtons1Key
            // 
            this.gridButtons1Key.DataPropertyName = "Key";
            this.gridButtons1Key.HeaderText = "Key";
            this.gridButtons1Key.Name = "gridButtons1Key";
            this.gridButtons1Key.ReadOnly = true;
            this.gridButtons1Key.Visible = false;
            // 
            // gridButtons1ButtonName
            // 
            this.gridButtons1ButtonName.DataPropertyName = "ButtonName";
            this.gridButtons1ButtonName.HeaderText = "Status Name";
            this.gridButtons1ButtonName.Name = "gridButtons1ButtonName";
            this.gridButtons1ButtonName.ReadOnly = true;
            this.gridButtons1ButtonName.Width = 128;
            // 
            // gridButtons1Selection
            // 
            this.gridButtons1Selection.DataPropertyName = "Selection";
            this.gridButtons1Selection.HeaderText = "Status Button";
            this.gridButtons1Selection.Name = "gridButtons1Selection";
            this.gridButtons1Selection.Width = 83;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(382, 416);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(64, 24);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(313, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAutoSelect
            // 
            this.btnAutoSelect.Location = new System.Drawing.Point(194, 416);
            this.btnAutoSelect.Name = "btnAutoSelect";
            this.btnAutoSelect.Size = new System.Drawing.Size(113, 24);
            this.btnAutoSelect.TabIndex = 5;
            this.btnAutoSelect.Text = "Auto Select Buttons";
            this.btnAutoSelect.UseVisualStyleBackColor = true;
            this.btnAutoSelect.Click += new System.EventHandler(this.BtnAutoSelect_Click);
            // 
            // ConfigurationDialog
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(458, 452);
            this.ControlBox = false;
            this.Controls.Add(this.btnAutoSelect);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbTarget);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.gridButtons2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridButtons1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTarget;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAutoSelect;
        private System.Windows.Forms.DataGridView gridButtons1;
        private System.Windows.Forms.DataGridView gridButtons2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridButtons2Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridButtons2ButtonName;
        private System.Windows.Forms.DataGridViewComboBoxColumn gridButtons2Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridButtons1Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridButtons1ButtonName;
        private System.Windows.Forms.DataGridViewComboBoxColumn gridButtons1Selection;
    }
}

