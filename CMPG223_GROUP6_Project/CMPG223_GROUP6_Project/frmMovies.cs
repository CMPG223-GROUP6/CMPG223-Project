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
        private const string ConnectionString = @"Data Source=DESKTOP-TSOKQI0\SQLEXPRESS;Initial Catalog=MoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private ErrorProvider errorProvider;

        public frmMovies()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Validate input for Movie Name, Description, and Price
            if (!ValidateInputs())
            {
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
                        command.Parameters.AddWithValue("@Price", decimal.Parse(textBoxPrice.Text));
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("A new movie was added!");

                    // Refresh movie list
                    ShowMovies();
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

            if (!ValidateInputs())
            {
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
                        command.Parameters.AddWithValue("@Price", decimal.Parse(textBoxPrice.Text));
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Movie updated successfully!");
                    ShowMovies(); // Refresh the DataGridView
                }
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
                    ShowMovies(); // Refresh DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear(); // Clear previous errors

            // Validate Movie Name
            if (string.IsNullOrWhiteSpace(textBoxMovieName.Text))
            {
                errorProvider.SetError(textBoxMovieName, "Movie name is required.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(textBoxMovieName, ""); // Clear error if valid
            }

            // Validate Movie Description
            if (string.IsNullOrWhiteSpace(textBoxMovieDescription.Text))
            {
                errorProvider.SetError(textBoxMovieDescription, "Movie description is required.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(textBoxMovieDescription, ""); // Clear error if valid
            }

            // Validate Price
            if (!decimal.TryParse(textBoxPrice.Text, out decimal price) || price < 0)
            {
                errorProvider.SetError(textBoxPrice, "Please enter a valid price.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(textBoxPrice, ""); // Clear error if valid
            }

            return isValid;
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

        private void textBoxMovieDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMovieName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMovies_Load(object sender, EventArgs e)
        {

        }
    }
}
