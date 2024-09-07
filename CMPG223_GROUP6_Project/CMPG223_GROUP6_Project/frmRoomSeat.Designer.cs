namespace CMPG223_GROUP6_Project
{
    partial class frmRoomSeat
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.lblHeadingMovieRoom = new System.Windows.Forms.Label();
            this.lblHeadingSeatNum = new System.Windows.Forms.Label();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.cbMovieRoom = new System.Windows.Forms.ComboBox();
            this.cbSeatNumber = new System.Windows.Forms.ComboBox();
            this.dgwDisplayRoomSeats = new System.Windows.Forms.DataGridView();
            this.rbAction = new System.Windows.Forms.GroupBox();
            this.gbSeatInfo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDisplayRoomSeats)).BeginInit();
            this.rbAction.SuspendLayout();
            this.gbSeatInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Seat Management";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(12, 312);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(49, 20);
            this.lblError.TabIndex = 1;
            this.lblError.Text = " Error";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(12, 258);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(296, 36);
            this.btnAction.TabIndex = 2;
            this.btnAction.Text = "X";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lblHeadingMovieRoom
            // 
            this.lblHeadingMovieRoom.AutoSize = true;
            this.lblHeadingMovieRoom.Location = new System.Drawing.Point(6, 31);
            this.lblHeadingMovieRoom.Name = "lblHeadingMovieRoom";
            this.lblHeadingMovieRoom.Size = new System.Drawing.Size(87, 16);
            this.lblHeadingMovieRoom.TabIndex = 3;
            this.lblHeadingMovieRoom.Text = "Movie Room:";
            // 
            // lblHeadingSeatNum
            // 
            this.lblHeadingSeatNum.AutoSize = true;
            this.lblHeadingSeatNum.Location = new System.Drawing.Point(6, 89);
            this.lblHeadingSeatNum.Name = "lblHeadingSeatNum";
            this.lblHeadingSeatNum.Size = new System.Drawing.Size(89, 16);
            this.lblHeadingSeatNum.TabIndex = 4;
            this.lblHeadingSeatNum.Text = "Seat Number:";
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(6, 21);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(53, 20);
            this.rbAdd.TabIndex = 5;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.rbDelete_CheckedChanged);
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Location = new System.Drawing.Point(222, 21);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(68, 20);
            this.rbDelete.TabIndex = 6;
            this.rbDelete.TabStop = true;
            this.rbDelete.Text = "Delete";
            this.rbDelete.UseVisualStyleBackColor = true;
            this.rbDelete.CheckedChanged += new System.EventHandler(this.rbDelete_CheckedChanged);
            // 
            // cbMovieRoom
            // 
            this.cbMovieRoom.FormattingEnabled = true;
            this.cbMovieRoom.Location = new System.Drawing.Point(124, 31);
            this.cbMovieRoom.Name = "cbMovieRoom";
            this.cbMovieRoom.Size = new System.Drawing.Size(163, 24);
            this.cbMovieRoom.TabIndex = 7;
            this.cbMovieRoom.SelectedIndexChanged += new System.EventHandler(this.cbMovieRoom_SelectedIndexChanged);
            // 
            // cbSeatNumber
            // 
            this.cbSeatNumber.FormattingEnabled = true;
            this.cbSeatNumber.Location = new System.Drawing.Point(124, 89);
            this.cbSeatNumber.Name = "cbSeatNumber";
            this.cbSeatNumber.Size = new System.Drawing.Size(163, 24);
            this.cbSeatNumber.TabIndex = 8;
            // 
            // dgwDisplayRoomSeats
            // 
            this.dgwDisplayRoomSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDisplayRoomSeats.Location = new System.Drawing.Point(323, 67);
            this.dgwDisplayRoomSeats.Name = "dgwDisplayRoomSeats";
            this.dgwDisplayRoomSeats.RowHeadersWidth = 51;
            this.dgwDisplayRoomSeats.RowTemplate.Height = 24;
            this.dgwDisplayRoomSeats.Size = new System.Drawing.Size(440, 227);
            this.dgwDisplayRoomSeats.TabIndex = 9;
            // 
            // rbAction
            // 
            this.rbAction.Controls.Add(this.rbAdd);
            this.rbAction.Controls.Add(this.rbDelete);
            this.rbAction.Location = new System.Drawing.Point(12, 66);
            this.rbAction.Name = "rbAction";
            this.rbAction.Size = new System.Drawing.Size(296, 51);
            this.rbAction.TabIndex = 10;
            this.rbAction.TabStop = false;
            this.rbAction.Text = "Action";
            // 
            // gbSeatInfo
            // 
            this.gbSeatInfo.Controls.Add(this.cbMovieRoom);
            this.gbSeatInfo.Controls.Add(this.lblHeadingMovieRoom);
            this.gbSeatInfo.Controls.Add(this.cbSeatNumber);
            this.gbSeatInfo.Controls.Add(this.lblHeadingSeatNum);
            this.gbSeatInfo.Location = new System.Drawing.Point(15, 123);
            this.gbSeatInfo.Name = "gbSeatInfo";
            this.gbSeatInfo.Size = new System.Drawing.Size(293, 129);
            this.gbSeatInfo.TabIndex = 11;
            this.gbSeatInfo.TabStop = false;
            this.gbSeatInfo.Text = "Seat Information";
            // 
            // frmRoomSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 343);
            this.Controls.Add(this.dgwDisplayRoomSeats);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbAction);
            this.Controls.Add(this.gbSeatInfo);
            this.Name = "frmRoomSeat";
            this.Text = "frmRoomSeat";
            this.Load += new System.EventHandler(this.frmRoomSeat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDisplayRoomSeats)).EndInit();
            this.rbAction.ResumeLayout(false);
            this.rbAction.PerformLayout();
            this.gbSeatInfo.ResumeLayout(false);
            this.gbSeatInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label lblHeadingMovieRoom;
        private System.Windows.Forms.Label lblHeadingSeatNum;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.ComboBox cbMovieRoom;
        private System.Windows.Forms.ComboBox cbSeatNumber;
        private System.Windows.Forms.DataGridView dgwDisplayRoomSeats;
        private System.Windows.Forms.GroupBox rbAction;
        private System.Windows.Forms.GroupBox gbSeatInfo;
    }
}