namespace CMPG223_GROUP6_Project
{
    partial class frmSellTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellTicket));
            this.pnlInsert = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.lblSeat = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblTimeslot = new System.Windows.Forms.Label();
            this.cmbSeat = new System.Windows.Forms.ComboBox();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.cmbTimeslot = new System.Windows.Forms.ComboBox();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.dtgShowSeats = new System.Windows.Forms.DataGridView();
            this.lblMovieSeats = new System.Windows.Forms.Label();
            this.pnlInsert.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShowSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInsert
            // 
            this.pnlInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlInsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInsert.Controls.Add(this.btnLogout);
            this.pnlInsert.Controls.Add(this.lblRoom);
            this.pnlInsert.Controls.Add(this.cmbRoom);
            this.pnlInsert.Controls.Add(this.btnBookTicket);
            this.pnlInsert.Controls.Add(this.lblSeat);
            this.pnlInsert.Controls.Add(this.lblMovie);
            this.pnlInsert.Controls.Add(this.lblTimeslot);
            this.pnlInsert.Controls.Add(this.cmbSeat);
            this.pnlInsert.Controls.Add(this.cmbMovie);
            this.pnlInsert.Controls.Add(this.cmbTimeslot);
            this.pnlInsert.Location = new System.Drawing.Point(78, 58);
            this.pnlInsert.Name = "pnlInsert";
            this.pnlInsert.Size = new System.Drawing.Size(184, 384);
            this.pnlInsert.TabIndex = 23;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(8, 344);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 32);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoom.Location = new System.Drawing.Point(8, 152);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(56, 20);
            this.lblRoom.TabIndex = 29;
            this.lblRoom.Text = "Room";
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(8, 184);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(160, 28);
            this.cmbRoom.TabIndex = 28;
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.BackColor = System.Drawing.Color.Maroon;
            this.btnBookTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookTicket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBookTicket.Location = new System.Drawing.Point(8, 304);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(160, 32);
            this.btnBookTicket.TabIndex = 27;
            this.btnBookTicket.Text = "Book ticket";
            this.btnBookTicket.UseVisualStyleBackColor = false;
            this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click);
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSeat.Location = new System.Drawing.Point(8, 224);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(47, 20);
            this.lblSeat.TabIndex = 26;
            this.lblSeat.Text = "Seat";
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMovie.Location = new System.Drawing.Point(8, 80);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(55, 20);
            this.lblMovie.TabIndex = 25;
            this.lblMovie.Text = "Movie";
            // 
            // lblTimeslot
            // 
            this.lblTimeslot.AutoSize = true;
            this.lblTimeslot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeslot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimeslot.Location = new System.Drawing.Point(8, 8);
            this.lblTimeslot.Name = "lblTimeslot";
            this.lblTimeslot.Size = new System.Drawing.Size(76, 20);
            this.lblTimeslot.TabIndex = 24;
            this.lblTimeslot.Text = "Timeslot";
            // 
            // cmbSeat
            // 
            this.cmbSeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeat.FormattingEnabled = true;
            this.cmbSeat.Location = new System.Drawing.Point(8, 256);
            this.cmbSeat.Name = "cmbSeat";
            this.cmbSeat.Size = new System.Drawing.Size(160, 28);
            this.cmbSeat.TabIndex = 23;
            // 
            // cmbMovie
            // 
            this.cmbMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMovie.FormattingEnabled = true;
            this.cmbMovie.Location = new System.Drawing.Point(8, 112);
            this.cmbMovie.Name = "cmbMovie";
            this.cmbMovie.Size = new System.Drawing.Size(160, 28);
            this.cmbMovie.TabIndex = 22;
            this.cmbMovie.SelectedIndexChanged += new System.EventHandler(this.cmbMovie_SelectedIndexChanged);
            // 
            // cmbTimeslot
            // 
            this.cmbTimeslot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeslot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimeslot.FormattingEnabled = true;
            this.cmbTimeslot.Location = new System.Drawing.Point(8, 40);
            this.cmbTimeslot.Name = "cmbTimeslot";
            this.cmbTimeslot.Size = new System.Drawing.Size(160, 28);
            this.cmbTimeslot.TabIndex = 21;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDisplay.Controls.Add(this.dtgShowSeats);
            this.pnlDisplay.Controls.Add(this.lblMovieSeats);
            this.pnlDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDisplay.Location = new System.Drawing.Point(268, 58);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(472, 384);
            this.pnlDisplay.TabIndex = 24;
            // 
            // dtgShowSeats
            // 
            this.dtgShowSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgShowSeats.Location = new System.Drawing.Point(12, 40);
            this.dtgShowSeats.Name = "dtgShowSeats";
            this.dtgShowSeats.Size = new System.Drawing.Size(440, 328);
            this.dtgShowSeats.TabIndex = 12;
            // 
            // lblMovieSeats
            // 
            this.lblMovieSeats.AutoSize = true;
            this.lblMovieSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieSeats.Location = new System.Drawing.Point(95, 8);
            this.lblMovieSeats.Name = "lblMovieSeats";
            this.lblMovieSeats.Size = new System.Drawing.Size(265, 20);
            this.lblMovieSeats.TabIndex = 11;
            this.lblMovieSeats.Text = "Seats available for cinema room";
            // 
            // frmSellTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 496);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.pnlInsert);
            this.DoubleBuffered = true;
            this.Name = "frmSellTicket";
            this.Text = "Sell a ticket form";
            this.Load += new System.EventHandler(this.frmSellTicket_Load);
            this.pnlInsert.ResumeLayout(false);
            this.pnlInsert.PerformLayout();
            this.pnlDisplay.ResumeLayout(false);
            this.pnlDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShowSeats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInsert;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblTimeslot;
        private System.Windows.Forms.ComboBox cmbSeat;
        private System.Windows.Forms.ComboBox cmbMovie;
        private System.Windows.Forms.ComboBox cmbTimeslot;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.DataGridView dtgShowSeats;
        private System.Windows.Forms.Label lblMovieSeats;
        private System.Windows.Forms.Button btnLogout;
    }
}

