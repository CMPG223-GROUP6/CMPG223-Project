
namespace CMPG223_GROUP6_Project
{
    partial class frmMovieRoom
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
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbHeading = new System.Windows.Forms.Label();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.lbSeats = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.txtNumSeats = new System.Windows.Forms.TextBox();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMakeChanges = new System.Windows.Forms.Button();
            this.cmbMovieID = new System.Windows.Forms.ComboBox();
            this.cmbRoomID = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(129, 357);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 13);
            this.lbStatus.TabIndex = 19;
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.Location = new System.Drawing.Point(105, 9);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(371, 37);
            this.lbHeading.TabIndex = 18;
            this.lbHeading.Text = "Movie Rooms Management";
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.Location = new System.Drawing.Point(110, 363);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(49, 13);
            this.lbRoomID.TabIndex = 7;
            this.lbRoomID.Text = "Room ID";
            // 
            // lbSeats
            // 
            this.lbSeats.AutoSize = true;
            this.lbSeats.Location = new System.Drawing.Point(110, 335);
            this.lbSeats.Name = "lbSeats";
            this.lbSeats.Size = new System.Drawing.Size(86, 13);
            this.lbSeats.TabIndex = 6;
            this.lbSeats.Text = "Number of Seats";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Location = new System.Drawing.Point(110, 307);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(75, 13);
            this.lbNumber.TabIndex = 5;
            this.lbNumber.Text = "Room Number";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(110, 279);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(50, 13);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "Movie ID";
            // 
            // txtNumSeats
            // 
            this.txtNumSeats.Location = new System.Drawing.Point(246, 330);
            this.txtNumSeats.Name = "txtNumSeats";
            this.txtNumSeats.Size = new System.Drawing.Size(77, 20);
            this.txtNumSeats.TabIndex = 1;
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Location = new System.Drawing.Point(246, 302);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(101, 22);
            this.txtRoomNum.TabIndex = 2;
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(512, 274);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(76, 20);
            this.txtMovieID.TabIndex = 3;
            
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(512, 358);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(76, 20);
            this.txtRoomID.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(565, 191);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(28, 144);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 37);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(28, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(28, 58);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 39);
            this.btnShow.TabIndex = 13;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMakeChanges
            // 
            this.btnMakeChanges.Location = new System.Drawing.Point(367, 336);
            this.btnMakeChanges.Name = "btnMakeChanges";
            this.btnMakeChanges.Size = new System.Drawing.Size(91, 44);
            this.btnMakeChanges.TabIndex = 20;
            this.btnMakeChanges.Text = "Make Changes";
            this.btnMakeChanges.UseVisualStyleBackColor = true;
            this.btnMakeChanges.Click += new System.EventHandler(this.btnMakeChanges_Click);
            // 
            // cmbMovieID
            // 
            this.cmbMovieID.FormattingEnabled = true;
            this.cmbMovieID.Location = new System.Drawing.Point(246, 272);
            this.cmbMovieID.Name = "cmbMovieID";
            this.cmbMovieID.Size = new System.Drawing.Size(101, 24);
            this.cmbMovieID.TabIndex = 21;
            // 
            // cmbRoomID
            // 
            this.cmbRoomID.FormattingEnabled = true;
            this.cmbRoomID.Location = new System.Drawing.Point(246, 358);
            this.cmbRoomID.Name = "cmbRoomID";
            this.cmbRoomID.Size = new System.Drawing.Size(101, 24);
            this.cmbRoomID.TabIndex = 22;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMovieRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbRoomID);
            this.Controls.Add(this.cmbMovieID);
            this.Controls.Add(this.btnMakeChanges);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.txtNumSeats);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.txtRoomNum);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.lbSeats);
            this.Controls.Add(this.lbHeading);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMovieRoom";
            this.Text = "frmMovieRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.Label lbSeats;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtNumSeats;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMakeChanges;
        private System.Windows.Forms.ComboBox cmbMovieID;
        private System.Windows.Forms.ComboBox cmbRoomID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}