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
using System.Data.SqlClient;

namespace CMPG223_GROUP6_Project
{
    public partial class frmTimeSlot : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TSOKQI0\SQLEXPRESS;Initial Catalog=MoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand command;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataSet dataSet;
        public frmTimeSlot()
        {
            InitializeComponent();
        }

        private void showAdd()
        {
            try
            {
                con.Open();
                command = new SqlCommand("SHowTimeSlot", con);
                command.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void showDelete()
        {
            try
            {
                con.Open();
                command = new SqlCommand("SHowTimeSlot", con);
                command.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                dataGridView3.DataSource = dt;

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void showUpdate()
        {
            try
            {
                con.Open();
                command = new SqlCommand("SHowTimeSlot", con);
                command.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                dataGridView2.DataSource = dt;

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                command = new SqlCommand("Add_TimeSlot", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@A_Time", txtTimeslotAdd.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("A new timeslot has been added");



                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            showAdd();
            showUpdate();
            showDelete();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                command = new SqlCommand("update_TimeSlot", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Timeslot_ID", txtIdUpdate.Text);
                command.Parameters.AddWithValue("@A_Time", txtTimeslotUpdate.Text);

                adapter = new SqlDataAdapter(command);

                command.ExecuteNonQuery();
                command.Dispose();

                MessageBox.Show("The timeslot has been updated!");


                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            showAdd();
            showUpdate();
            showDelete();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                command = new SqlCommand("DeleteTimeSlot", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Timeslot_ID", txtIdDelete.Text);


                command.ExecuteNonQuery();


                MessageBox.Show("Timeslot deleted sucessfully!");


                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            showAdd();
            showUpdate();
            showDelete();
        }

        private void frmTimeSlot_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Open dashboard form
            this.Close();
            frmDashboard AdministratorDashboard = new frmDashboard();
            AdministratorDashboard.Show();
        }
    }
}

