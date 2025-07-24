using MaintainEmployees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_GROUP6_Project
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        //Declare field variables
        public string fName;
        private bool wasButton = false;

        private void btnMaintainEmployees_Click(object sender, EventArgs e)
        {
            //Open maintain employee form
            wasButton = true;
            this.Close();
            frmMaintainEmployees maintainEmployeesForm = new frmMaintainEmployees();
            maintainEmployeesForm.Show();           
        }

        private void btnMaintainTimeslots_Click(object sender, EventArgs e)
        {
            //Open maintain timeslot form
            wasButton = true;
            this.Close();
            frmTimeSlot maintainTimeslotsForm = new frmTimeSlot();
            maintainTimeslotsForm.Show();           
        }

        private void btnMaintainMovies_Click(object sender, EventArgs e)
        {
            //Open maintain movies form
            wasButton = true;
            this.Close();
            frmMovies maintainMoviesForm = new frmMovies();
            maintainMoviesForm.Show();
        }

        private void btnMaintainMovieRooms_Click(object sender, EventArgs e)
        {
            //Open maintain movie rooms form
            wasButton = true;
            this.Close();
            frmMovieRoom maintainMovieRoomsForm = new frmMovieRoom();
            maintainMovieRoomsForm.Show();
        }

        private void btnRoomSeats_Click(object sender, EventArgs e)
        {
            //Open the room seat maintain form
            wasButton = true;
            this.Close();
            frmRoomSeat newFrmRoomSeat = new frmRoomSeat();
            newFrmRoomSeat.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            //Open request report form
            wasButton = true;
            this.Close();
            frmRequestReports requestReportForm = new frmRequestReports();
            requestReportForm.Show();            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Open Login form
            wasButton = true;
            this.Close();
            frmLogin LoginForm = new frmLogin();
            LoginForm.Show();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            //Welcome the administrator
            lblWelcome.Text = "Welcome " + fName + "!";
        }

        private void frmDashboard_Resize(object sender, EventArgs e)
        {                     
            //Resize the panel and the welcome label properly
            pnlDashboard.Location = new Point(this.Width / 2 - pnlDashboard.Width / 2, this.Height / 2 - pnlDashboard.Height / 2);
            if (this.Width > lblWelcome.Width)
                lblWelcome.Location = new Point(this.Width / 2 - lblWelcome.Width / 2, this.Height / 2 - pnlDashboard.Width / 2 - 60);
            else if (lblWelcome.Width > pnlDashboard.Width)
                lblWelcome.Location = new Point(0, this.Height / 2 - pnlDashboard.Height / 2 - 60);
        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!wasButton)
                Environment.Exit(1);
        }
    }
}