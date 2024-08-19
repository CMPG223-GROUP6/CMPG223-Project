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
    public partial class frmMovies : Form
    {
        private const string ConnectionString = @"";

        public frmMovies()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(textBoxMovieName.Text) ||
                string.IsNullOrWhiteSpace(textBoxMovieDescription.Text) ||
                !decimal.TryParse(textBoxPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter valid movie details.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // Add new movie
                    using (SqlCommand command = new SqlCommand("InsertMovie", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Movie_Name", textBoxMovieName.Text);
                        command.Parameters.AddWithValue("@Movie_Description", textBoxMovieDescription.Text);
                        command.Parameters.AddWithValue("@Price", price);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("A new movie was added!");

                    // Show all movies
                    using (SqlCommand command = new SqlCommand("Show_Movies", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Display records in DataGridView
                        DataTable dt = new DataTable();
                        dt.Load(command.ExecuteReader());
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a movie from the list to update.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            int movieID = Convert.ToInt32(selectedRow.Cells["Movie_ID"].Value);

            if (string.IsNullOrWhiteSpace(textBoxMovieName.Text) ||
                string.IsNullOrWhiteSpace(textBoxMovieDescription.Text) ||
                !decimal.TryParse(textBoxPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter valid movie details.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("UpdateMovie", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Movie_ID", movieID);
                        command.Parameters.AddWithValue("@Movie_Name", textBoxMovieName.Text);
                        command.Parameters.AddWithValue("@Movie_Description", textBoxMovieDescription.Text);
                        command.Parameters.AddWithValue("@Price", price);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Movie updated successfully!");
                }

                ShowMovies(); // Refresh the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a movie from the list to delete.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            int movieID = Convert.ToInt32(selectedRow.Cells["Movie_ID"].Value);

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("DeleteMovie", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Movie_ID", movieID);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Movie deleted successfully!");
                }

                ShowMovies(); // Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ShowMovies()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("Show_Movies", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        DataTable dt = new DataTable();
                        dt.Load(command.ExecuteReader());
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
