
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovieRoom));
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbHeading = new System.Windows.Forms.Label();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.lbSeats = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.txtNumSeats = new System.Windows.Forms.TextBox();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMakeChanges = new System.Windows.Forms.Button();
            this.cmbMovieID = new System.Windows.Forms.ComboBox();
            this.cmbRoomID = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.lbHeading.BackColor = System.Drawing.Color.Black;
            this.lbHeading.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbHeading.Location = new System.Drawing.Point(105, 9);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(371, 37);
            this.lbHeading.TabIndex = 18;
            this.lbHeading.Text = "Movie Rooms Management";
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.BackColor = System.Drawing.Color.Transparent;
            this.lbRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRoomID.Location = new System.Drawing.Point(110, 363);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(68, 16);
            this.lbRoomID.TabIndex = 7;
            this.lbRoomID.Text = "Room ID";
            // 
            // lbSeats
            // 
            this.lbSeats.AutoSize = true;
            this.lbSeats.BackColor = System.Drawing.Color.Transparent;
            this.lbSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSeats.Location = new System.Drawing.Point(110, 335);
            this.lbSeats.Name = "lbSeats";
            this.lbSeats.Size = new System.Drawing.Size(123, 16);
            this.lbSeats.TabIndex = 6;
            this.lbSeats.Text = "Number of Seats";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNumber.Location = new System.Drawing.Point(110, 307);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(107, 16);
            this.lbNumber.TabIndex = 5;
            this.lbNumber.Text = "Room Number";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbID.Location = new System.Drawing.Point(110, 279);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(69, 16);
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
            this.txtRoomNum.Size = new System.Drawing.Size(101, 20);
            this.txtRoomNum.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 191);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(28, 144);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 37);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(28, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShow.Location = new System.Drawing.Point(28, 58);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 39);
            this.btnShow.TabIndex = 13;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(28, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMakeChanges
            // 
            this.btnMakeChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMakeChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeChanges.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMakeChanges.Location = new System.Drawing.Point(367, 336);
            this.btnMakeChanges.Name = "btnMakeChanges";
            this.btnMakeChanges.Size = new System.Drawing.Size(125, 43);
            this.btnMakeChanges.TabIndex = 20;
            this.btnMakeChanges.Text = "Make Changes";
            this.btnMakeChanges.UseVisualStyleBackColor = false;
            this.btnMakeChanges.Click += new System.EventHandler(this.btnMakeChanges_Click);
            // 
            // cmbMovieID
            // 
            this.cmbMovieID.FormattingEnabled = true;
            this.cmbMovieID.Location = new System.Drawing.Point(246, 272);
            this.cmbMovieID.Name = "cmbMovieID";
            this.cmbMovieID.Size = new System.Drawing.Size(101, 21);
            this.cmbMovieID.TabIndex = 21;
            // 
            // cmbRoomID
            // 
            this.cmbRoomID.FormattingEnabled = true;
            this.cmbRoomID.Location = new System.Drawing.Point(246, 358);
            this.cmbRoomID.Name = "cmbRoomID";
            this.cmbRoomID.Size = new System.Drawing.Size(101, 21);
            this.cmbRoomID.TabIndex = 22;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(572, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 191);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmMovieRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbRoomID);
            this.Controls.Add(this.cmbMovieID);
            this.Controls.Add(this.btnMakeChanges);
            this.Controls.Add(this.txtNumSeats);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.txtRoomNum);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbSeats);
            this.Controls.Add(this.lbHeading);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMovieRoom";
            this.Text = "frmMovieRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMakeChanges;
        private System.Windows.Forms.ComboBox cmbMovieID;
        private System.Windows.Forms.ComboBox cmbRoomID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}