using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG223_GROUP6_Project
{
    public partial class frmMovieRoom : Form
    {
        // Connection string for LocalDB database
        string connectionString = @"";
        public frmMovieRoom()
        {
            InitializeComponent();
        }

        // Add a new movie room
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Add_MovieRoom", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Movie_ID", int.Parse(txtMovieID.Text));
                    command.Parameters.AddWithValue("@Room_Num", int.Parse(txtRoomNum.Text));
                    command.Parameters.AddWithValue("@Num_Seats", int.Parse(txtNumSeats.Text));

                    command.ExecuteNonQuery();
                    lbStatus.Text = "A new movie room was added successfully!";
                    lbStatus.ForeColor = System.Drawing.Color.Green;
                }
                catch (Exception ex)
                {
                    lbStatus.Text = "Error: " + ex.Message;
                    lbStatus.ForeColor = System.Drawing.Color.Red;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Delete_MovieRoom", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Room_ID", int.Parse(txtRoomID.Text));

                command.ExecuteNonQuery();
                MessageBox.Show("The movie room was deleted!");
                conn.Close();
            }
        }

        // Show all movie rooms in the DataGridView
        private void btnShow_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Show_MovieRooms", conn);
                    command.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    dataGridView1.DataSource = dt;

                    lbStatus.Text = "Movie rooms loaded successfully!";
                    lbStatus.ForeColor = System.Drawing.Color.Green;
                }
                catch (Exception ex)
                {
                    lbStatus.Text = "Error: " + ex.Message;
                    lbStatus.ForeColor = System.Drawing.Color.Red;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        // Update an existing movie room
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Update_MovieRoom", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Room_ID", int.Parse(txtRoomID.Text));
                command.Parameters.AddWithValue("@Movie_ID", int.Parse(txtMovieID.Text));
                command.Parameters.AddWithValue("@Room_Num", int.Parse(txtRoomNum.Text));
                command.Parameters.AddWithValue("@Num_Seats", int.Parse(txtNumSeats.Text));

                command.ExecuteNonQuery();
                MessageBox.Show("The movie room was updated!");
                conn.Close();
            }
        }
        //Handling DataGridView row selection to fill fields
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtRoomID.Text = row.Cells["Room_ID"].Value.ToString();
                txtMovieID.Text = row.Cells["Movie_ID"].Value.ToString();
                txtRoomNum.Text = row.Cells["Room_Num"].Value.ToString();
                txtNumSeats.Text = row.Cells["Num_Seats"].Value.ToString();
            }
        }
    }
}
