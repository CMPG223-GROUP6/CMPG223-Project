namespace MaintainEmployees
{
    partial class frmMaintainEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlMaintainEmployees = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.lblInstructionsAdd = new System.Windows.Forms.Label();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.lblSurnameAdd = new System.Windows.Forms.Label();
            this.lblCellNumAdd = new System.Windows.Forms.Label();
            this.chkActiveAdd = new System.Windows.Forms.CheckBox();
            this.lblUsernameAdd = new System.Windows.Forms.Label();
            this.lblPasswordAdd = new System.Windows.Forms.Label();
            this.txtCellNumAdd = new System.Windows.Forms.MaskedTextBox();
            this.chkIsAdminAdd = new System.Windows.Forms.CheckBox();
            this.txtPasswordAdd = new System.Windows.Forms.TextBox();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.txtUsernameAdd = new System.Windows.Forms.TextBox();
            this.txtSurnameAdd = new System.Windows.Forms.TextBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblTitleAdd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.lblInstructionsUpdate = new System.Windows.Forms.Label();
            this.btnBackUpdate = new System.Windows.Forms.Button();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.lblEmployeeIDUpdate = new System.Windows.Forms.Label();
            this.txtUsernameUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.lblUsernameUpdate = new System.Windows.Forms.Label();
            this.lblSurnameUpdate = new System.Windows.Forms.Label();
            this.lblCellNumUpdate = new System.Windows.Forms.Label();
            this.chkIsActiveUpdate = new System.Windows.Forms.CheckBox();
            this.lblPasswordUpdate = new System.Windows.Forms.Label();
            this.chkIsAdminUpdate = new System.Windows.Forms.CheckBox();
            this.cmbEmployeeIDUpdate = new System.Windows.Forms.ComboBox();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.txtCellNumUpdate = new System.Windows.Forms.MaskedTextBox();
            this.txtSurnameUpdate = new System.Windows.Forms.TextBox();
            this.txtPasswordUpdate = new System.Windows.Forms.TextBox();
            this.lblTitleUpdate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.lblInstructionsDelete = new System.Windows.Forms.Label();
            this.lblTitleDelete = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbEmployeeIDDelete = new System.Windows.Forms.ComboBox();
            this.lblEmployeeIDDelete = new System.Windows.Forms.Label();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.toolTipNameAdd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSurnameAdd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCellNumAdd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUsernameAdd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPasswordAdd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAdminAdd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipActiveAdd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAddButton = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBackToDash = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEmployeeIDUpdate = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipNameUpdate = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSurnameUpdate = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCellNoUpdate = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUsernameUpdate = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipActiveUpdate = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPasswordUpdate = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAdminUpdate = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDashboardUpdate = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDelete = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipcmbEmployeeIDDelete = new System.Windows.Forms.ToolTip(this.components);
            this.btnBackDelete = new System.Windows.Forms.Button();
            this.toolTipDashDelete = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlMaintainEmployees.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            this.tabPageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMaintainEmployees
            // 
            this.tabControlMaintainEmployees.Controls.Add(this.tabPageAdd);
            this.tabControlMaintainEmployees.Controls.Add(this.tabPageUpdate);
            this.tabControlMaintainEmployees.Controls.Add(this.tabPageDelete);
            this.tabControlMaintainEmployees.Controls.Add(this.tabPageView);
            this.tabControlMaintainEmployees.Location = new System.Drawing.Point(-1, 0);
            this.tabControlMaintainEmployees.Name = "tabControlMaintainEmployees";
            this.tabControlMaintainEmployees.SelectedIndex = 0;
            this.tabControlMaintainEmployees.Size = new System.Drawing.Size(802, 498);
            this.tabControlMaintainEmployees.TabIndex = 1;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageAdd.Controls.Add(this.lblInstructionsAdd);
            this.tabPageAdd.Controls.Add(this.pnlAdd);
            this.tabPageAdd.Controls.Add(this.btnDashboard);
            this.tabPageAdd.Controls.Add(this.lblTitleAdd);
            this.tabPageAdd.Controls.Add(this.btnAdd);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(794, 472);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Add";
            // 
            // lblInstructionsAdd
            // 
            this.lblInstructionsAdd.AutoSize = true;
            this.lblInstructionsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblInstructionsAdd.Location = new System.Drawing.Point(285, 50);
            this.lblInstructionsAdd.Name = "lblInstructionsAdd";
            this.lblInstructionsAdd.Size = new System.Drawing.Size(276, 16);
            this.lblInstructionsAdd.TabIndex = 13;
            this.lblInstructionsAdd.Text = "Please enter the details of the new employee.";
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.lblNameAdd);
            this.pnlAdd.Controls.Add(this.lblSurnameAdd);
            this.pnlAdd.Controls.Add(this.lblCellNumAdd);
            this.pnlAdd.Controls.Add(this.chkActiveAdd);
            this.pnlAdd.Controls.Add(this.lblUsernameAdd);
            this.pnlAdd.Controls.Add(this.lblPasswordAdd);
            this.pnlAdd.Controls.Add(this.txtCellNumAdd);
            this.pnlAdd.Controls.Add(this.chkIsAdminAdd);
            this.pnlAdd.Controls.Add(this.txtPasswordAdd);
            this.pnlAdd.Controls.Add(this.txtNameAdd);
            this.pnlAdd.Controls.Add(this.txtUsernameAdd);
            this.pnlAdd.Controls.Add(this.txtSurnameAdd);
            this.pnlAdd.Location = new System.Drawing.Point(288, 85);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(282, 239);
            this.pnlAdd.TabIndex = 16;
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNameAdd.Location = new System.Drawing.Point(3, 12);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(47, 16);
            this.lblNameAdd.TabIndex = 0;
            this.lblNameAdd.Text = "Name:";
            // 
            // lblSurnameAdd
            // 
            this.lblSurnameAdd.AutoSize = true;
            this.lblSurnameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblSurnameAdd.Location = new System.Drawing.Point(3, 45);
            this.lblSurnameAdd.Name = "lblSurnameAdd";
            this.lblSurnameAdd.Size = new System.Drawing.Size(64, 16);
            this.lblSurnameAdd.TabIndex = 1;
            this.lblSurnameAdd.Text = "Surname:";
            // 
            // lblCellNumAdd
            // 
            this.lblCellNumAdd.AutoSize = true;
            this.lblCellNumAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCellNumAdd.Location = new System.Drawing.Point(3, 78);
            this.lblCellNumAdd.Name = "lblCellNumAdd";
            this.lblCellNumAdd.Size = new System.Drawing.Size(119, 16);
            this.lblCellNumAdd.TabIndex = 2;
            this.lblCellNumAdd.Text = "Cellphone number:";
            // 
            // chkActiveAdd
            // 
            this.chkActiveAdd.AutoSize = true;
            this.chkActiveAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkActiveAdd.Location = new System.Drawing.Point(6, 212);
            this.chkActiveAdd.Name = "chkActiveAdd";
            this.chkActiveAdd.Size = new System.Drawing.Size(170, 20);
            this.chkActiveAdd.TabIndex = 6;
            this.chkActiveAdd.Text = "Is this employee Active?";
            this.toolTipActiveAdd.SetToolTip(this.chkActiveAdd, "Please click on the box to select yes. Select again to deselect your choice.");
            this.chkActiveAdd.UseVisualStyleBackColor = true;
            // 
            // lblUsernameAdd
            // 
            this.lblUsernameAdd.AutoSize = true;
            this.lblUsernameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblUsernameAdd.Location = new System.Drawing.Point(3, 110);
            this.lblUsernameAdd.Name = "lblUsernameAdd";
            this.lblUsernameAdd.Size = new System.Drawing.Size(73, 16);
            this.lblUsernameAdd.TabIndex = 3;
            this.lblUsernameAdd.Text = "Username:";
            // 
            // lblPasswordAdd
            // 
            this.lblPasswordAdd.AutoSize = true;
            this.lblPasswordAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPasswordAdd.Location = new System.Drawing.Point(3, 143);
            this.lblPasswordAdd.Name = "lblPasswordAdd";
            this.lblPasswordAdd.Size = new System.Drawing.Size(70, 16);
            this.lblPasswordAdd.TabIndex = 4;
            this.lblPasswordAdd.Text = "Password:";
            // 
            // txtCellNumAdd
            // 
            this.txtCellNumAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCellNumAdd.Location = new System.Drawing.Point(168, 75);
            this.txtCellNumAdd.Mask = "9990000000";
            this.txtCellNumAdd.Name = "txtCellNumAdd";
            this.txtCellNumAdd.Size = new System.Drawing.Size(100, 22);
            this.txtCellNumAdd.TabIndex = 2;
            this.toolTipCellNumAdd.SetToolTip(this.txtCellNumAdd, "Please enter a cellphone number.");
            // 
            // chkIsAdminAdd
            // 
            this.chkIsAdminAdd.AutoSize = true;
            this.chkIsAdminAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkIsAdminAdd.Location = new System.Drawing.Point(6, 180);
            this.chkIsAdminAdd.Name = "chkIsAdminAdd";
            this.chkIsAdminAdd.Size = new System.Drawing.Size(189, 20);
            this.chkIsAdminAdd.TabIndex = 5;
            this.chkIsAdminAdd.Text = "Is this employee an Admin?";
            this.toolTipAdminAdd.SetToolTip(this.chkIsAdminAdd, "Please click on the box to select yes. Select again to deselect your choice.");
            this.chkIsAdminAdd.UseVisualStyleBackColor = true;
            // 
            // txtPasswordAdd
            // 
            this.txtPasswordAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPasswordAdd.Location = new System.Drawing.Point(168, 143);
            this.txtPasswordAdd.Name = "txtPasswordAdd";
            this.txtPasswordAdd.Size = new System.Drawing.Size(100, 22);
            this.txtPasswordAdd.TabIndex = 4;
            this.toolTipPasswordAdd.SetToolTip(this.txtPasswordAdd, "Please enter a password.");
            this.txtPasswordAdd.UseSystemPasswordChar = true;
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNameAdd.Location = new System.Drawing.Point(168, 9);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(100, 22);
            this.txtNameAdd.TabIndex = 0;
            this.toolTipNameAdd.SetToolTip(this.txtNameAdd, "Please enter a name.");
            // 
            // txtUsernameAdd
            // 
            this.txtUsernameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUsernameAdd.Location = new System.Drawing.Point(168, 107);
            this.txtUsernameAdd.Name = "txtUsernameAdd";
            this.txtUsernameAdd.Size = new System.Drawing.Size(100, 22);
            this.txtUsernameAdd.TabIndex = 3;
            this.toolTipUsernameAdd.SetToolTip(this.txtUsernameAdd, "Please enter a username.");
            // 
            // txtSurnameAdd
            // 
            this.txtSurnameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSurnameAdd.Location = new System.Drawing.Point(168, 42);
            this.txtSurnameAdd.Name = "txtSurnameAdd";
            this.txtSurnameAdd.Size = new System.Drawing.Size(100, 22);
            this.txtSurnameAdd.TabIndex = 1;
            this.toolTipSurnameAdd.SetToolTip(this.txtSurnameAdd, "Please enter a surname.");
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(441, 366);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(160, 40);
            this.btnDashboard.TabIndex = 8;
            this.btnDashboard.Text = "&Back to dashboard";
            this.toolTipBackToDash.SetToolTip(this.btnDashboard, "Click to go back to the dashboard menu.");
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblTitleAdd
            // 
            this.lblTitleAdd.AutoSize = true;
            this.lblTitleAdd.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblTitleAdd.Location = new System.Drawing.Point(284, 0);
            this.lblTitleAdd.Name = "lblTitleAdd";
            this.lblTitleAdd.Size = new System.Drawing.Size(286, 37);
            this.lblTitleAdd.TabIndex = 13;
            this.lblTitleAdd.Text = "Add a new employee";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(239, 366);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add new employee";
            this.toolTipAddButton.SetToolTip(this.btnAdd, "Click to add the new employee.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageUpdate.Controls.Add(this.lblInstructionsUpdate);
            this.tabPageUpdate.Controls.Add(this.btnBackUpdate);
            this.tabPageUpdate.Controls.Add(this.pnlUpdate);
            this.tabPageUpdate.Controls.Add(this.lblTitleUpdate);
            this.tabPageUpdate.Controls.Add(this.btnUpdate);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(794, 472);
            this.tabPageUpdate.TabIndex = 1;
            this.tabPageUpdate.Text = "Update";
            // 
            // lblInstructionsUpdate
            // 
            this.lblInstructionsUpdate.AutoSize = true;
            this.lblInstructionsUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblInstructionsUpdate.Location = new System.Drawing.Point(250, 48);
            this.lblInstructionsUpdate.Name = "lblInstructionsUpdate";
            this.lblInstructionsUpdate.Size = new System.Drawing.Size(389, 16);
            this.lblInstructionsUpdate.TabIndex = 18;
            this.lblInstructionsUpdate.Text = "Please enter the new details of the employee you have selected.";
            // 
            // btnBackUpdate
            // 
            this.btnBackUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBackUpdate.Location = new System.Drawing.Point(453, 409);
            this.btnBackUpdate.Name = "btnBackUpdate";
            this.btnBackUpdate.Size = new System.Drawing.Size(160, 40);
            this.btnBackUpdate.TabIndex = 1;
            this.btnBackUpdate.Text = "&Back to dashboard";
            this.toolTipDashboardUpdate.SetToolTip(this.btnBackUpdate, "Click to go back to the dashboard menu.");
            this.btnBackUpdate.UseVisualStyleBackColor = true;
            this.btnBackUpdate.Click += new System.EventHandler(this.btnBackUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.lblEmployeeIDUpdate);
            this.pnlUpdate.Controls.Add(this.txtUsernameUpdate);
            this.pnlUpdate.Controls.Add(this.lblNameUpdate);
            this.pnlUpdate.Controls.Add(this.lblUsernameUpdate);
            this.pnlUpdate.Controls.Add(this.lblSurnameUpdate);
            this.pnlUpdate.Controls.Add(this.lblCellNumUpdate);
            this.pnlUpdate.Controls.Add(this.chkIsActiveUpdate);
            this.pnlUpdate.Controls.Add(this.lblPasswordUpdate);
            this.pnlUpdate.Controls.Add(this.chkIsAdminUpdate);
            this.pnlUpdate.Controls.Add(this.cmbEmployeeIDUpdate);
            this.pnlUpdate.Controls.Add(this.txtNameUpdate);
            this.pnlUpdate.Controls.Add(this.txtCellNumUpdate);
            this.pnlUpdate.Controls.Add(this.txtSurnameUpdate);
            this.pnlUpdate.Controls.Add(this.txtPasswordUpdate);
            this.pnlUpdate.Location = new System.Drawing.Point(307, 82);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(271, 304);
            this.pnlUpdate.TabIndex = 16;
            // 
            // lblEmployeeIDUpdate
            // 
            this.lblEmployeeIDUpdate.AutoSize = true;
            this.lblEmployeeIDUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEmployeeIDUpdate.Location = new System.Drawing.Point(17, 11);
            this.lblEmployeeIDUpdate.Name = "lblEmployeeIDUpdate";
            this.lblEmployeeIDUpdate.Size = new System.Drawing.Size(88, 16);
            this.lblEmployeeIDUpdate.TabIndex = 0;
            this.lblEmployeeIDUpdate.Text = "Employee ID:";
            // 
            // txtUsernameUpdate
            // 
            this.txtUsernameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUsernameUpdate.Location = new System.Drawing.Point(155, 157);
            this.txtUsernameUpdate.Name = "txtUsernameUpdate";
            this.txtUsernameUpdate.Size = new System.Drawing.Size(100, 22);
            this.txtUsernameUpdate.TabIndex = 4;
            this.toolTipUsernameUpdate.SetToolTip(this.txtUsernameUpdate, "Please enter a username.");
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNameUpdate.Location = new System.Drawing.Point(17, 54);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(47, 16);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name:";
            // 
            // lblUsernameUpdate
            // 
            this.lblUsernameUpdate.AutoSize = true;
            this.lblUsernameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblUsernameUpdate.Location = new System.Drawing.Point(17, 163);
            this.lblUsernameUpdate.Name = "lblUsernameUpdate";
            this.lblUsernameUpdate.Size = new System.Drawing.Size(73, 16);
            this.lblUsernameUpdate.TabIndex = 14;
            this.lblUsernameUpdate.Text = "Username:";
            // 
            // lblSurnameUpdate
            // 
            this.lblSurnameUpdate.AutoSize = true;
            this.lblSurnameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblSurnameUpdate.Location = new System.Drawing.Point(17, 91);
            this.lblSurnameUpdate.Name = "lblSurnameUpdate";
            this.lblSurnameUpdate.Size = new System.Drawing.Size(64, 16);
            this.lblSurnameUpdate.TabIndex = 2;
            this.lblSurnameUpdate.Text = "Surname:";
            // 
            // lblCellNumUpdate
            // 
            this.lblCellNumUpdate.AutoSize = true;
            this.lblCellNumUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCellNumUpdate.Location = new System.Drawing.Point(17, 128);
            this.lblCellNumUpdate.Name = "lblCellNumUpdate";
            this.lblCellNumUpdate.Size = new System.Drawing.Size(119, 16);
            this.lblCellNumUpdate.TabIndex = 3;
            this.lblCellNumUpdate.Text = "Cellphone number:";
            // 
            // chkIsActiveUpdate
            // 
            this.chkIsActiveUpdate.AutoSize = true;
            this.chkIsActiveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkIsActiveUpdate.Location = new System.Drawing.Point(20, 272);
            this.chkIsActiveUpdate.Name = "chkIsActiveUpdate";
            this.chkIsActiveUpdate.Size = new System.Drawing.Size(170, 20);
            this.chkIsActiveUpdate.TabIndex = 7;
            this.chkIsActiveUpdate.Text = "Is this employee Active?";
            this.toolTipActiveUpdate.SetToolTip(this.chkIsActiveUpdate, "Please click on the box to select yes. Select again to deselect your choice.");
            this.chkIsActiveUpdate.UseVisualStyleBackColor = true;
            // 
            // lblPasswordUpdate
            // 
            this.lblPasswordUpdate.AutoSize = true;
            this.lblPasswordUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPasswordUpdate.Location = new System.Drawing.Point(17, 202);
            this.lblPasswordUpdate.Name = "lblPasswordUpdate";
            this.lblPasswordUpdate.Size = new System.Drawing.Size(70, 16);
            this.lblPasswordUpdate.TabIndex = 4;
            this.lblPasswordUpdate.Text = "Password:";
            // 
            // chkIsAdminUpdate
            // 
            this.chkIsAdminUpdate.AutoSize = true;
            this.chkIsAdminUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkIsAdminUpdate.Location = new System.Drawing.Point(20, 237);
            this.chkIsAdminUpdate.Name = "chkIsAdminUpdate";
            this.chkIsAdminUpdate.Size = new System.Drawing.Size(189, 20);
            this.chkIsAdminUpdate.TabIndex = 6;
            this.chkIsAdminUpdate.Text = "Is this employee an Admin?";
            this.toolTipAdminUpdate.SetToolTip(this.chkIsAdminUpdate, "Please click on the box to select yes. Select again to deselect your choice.");
            this.chkIsAdminUpdate.UseVisualStyleBackColor = true;
            // 
            // cmbEmployeeIDUpdate
            // 
            this.cmbEmployeeIDUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbEmployeeIDUpdate.FormattingEnabled = true;
            this.cmbEmployeeIDUpdate.Location = new System.Drawing.Point(155, 8);
            this.cmbEmployeeIDUpdate.Name = "cmbEmployeeIDUpdate";
            this.cmbEmployeeIDUpdate.Size = new System.Drawing.Size(100, 24);
            this.cmbEmployeeIDUpdate.TabIndex = 0;
            this.toolTipEmployeeIDUpdate.SetToolTip(this.cmbEmployeeIDUpdate, "Please select an employee ID.");
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNameUpdate.Location = new System.Drawing.Point(155, 47);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(100, 22);
            this.txtNameUpdate.TabIndex = 1;
            this.toolTipNameUpdate.SetToolTip(this.txtNameUpdate, "Please enter a name.");
            // 
            // txtCellNumUpdate
            // 
            this.txtCellNumUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCellNumUpdate.Location = new System.Drawing.Point(155, 122);
            this.txtCellNumUpdate.Mask = "9990000000";
            this.txtCellNumUpdate.Name = "txtCellNumUpdate";
            this.txtCellNumUpdate.Size = new System.Drawing.Size(100, 22);
            this.txtCellNumUpdate.TabIndex = 3;
            this.toolTipCellNoUpdate.SetToolTip(this.txtCellNumUpdate, "Please enter a cellphone number.");
            // 
            // txtSurnameUpdate
            // 
            this.txtSurnameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSurnameUpdate.Location = new System.Drawing.Point(155, 85);
            this.txtSurnameUpdate.Name = "txtSurnameUpdate";
            this.txtSurnameUpdate.Size = new System.Drawing.Size(100, 22);
            this.txtSurnameUpdate.TabIndex = 2;
            this.toolTipSurnameUpdate.SetToolTip(this.txtSurnameUpdate, "Please enter a surname.");
            // 
            // txtPasswordUpdate
            // 
            this.txtPasswordUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPasswordUpdate.Location = new System.Drawing.Point(155, 196);
            this.txtPasswordUpdate.Name = "txtPasswordUpdate";
            this.txtPasswordUpdate.Size = new System.Drawing.Size(100, 22);
            this.txtPasswordUpdate.TabIndex = 5;
            this.toolTipPasswordUpdate.SetToolTip(this.txtPasswordUpdate, "Please enter a password.");
            this.txtPasswordUpdate.UseSystemPasswordChar = true;
            // 
            // lblTitleUpdate
            // 
            this.lblTitleUpdate.AutoSize = true;
            this.lblTitleUpdate.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblTitleUpdate.Location = new System.Drawing.Point(274, 0);
            this.lblTitleUpdate.Name = "lblTitleUpdate";
            this.lblTitleUpdate.Size = new System.Drawing.Size(339, 37);
            this.lblTitleUpdate.TabIndex = 13;
            this.lblTitleUpdate.Text = "Update employee details";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(263, 409);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 41);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "&Update details";
            this.toolTipAdminUpdate.SetToolTip(this.btnUpdate, "Click to update the selected employee ID\'s details.");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.BackColor = System.Drawing.Color.Pink;
            this.tabPageDelete.Controls.Add(this.btnBackDelete);
            this.tabPageDelete.Controls.Add(this.lblInstructionsDelete);
            this.tabPageDelete.Controls.Add(this.lblTitleDelete);
            this.tabPageDelete.Controls.Add(this.btnDelete);
            this.tabPageDelete.Controls.Add(this.cmbEmployeeIDDelete);
            this.tabPageDelete.Controls.Add(this.lblEmployeeIDDelete);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 22);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(794, 472);
            this.tabPageDelete.TabIndex = 2;
            this.tabPageDelete.Text = "Delete";
            // 
            // lblInstructionsDelete
            // 
            this.lblInstructionsDelete.AutoSize = true;
            this.lblInstructionsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblInstructionsDelete.Location = new System.Drawing.Point(269, 51);
            this.lblInstructionsDelete.Name = "lblInstructionsDelete";
            this.lblInstructionsDelete.Size = new System.Drawing.Size(338, 16);
            this.lblInstructionsDelete.TabIndex = 4;
            this.lblInstructionsDelete.Text = "Please select the ID of the employee you want to delete.";
            // 
            // lblTitleDelete
            // 
            this.lblTitleDelete.AutoSize = true;
            this.lblTitleDelete.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblTitleDelete.Location = new System.Drawing.Point(287, 0);
            this.lblTitleDelete.Name = "lblTitleDelete";
            this.lblTitleDelete.Size = new System.Drawing.Size(273, 37);
            this.lblTitleDelete.TabIndex = 3;
            this.lblTitleDelete.Text = "Delete an employee";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.Location = new System.Drawing.Point(249, 143);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 40);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "&Delete";
            this.toolTipDelete.SetToolTip(this.btnDelete, "Click on this to delete the record that corresponds to the selected employee ID.");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // cmbEmployeeIDDelete
            // 
            this.cmbEmployeeIDDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbEmployeeIDDelete.FormattingEnabled = true;
            this.cmbEmployeeIDDelete.Location = new System.Drawing.Point(455, 89);
            this.cmbEmployeeIDDelete.Name = "cmbEmployeeIDDelete";
            this.cmbEmployeeIDDelete.Size = new System.Drawing.Size(121, 24);
            this.cmbEmployeeIDDelete.TabIndex = 0;
            this.toolTipcmbEmployeeIDDelete.SetToolTip(this.cmbEmployeeIDDelete, "Select an employee ID to delete.");
            // 
            // lblEmployeeIDDelete
            // 
            this.lblEmployeeIDDelete.AutoSize = true;
            this.lblEmployeeIDDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEmployeeIDDelete.Location = new System.Drawing.Point(291, 92);
            this.lblEmployeeIDDelete.Name = "lblEmployeeIDDelete";
            this.lblEmployeeIDDelete.Size = new System.Drawing.Size(143, 16);
            this.lblEmployeeIDDelete.TabIndex = 0;
            this.lblEmployeeIDDelete.Text = "Employee ID to delete:";
            // 
            // tabPageView
            // 
            this.tabPageView.Controls.Add(this.dgvView);
            this.tabPageView.Location = new System.Drawing.Point(4, 22);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageView.Size = new System.Drawing.Size(794, 472);
            this.tabPageView.TabIndex = 3;
            this.tabPageView.Text = "View All Employees";
            this.tabPageView.UseVisualStyleBackColor = true;
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(-4, 0);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(798, 469);
            this.dgvView.TabIndex = 0;
            // 
            // btnBackDelete
            // 
            this.btnBackDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBackDelete.Location = new System.Drawing.Point(447, 143);
            this.btnBackDelete.Name = "btnBackDelete";
            this.btnBackDelete.Size = new System.Drawing.Size(160, 40);
            this.btnBackDelete.TabIndex = 2;
            this.btnBackDelete.Text = "&Back to dashboard";
            this.toolTipDashDelete.SetToolTip(this.btnBackDelete, "Click on this to go back to the dashboard menu.");
            this.btnBackDelete.UseVisualStyleBackColor = true;
            this.btnBackDelete.Click += new System.EventHandler(this.btnBackDelete_Click);
            // 
            // frmMaintainEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 490);
            this.Controls.Add(this.tabControlMaintainEmployees);
            this.Name = "frmMaintainEmployees";
            this.Text = "Maintain employees";
            this.tabControlMaintainEmployees.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            this.tabPageView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMaintainEmployees;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Label lblTitleAdd;
        private System.Windows.Forms.CheckBox chkActiveAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox txtCellNumAdd;
        private System.Windows.Forms.TextBox txtPasswordAdd;
        private System.Windows.Forms.TextBox txtUsernameAdd;
        private System.Windows.Forms.TextBox txtSurnameAdd;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.CheckBox chkIsAdminAdd;
        private System.Windows.Forms.Label lblPasswordAdd;
        private System.Windows.Forms.Label lblUsernameAdd;
        private System.Windows.Forms.Label lblCellNumAdd;
        private System.Windows.Forms.Label lblSurnameAdd;
        private System.Windows.Forms.Label lblNameAdd;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.TextBox txtUsernameUpdate;
        private System.Windows.Forms.Label lblUsernameUpdate;
        private System.Windows.Forms.Label lblTitleUpdate;
        private System.Windows.Forms.CheckBox chkIsActiveUpdate;
        private System.Windows.Forms.CheckBox chkIsAdminUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MaskedTextBox txtCellNumUpdate;
        private System.Windows.Forms.TextBox txtPasswordUpdate;
        private System.Windows.Forms.TextBox txtSurnameUpdate;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.ComboBox cmbEmployeeIDUpdate;
        private System.Windows.Forms.Label lblPasswordUpdate;
        private System.Windows.Forms.Label lblCellNumUpdate;
        private System.Windows.Forms.Label lblSurnameUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Label lblEmployeeIDUpdate;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.Label lblTitleDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbEmployeeIDDelete;
        private System.Windows.Forms.Label lblEmployeeIDDelete;
        private System.Windows.Forms.TabPage tabPageView;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label lblInstructionsAdd;
        private System.Windows.Forms.ToolTip toolTipNameAdd;
        private System.Windows.Forms.ToolTip toolTipSurnameAdd;
        private System.Windows.Forms.ToolTip toolTipCellNumAdd;
        private System.Windows.Forms.ToolTip toolTipUsernameAdd;
        private System.Windows.Forms.ToolTip toolTipPasswordAdd;
        private System.Windows.Forms.ToolTip toolTipAdminAdd;
        private System.Windows.Forms.ToolTip toolTipActiveAdd;
        private System.Windows.Forms.ToolTip toolTipAddButton;
        private System.Windows.Forms.ToolTip toolTipBackToDash;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Button btnBackUpdate;
        private System.Windows.Forms.Label lblInstructionsUpdate;
        private System.Windows.Forms.Label lblInstructionsDelete;
        private System.Windows.Forms.ToolTip toolTipEmployeeIDUpdate;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTipNameUpdate;
        private System.Windows.Forms.ToolTip toolTipSurnameUpdate;
        private System.Windows.Forms.ToolTip toolTipCellNoUpdate;
        private System.Windows.Forms.ToolTip toolTipUsernameUpdate;
        private System.Windows.Forms.ToolTip toolTipActiveUpdate;
        private System.Windows.Forms.ToolTip toolTipPasswordUpdate;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolTip toolTipAdminUpdate;
        private System.Windows.Forms.ToolTip toolTipDashboardUpdate;
        private System.Windows.Forms.ToolTip toolTipDelete;
        private System.Windows.Forms.ToolTip toolTipcmbEmployeeIDDelete;
        private System.Windows.Forms.Button btnBackDelete;
        private System.Windows.Forms.ToolTip toolTipDashDelete;
    }
}