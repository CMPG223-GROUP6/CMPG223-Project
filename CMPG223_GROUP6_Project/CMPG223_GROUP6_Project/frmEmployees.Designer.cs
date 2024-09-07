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
            this.tabControlMaintainEmployees = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActiveAdd = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCellNumAdd = new System.Windows.Forms.MaskedTextBox();
            this.txtPasswordAdd = new System.Windows.Forms.TextBox();
            this.txtUsernameAdd = new System.Windows.Forms.TextBox();
            this.txtSurnameAdd = new System.Windows.Forms.TextBox();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.chkIsAdminAdd = new System.Windows.Forms.CheckBox();
            this.lblPasswordAdd = new System.Windows.Forms.Label();
            this.lblUsernameAdd = new System.Windows.Forms.Label();
            this.lblCellNumAdd = new System.Windows.Forms.Label();
            this.lblSurnameAdd = new System.Windows.Forms.Label();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.txtUsernameUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIsActiveUpdate = new System.Windows.Forms.CheckBox();
            this.chkIsAdminUpdate = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCellNumUpdate = new System.Windows.Forms.MaskedTextBox();
            this.txtPasswordUpdate = new System.Windows.Forms.TextBox();
            this.txtSurnameUpdate = new System.Windows.Forms.TextBox();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.cmbEmployeeIDUpdate = new System.Windows.Forms.ComboBox();
            this.lblPasswordUpdate = new System.Windows.Forms.Label();
            this.lblCellNumUpdate = new System.Windows.Forms.Label();
            this.lblSurnameUpdate = new System.Windows.Forms.Label();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.lblEmployeeIDUpdate = new System.Windows.Forms.Label();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbEmployeeIDDelete = new System.Windows.Forms.ComboBox();
            this.lblEmployeeIDDelete = new System.Windows.Forms.Label();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.tabControlMaintainEmployees.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
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
            this.tabControlMaintainEmployees.Size = new System.Drawing.Size(802, 451);
            this.tabControlMaintainEmployees.TabIndex = 1;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.btnDashboard);
            this.tabPageAdd.Controls.Add(this.label1);
            this.tabPageAdd.Controls.Add(this.chkActiveAdd);
            this.tabPageAdd.Controls.Add(this.btnAdd);
            this.tabPageAdd.Controls.Add(this.txtCellNumAdd);
            this.tabPageAdd.Controls.Add(this.txtPasswordAdd);
            this.tabPageAdd.Controls.Add(this.txtUsernameAdd);
            this.tabPageAdd.Controls.Add(this.txtSurnameAdd);
            this.tabPageAdd.Controls.Add(this.txtNameAdd);
            this.tabPageAdd.Controls.Add(this.chkIsAdminAdd);
            this.tabPageAdd.Controls.Add(this.lblPasswordAdd);
            this.tabPageAdd.Controls.Add(this.lblUsernameAdd);
            this.tabPageAdd.Controls.Add(this.lblCellNumAdd);
            this.tabPageAdd.Controls.Add(this.lblSurnameAdd);
            this.tabPageAdd.Controls.Add(this.lblNameAdd);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(794, 425);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Add";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add a new employee";
            // 
            // chkActiveAdd
            // 
            this.chkActiveAdd.AutoSize = true;
            this.chkActiveAdd.Location = new System.Drawing.Point(264, 250);
            this.chkActiveAdd.Name = "chkActiveAdd";
            this.chkActiveAdd.Size = new System.Drawing.Size(140, 17);
            this.chkActiveAdd.TabIndex = 12;
            this.chkActiveAdd.Text = "Is this employee Active?";
            this.chkActiveAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(168, 288);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 41);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "&Add new employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtCellNumAdd
            // 
            this.txtCellNumAdd.Location = new System.Drawing.Point(426, 113);
            this.txtCellNumAdd.Mask = "9990000000";
            this.txtCellNumAdd.Name = "txtCellNumAdd";
            this.txtCellNumAdd.Size = new System.Drawing.Size(100, 20);
            this.txtCellNumAdd.TabIndex = 10;
            // 
            // txtPasswordAdd
            // 
            this.txtPasswordAdd.Location = new System.Drawing.Point(426, 181);
            this.txtPasswordAdd.Name = "txtPasswordAdd";
            this.txtPasswordAdd.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordAdd.TabIndex = 9;
            this.txtPasswordAdd.UseSystemPasswordChar = true;
            // 
            // txtUsernameAdd
            // 
            this.txtUsernameAdd.Location = new System.Drawing.Point(426, 145);
            this.txtUsernameAdd.Name = "txtUsernameAdd";
            this.txtUsernameAdd.Size = new System.Drawing.Size(100, 20);
            this.txtUsernameAdd.TabIndex = 8;
            // 
            // txtSurnameAdd
            // 
            this.txtSurnameAdd.Location = new System.Drawing.Point(426, 80);
            this.txtSurnameAdd.Name = "txtSurnameAdd";
            this.txtSurnameAdd.Size = new System.Drawing.Size(100, 20);
            this.txtSurnameAdd.TabIndex = 7;
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Location = new System.Drawing.Point(426, 47);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(100, 20);
            this.txtNameAdd.TabIndex = 6;
            // 
            // chkIsAdminAdd
            // 
            this.chkIsAdminAdd.AutoSize = true;
            this.chkIsAdminAdd.Location = new System.Drawing.Point(264, 218);
            this.chkIsAdminAdd.Name = "chkIsAdminAdd";
            this.chkIsAdminAdd.Size = new System.Drawing.Size(154, 17);
            this.chkIsAdminAdd.TabIndex = 5;
            this.chkIsAdminAdd.Text = "Is this employee an Admin?";
            this.chkIsAdminAdd.UseVisualStyleBackColor = true;
            // 
            // lblPasswordAdd
            // 
            this.lblPasswordAdd.AutoSize = true;
            this.lblPasswordAdd.Location = new System.Drawing.Point(261, 181);
            this.lblPasswordAdd.Name = "lblPasswordAdd";
            this.lblPasswordAdd.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordAdd.TabIndex = 4;
            this.lblPasswordAdd.Text = "Password";
            // 
            // lblUsernameAdd
            // 
            this.lblUsernameAdd.AutoSize = true;
            this.lblUsernameAdd.Location = new System.Drawing.Point(261, 148);
            this.lblUsernameAdd.Name = "lblUsernameAdd";
            this.lblUsernameAdd.Size = new System.Drawing.Size(58, 13);
            this.lblUsernameAdd.TabIndex = 3;
            this.lblUsernameAdd.Text = "Username:";
            // 
            // lblCellNumAdd
            // 
            this.lblCellNumAdd.AutoSize = true;
            this.lblCellNumAdd.Location = new System.Drawing.Point(261, 116);
            this.lblCellNumAdd.Name = "lblCellNumAdd";
            this.lblCellNumAdd.Size = new System.Drawing.Size(95, 13);
            this.lblCellNumAdd.TabIndex = 2;
            this.lblCellNumAdd.Text = "Cellphone number:";
            // 
            // lblSurnameAdd
            // 
            this.lblSurnameAdd.AutoSize = true;
            this.lblSurnameAdd.Location = new System.Drawing.Point(261, 83);
            this.lblSurnameAdd.Name = "lblSurnameAdd";
            this.lblSurnameAdd.Size = new System.Drawing.Size(52, 13);
            this.lblSurnameAdd.TabIndex = 1;
            this.lblSurnameAdd.Text = "Surname:";
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.Location = new System.Drawing.Point(261, 50);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(38, 13);
            this.lblNameAdd.TabIndex = 0;
            this.lblNameAdd.Text = "Name:";
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.txtUsernameUpdate);
            this.tabPageUpdate.Controls.Add(this.label4);
            this.tabPageUpdate.Controls.Add(this.label2);
            this.tabPageUpdate.Controls.Add(this.chkIsActiveUpdate);
            this.tabPageUpdate.Controls.Add(this.chkIsAdminUpdate);
            this.tabPageUpdate.Controls.Add(this.btnUpdate);
            this.tabPageUpdate.Controls.Add(this.txtCellNumUpdate);
            this.tabPageUpdate.Controls.Add(this.txtPasswordUpdate);
            this.tabPageUpdate.Controls.Add(this.txtSurnameUpdate);
            this.tabPageUpdate.Controls.Add(this.txtNameUpdate);
            this.tabPageUpdate.Controls.Add(this.cmbEmployeeIDUpdate);
            this.tabPageUpdate.Controls.Add(this.lblPasswordUpdate);
            this.tabPageUpdate.Controls.Add(this.lblCellNumUpdate);
            this.tabPageUpdate.Controls.Add(this.lblSurnameUpdate);
            this.tabPageUpdate.Controls.Add(this.lblNameUpdate);
            this.tabPageUpdate.Controls.Add(this.lblEmployeeIDUpdate);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(794, 425);
            this.tabPageUpdate.TabIndex = 1;
            this.tabPageUpdate.Text = "Update";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // txtUsernameUpdate
            // 
            this.txtUsernameUpdate.Location = new System.Drawing.Point(409, 204);
            this.txtUsernameUpdate.Name = "txtUsernameUpdate";
            this.txtUsernameUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtUsernameUpdate.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Update employee details";
            // 
            // chkIsActiveUpdate
            // 
            this.chkIsActiveUpdate.AutoSize = true;
            this.chkIsActiveUpdate.Location = new System.Drawing.Point(274, 304);
            this.chkIsActiveUpdate.Name = "chkIsActiveUpdate";
            this.chkIsActiveUpdate.Size = new System.Drawing.Size(140, 17);
            this.chkIsActiveUpdate.TabIndex = 12;
            this.chkIsActiveUpdate.Text = "Is this employee Active?";
            this.chkIsActiveUpdate.UseVisualStyleBackColor = true;
            // 
            // chkIsAdminUpdate
            // 
            this.chkIsAdminUpdate.AutoSize = true;
            this.chkIsAdminUpdate.Location = new System.Drawing.Point(274, 269);
            this.chkIsAdminUpdate.Name = "chkIsAdminUpdate";
            this.chkIsAdminUpdate.Size = new System.Drawing.Size(154, 17);
            this.chkIsAdminUpdate.TabIndex = 11;
            this.chkIsAdminUpdate.Text = "Is this employee an Admin?";
            this.chkIsAdminUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(333, 335);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 41);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "&Update details";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtCellNumUpdate
            // 
            this.txtCellNumUpdate.Location = new System.Drawing.Point(409, 169);
            this.txtCellNumUpdate.Mask = "9990000000";
            this.txtCellNumUpdate.Name = "txtCellNumUpdate";
            this.txtCellNumUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtCellNumUpdate.TabIndex = 9;
            // 
            // txtPasswordUpdate
            // 
            this.txtPasswordUpdate.Location = new System.Drawing.Point(409, 240);
            this.txtPasswordUpdate.Name = "txtPasswordUpdate";
            this.txtPasswordUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordUpdate.TabIndex = 8;
            this.txtPasswordUpdate.UseSystemPasswordChar = true;
            // 
            // txtSurnameUpdate
            // 
            this.txtSurnameUpdate.Location = new System.Drawing.Point(409, 129);
            this.txtSurnameUpdate.Name = "txtSurnameUpdate";
            this.txtSurnameUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtSurnameUpdate.TabIndex = 7;
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(409, 89);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtNameUpdate.TabIndex = 6;
            // 
            // cmbEmployeeIDUpdate
            // 
            this.cmbEmployeeIDUpdate.FormattingEnabled = true;
            this.cmbEmployeeIDUpdate.Location = new System.Drawing.Point(409, 46);
            this.cmbEmployeeIDUpdate.Name = "cmbEmployeeIDUpdate";
            this.cmbEmployeeIDUpdate.Size = new System.Drawing.Size(100, 21);
            this.cmbEmployeeIDUpdate.TabIndex = 5;
            // 
            // lblPasswordUpdate
            // 
            this.lblPasswordUpdate.AutoSize = true;
            this.lblPasswordUpdate.Location = new System.Drawing.Point(271, 243);
            this.lblPasswordUpdate.Name = "lblPasswordUpdate";
            this.lblPasswordUpdate.Size = new System.Drawing.Size(56, 13);
            this.lblPasswordUpdate.TabIndex = 4;
            this.lblPasswordUpdate.Text = "Password:";
            // 
            // lblCellNumUpdate
            // 
            this.lblCellNumUpdate.AutoSize = true;
            this.lblCellNumUpdate.Location = new System.Drawing.Point(271, 172);
            this.lblCellNumUpdate.Name = "lblCellNumUpdate";
            this.lblCellNumUpdate.Size = new System.Drawing.Size(95, 13);
            this.lblCellNumUpdate.TabIndex = 3;
            this.lblCellNumUpdate.Text = "Cellphone number:";
            // 
            // lblSurnameUpdate
            // 
            this.lblSurnameUpdate.AutoSize = true;
            this.lblSurnameUpdate.Location = new System.Drawing.Point(271, 132);
            this.lblSurnameUpdate.Name = "lblSurnameUpdate";
            this.lblSurnameUpdate.Size = new System.Drawing.Size(52, 13);
            this.lblSurnameUpdate.TabIndex = 2;
            this.lblSurnameUpdate.Text = "Surname:";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(271, 92);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(38, 13);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name:";
            // 
            // lblEmployeeIDUpdate
            // 
            this.lblEmployeeIDUpdate.AutoSize = true;
            this.lblEmployeeIDUpdate.Location = new System.Drawing.Point(271, 49);
            this.lblEmployeeIDUpdate.Name = "lblEmployeeIDUpdate";
            this.lblEmployeeIDUpdate.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeIDUpdate.TabIndex = 0;
            this.lblEmployeeIDUpdate.Text = "Employee ID:";
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.label3);
            this.tabPageDelete.Controls.Add(this.btnDelete);
            this.tabPageDelete.Controls.Add(this.cmbEmployeeIDDelete);
            this.tabPageDelete.Controls.Add(this.lblEmployeeIDDelete);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 22);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(794, 425);
            this.tabPageDelete.TabIndex = 2;
            this.tabPageDelete.Text = "Delete";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Delete an employee";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 41);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cmbEmployeeIDDelete
            // 
            this.cmbEmployeeIDDelete.FormattingEnabled = true;
            this.cmbEmployeeIDDelete.Location = new System.Drawing.Point(389, 62);
            this.cmbEmployeeIDDelete.Name = "cmbEmployeeIDDelete";
            this.cmbEmployeeIDDelete.Size = new System.Drawing.Size(121, 21);
            this.cmbEmployeeIDDelete.TabIndex = 1;
            // 
            // lblEmployeeIDDelete
            // 
            this.lblEmployeeIDDelete.AutoSize = true;
            this.lblEmployeeIDDelete.Location = new System.Drawing.Point(225, 65);
            this.lblEmployeeIDDelete.Name = "lblEmployeeIDDelete";
            this.lblEmployeeIDDelete.Size = new System.Drawing.Size(114, 13);
            this.lblEmployeeIDDelete.TabIndex = 0;
            this.lblEmployeeIDDelete.Text = "Employee ID to delete:";
            // 
            // tabPageView
            // 
            this.tabPageView.Controls.Add(this.dgvView);
            this.tabPageView.Location = new System.Drawing.Point(4, 22);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageView.Size = new System.Drawing.Size(794, 425);
            this.tabPageView.TabIndex = 3;
            this.tabPageView.Text = "View All Employees";
            this.tabPageView.UseVisualStyleBackColor = true;
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(-4, 0);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(781, 419);
            this.dgvView.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(368, 288);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(160, 40);
            this.btnDashboard.TabIndex = 15;
            this.btnDashboard.Text = "Back to dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // frmMaintainEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMaintainEmployees);
            this.Name = "frmMaintainEmployees";
            this.Text = "frmEmployees";
            this.tabControlMaintainEmployees.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            this.tabPageView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMaintainEmployees;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbEmployeeIDDelete;
        private System.Windows.Forms.Label lblEmployeeIDDelete;
        private System.Windows.Forms.TabPage tabPageView;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Button btnDashboard;
    }
}