using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_GROUP6_Project
{
    public partial class frmSellTicket : Form
    {
        public frmSellTicket()
        {
            InitializeComponent();
        }

        //Global connection
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TSOKQI0\SQLEXPRESS;Initial Catalog=MoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private int frmLoadMB = 0;
        private int frmLoadMR = 0;
        SqlCommand command;
        SqlDataReader reader;
        public string fName;

        private void frmSellTicket_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                //Get timeslots
                command = new SqlCommand("Get_Timeslots", conn);
                command.CommandType = CommandType.StoredProcedure;

                //Display timeslots in drop down list
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                cmbTimeslot.DataSource = dt;
                cmbTimeslot.DisplayMember = "A_Time";

                //Get movies
                command = new SqlCommand("Get_Movies", conn);
                command.CommandType = CommandType.StoredProcedure;

                //Display movies in drop down list
                dt = new DataTable();
                dt.Load(command.ExecuteReader());
                cmbMovie.DataSource = dt;
                cmbMovie.DisplayMember = "Movie_Name";

                conn.Close();

                cmbTimeslot.SelectedIndex = -1;
                cmbMovie.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                frmLoadMB++;

                if (frmLoadMB > 3)
                {
                    //Get chosen movie
                    string sMovieName = cmbMovie.Text;
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    //Get rooms in which the movie is displayed
                    command = new SqlCommand("Get_Room_For_Movie", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Movie_Name", sMovieName);

                    //Display rooms in drop down list
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    cmbRoom.DataSource = dt;
                    cmbRoom.DisplayMember = "Room_Num";

                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                frmLoadMR++;

                if (frmLoadMR > 1)
                {
                    //Get chosen movie
                    int Room_Num = int.Parse(cmbRoom.Text);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    //Get rooms in which the movie is displayed
                    command = new SqlCommand("Get_Seats", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Room_Num", Room_Num);

                    //Display rooms in drop down list
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    cmbSeat.DataSource = dt;
                    cmbSeat.DisplayMember = "Seat_ID";

                    lblMovieSeats.Text = "Seats available for cinema room " + cmbRoom.Text;

                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Open Login form
            this.Close();
            frmLogin LoginForm = new frmLogin();
            LoginForm.Show();
        }
    }
}
