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
        string connectionString = @"Data Source=DESKTOP-TSOKQI0\SQLEXPRESS;Initial Catalog=MoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private bool isUpdating = false; // Track if the operation is an update or an add
        ToolTip toolTip;
        
        public frmMovieRoom()
        {
            InitializeComponent();

            // Initialize the ToolTip control
            toolTip = new ToolTip();

            // Set up the delays for the ToolTip
            toolTip.AutoPopDelay = 5000; // How long the tooltip stays visible
            toolTip.InitialDelay = 1000; // Delay before tooltip appears
            toolTip.ReshowDelay = 500;   // Delay before tooltip reappears
            toolTip.ShowAlways = true;   // Force the tooltip to show even if the form is not active

            // Assign ToolTips to controls
            toolTip.SetToolTip(this.cmbMovieID, "Select the Movie ID from the list.");
            toolTip.SetToolTip(this.cmbRoomID, "Select the Room ID from the list.");
            toolTip.SetToolTip(this.txtRoomNum, "Enter the room number.");
            toolTip.SetToolTip(this.txtNumSeats, "This is a read-only field.");
            toolTip.SetToolTip(this.btnAdd, "Click to add a new movie room.");
            toolTip.SetToolTip(this.btnUpdate, "Click to update the selected movie room.");
            toolTip.SetToolTip(this.btnDelete, "Click to delete the selected movie room.");
            toolTip.SetToolTip(this.btnShow, "Click to display all movie rooms.");
            toolTip.SetToolTip(this.btnMakeChanges, "Click to apply the changes.");

            // Hide the Room Details controls and MakeChanges button initially
            ToggleRoomDetailsControls(false, false);

            // Populate ComboBoxes when the form loads
            PopulateMovieComboBox();
            PopulateRoomComboBox();
        }
        private void PopulateMovieComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Movie_ID FROM dbo.MOVIE", conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbMovieID.Items.Add(reader["Movie_ID"].ToString());
                }

                conn.Close();
            }
        }

        private void PopulateRoomComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Room_ID FROM dbo.MOVIE_ROOM", conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbRoomID.Items.Add(reader["Room_ID"].ToString());
                }

                conn.Close();
            }
        }

        private void ToggleRoomDetailsControls(bool isVisible, bool showRoomID = false)
        {
            lbID.Visible = isVisible;
            cmbMovieID.Visible = isVisible;
            lbNumber.Visible = isVisible;
            txtRoomNum.Visible = isVisible;
            lbSeats.Visible = isVisible;
            txtNumSeats.Visible = isVisible;
            btnMakeChanges.Visible = isVisible;

            lbRoomID.Visible = showRoomID;
            cmbRoomID.Visible = showRoomID;
        }

        // Add a new movie room
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isUpdating = false; // add operation
            ToggleRoomDetailsControls(true, false);

            // Clear fields for new input
            cmbRoomID.SelectedIndex = -1;
            cmbMovieID.SelectedIndex = -1;
            txtRoomNum.Clear();
            txtNumSeats.Clear();

            // Set txtNumSeats to editable since it's an add operation
            txtNumSeats.ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                errorProvider1.SetError(dataGridView1, "Please select a row to hide.");
                return;
            }

            errorProvider1.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Delete_MovieRoom", conn);  // Stored procedure to set isActive = 0
                command.CommandType = CommandType.StoredProcedure;

                int roomId = int.Parse(dataGridView1.SelectedRows[0].Cells["Room_ID"].Value.ToString());
                command.Parameters.AddWithValue("@Room_ID", roomId);

                command.ExecuteNonQuery();

                // Refresh the data grid to hide inactive records
                btnShow_Click(sender, e);

                lbStatus.Text = "The movie room was hidden successfully!";
                lbStatus.ForeColor = Color.Green;

                conn.Close();
            }
            
            ToggleRoomDetailsControls(false);
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


        //Handling DataGridView row selection to fill fields
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1) // Ensure a valid row is selected and not the empty new row
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                cmbRoomID.Text = row.Cells["Room_ID"].Value.ToString();
                cmbMovieID.Text = row.Cells["Movie_ID"].Value.ToString();
                txtRoomNum.Text = row.Cells["Room_Num"].Value.ToString();
                txtNumSeats.Text = row.Cells["Num_Seats"].Value.ToString();

                ToggleRoomDetailsControls(true);
            }
        }

        private void btnMakeChanges_Click(object sender, EventArgs e)
        {
            // Validate if the fields are filled
            if (string.IsNullOrEmpty(cmbMovieID.Text))
            {
                errorProvider1.SetError(cmbMovieID, "Please select a Movie ID.");
                return;
            }
            else
            {
                errorProvider1.SetError(cmbMovieID, string.Empty);
            }

            if (string.IsNullOrEmpty(txtRoomNum.Text) || !int.TryParse(txtRoomNum.Text, out int roomNum))
            {
                errorProvider1.SetError(txtRoomNum, "Please enter a valid room number.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtRoomNum, string.Empty);
            }

            if (string.IsNullOrEmpty(txtNumSeats.Text) || !int.TryParse(txtNumSeats.Text, out int numSeats))
            {
                errorProvider1.SetError(txtNumSeats, "Please enter a valid number of seats.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNumSeats, string.Empty);
            }

            // Automatically set isActive
            bool isActive = true;  // All new and updated movie rooms should be active by default

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // If it's an add operation, check for duplicates
                if (!isUpdating)
                {
                    SqlCommand checkCommand = new SqlCommand("SELECT COUNT(1) FROM MOVIE_ROOM WHERE Movie_ID = @Movie_ID AND Room_Num = @Room_Num AND IsActive = 1", conn);
                    checkCommand.Parameters.AddWithValue("@Movie_ID", int.Parse(cmbMovieID.Text));
                    checkCommand.Parameters.AddWithValue("@Room_Num", roomNum);

                    int roomExists = (int)checkCommand.ExecuteScalar();

                    if (roomExists > 0)
                    {
                        // Duplicate found, display error message
                        lbStatus.Text = "This movie room already exists!";
                        lbStatus.ForeColor = Color.Red;
                        conn.Close();
                        return;  // Exit, don't proceed with the insert
                    }
                }

                SqlCommand command;

                // If it's an update operation
                if (isUpdating)
                {
                    // Update existing movie room
                    command = new SqlCommand("Update_MovieRoom", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Room_ID", int.Parse(cmbRoomID.Text));  // Include Room ID for the update
                }
                else
                {
                    // Add a new movie room
                    command = new SqlCommand("Add_MovieRoom", conn);
                    command.CommandType = CommandType.StoredProcedure;
                }

                // Add the shared parameters for both Add and Update operations
                command.Parameters.AddWithValue("@Movie_ID", int.Parse(cmbMovieID.Text));
                command.Parameters.AddWithValue("@Room_Num", roomNum);
                command.Parameters.AddWithValue("@Num_Seats", numSeats);
                command.Parameters.AddWithValue("@IsActive", isActive);  // Set the room as active

                command.ExecuteNonQuery();

                // Refresh the data grid
                btnShow_Click(sender, e);

                // Display success message
                lbStatus.Text = isUpdating ? "The movie room was updated successfully!" : "A new movie room was added successfully!";
                lbStatus.ForeColor = Color.Green;

                conn.Close();
            }

            // Hide room details after the add/update operation
            ToggleRoomDetailsControls(false);
        }
        private bool ValidateRoomDetails()
        {
            return !string.IsNullOrEmpty(cmbMovieID.SelectedItem?.ToString()) &&
                   !string.IsNullOrEmpty(txtRoomNum.Text) &&
                   !string.IsNullOrEmpty(txtNumSeats.Text);
        }

        private void ResetRoomDetailsControls()
        {
            cmbMovieID.SelectedIndex = -1;
            txtRoomNum.Clear();
            txtNumSeats.Clear();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Open dashboard form
            this.Close();
            frmDashboard AdministratorDashboard = new frmDashboard();
            AdministratorDashboard.Show();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                errorProvider1.SetError(dataGridView1, "Please select a row to update.");
                return;
            }

            errorProvider1.Clear();

            isUpdating = true;  // Set the mode to "update"
            ToggleRoomDetailsControls(true, true);  // Show input fields for update
            txtNumSeats.ReadOnly = true;  // Make number of seats read-only for updates

            // Fill the input fields with the selected room's data
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            cmbRoomID.Text = selectedRow.Cells["Room_ID"].Value.ToString();
            cmbMovieID.Text = selectedRow.Cells["Movie_ID"].Value.ToString();
            txtRoomNum.Text = selectedRow.Cells["Room_Num"].Value.ToString();
            txtNumSeats.Text = selectedRow.Cells["Num_Seats"].Value.ToString();
        }
    }
}
