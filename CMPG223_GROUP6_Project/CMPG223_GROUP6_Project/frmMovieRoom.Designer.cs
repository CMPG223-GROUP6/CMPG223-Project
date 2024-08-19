
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
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbHeading = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(172, 439);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 17);
            this.lbStatus.TabIndex = 19;
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.Location = new System.Drawing.Point(181, -6);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(448, 45);
            this.lbHeading.TabIndex = 18;
            this.lbHeading.Text = "Movie Rooms Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRoomID);
            this.groupBox1.Controls.Add(this.lbSeats);
            this.groupBox1.Controls.Add(this.lbNumber);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.txtNumSeats);
            this.groupBox1.Controls.Add(this.txtRoomNum);
            this.groupBox1.Controls.Add(this.txtMovieID);
            this.groupBox1.Controls.Add(this.txtRoomID);
            this.groupBox1.Location = new System.Drawing.Point(273, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 156);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Details";
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.Location = new System.Drawing.Point(7, 120);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(62, 17);
            this.lbRoomID.TabIndex = 7;
            this.lbRoomID.Text = "Room ID";
            // 
            // lbSeats
            // 
            this.lbSeats.AutoSize = true;
            this.lbSeats.Location = new System.Drawing.Point(7, 89);
            this.lbSeats.Name = "lbSeats";
            this.lbSeats.Size = new System.Drawing.Size(114, 17);
            this.lbSeats.TabIndex = 6;
            this.lbSeats.Text = "Number of Seats";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Location = new System.Drawing.Point(7, 59);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(99, 17);
            this.lbNumber.TabIndex = 5;
            this.lbNumber.Text = "Room Number";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(7, 31);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(62, 17);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "Movie ID";
            // 
            // txtNumSeats
            // 
            this.txtNumSeats.Location = new System.Drawing.Point(127, 89);
            this.txtNumSeats.Name = "txtNumSeats";
            this.txtNumSeats.Size = new System.Drawing.Size(101, 22);
            this.txtNumSeats.TabIndex = 1;
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Location = new System.Drawing.Point(127, 59);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(100, 22);
            this.txtRoomNum.TabIndex = 2;
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(127, 28);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(100, 22);
            this.txtMovieID.TabIndex = 3;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(127, 120);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(100, 22);
            this.txtRoomID.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(451, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(319, 236);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(414, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(513, 236);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 13;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(226, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmMovieRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbHeading);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmMovieRoom";
            this.Text = "frmMovieRoom";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}