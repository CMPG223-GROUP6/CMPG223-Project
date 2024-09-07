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
    public partial class frmRoomSeat : Form
    {
        SqlConnection con = new SqlConnection(@"Server=.\SQLEXPRESS;Database=DreamflixDB;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        public frmRoomSeat()
        {
            InitializeComponent();
        }

        private void frmRoomSeat_Load(object sender, EventArgs e)
        {
            displayRoomSeats();
            LoadMovieRoomsComboBox();
            btnAction.Visible = false;
            gbSeatInfo.Visible = false;
            resetInputs();
        }

        public void deleteSeat()
        {
            // Validating row is selected to delete.
            if (dgwDisplayRoomSeats.CurrentRow == null)
            {
                resetInputs();
                lblError.Text = "Please select an the row you wish to be deleted.";
                return;
            }

            var selectedRow = dgwDisplayRoomSeats.CurrentRow;
            int seatID = Convert.ToInt32(selectedRow.Cells["Seat_ID"].Value);

            try
            {

                // Open the connection if it's not already open.
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // Deleting a room seat (switching Is_Active = false).
                using (SqlCommand command = new SqlCommand("DeleteRoomSeat", con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Seat_ID", seatID);
                    command.ExecuteNonQuery();
                }

                displayRoomSeats();
                MessageBox.Show("Movie deleted successfully!", "Success Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            finally
            {
                con.Close();
                resetInputs();
            }
        }

        public void addSeat()
        {
            //valadating input form the combo boxes.
            if (cbMovieRoom.SelectedIndex == -1 || cbSeatNumber.SelectedIndex == -1)
            {
                resetInputs();
                lblError.Text = "Please select valid room seat details from the list provided.";
                return;
            }
            try
            {
                // Open the connection if it's not already open.
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // Add new room seat record.
                using (SqlCommand command = new SqlCommand("AddRoomSeat", con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Room_ID", Convert.ToInt32(cbMovieRoom.SelectedValue));
                    command.Parameters.AddWithValue("@Seat_Num", Convert.ToInt32(cbSeatNumber.SelectedItem));
                    command.ExecuteNonQuery();
                }

                displayRoomSeats();
                MessageBox.Show("You have successfully added an entry into the room seats.", "Success Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            finally
            {
                con.Close();
                resetInputs();
            }
        }

        public void displayRoomSeats()
        {
            try
            {
                // Open the connection if it's not already open.
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string sql = @"SELECT [Seat_ID], [Room_ID], [Seat_Num] FROM ROOM_SEAT WHERE [Is_Active] = 1";

                cmd = new SqlCommand(sql, con);
                ds = new DataSet();
                adapter = new SqlDataAdapter();

                // Filling dataset with resluts from sql query.
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "ROOM_SEAT");

                // Displaying dataset.
                dgwDisplayRoomSeats.DataMember = "ROOM_SEAT";
                dgwDisplayRoomSeats.DataSource = ds;

                // Renameing column names.
                dgwDisplayRoomSeats.Columns["Seat_ID"].HeaderText = "Seat ID";
                dgwDisplayRoomSeats.Columns["Room_ID"].HeaderText = "Room Number";
                dgwDisplayRoomSeats.Columns["Seat_Num"].HeaderText = "Seat Number";

            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
        public void resetInputs()
        {
            cbMovieRoom.Text = string.Empty;
            cbMovieRoom.SelectedIndex = -1;

            cbSeatNumber.Text = string.Empty;
            cbSeatNumber.Items.Clear();
            cbSeatNumber.SelectedIndex = -1;

            lblError.Text = string.Empty;
            dgwDisplayRoomSeats.ClearSelection();

        }

        public void LoadMovieRoomsComboBox()
        {
            try
            {
                // Open the connection if it's not already open.
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // Query to get existing movie rooms.
                string sql = "SELECT Room_ID FROM MOVIE_ROOM";

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();

                // Fill the DataTable with the query result.    
                adapter.Fill(dt);

                // Bind the DataTable to the combobox.
                cbMovieRoom.DisplayMember = "Room_ID";
                cbMovieRoom.ValueMember = "Room_ID";
                cbMovieRoom.DataSource = dt;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            finally
            {
                con.Close();
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (rbAdd.Checked == true)
            {
                addSeat();
                cbSeatNumber.Text = string.Empty;
                rbAdd.Checked = false;
                btnAction.Visible = false;
            }
            else if (rbDelete.Checked == true)
            {
                deleteSeat();
                rbDelete.Checked = false;
                btnAction.Visible = false;
            }
        }

        private void cbMovieRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbAdd.Checked == true)
            {
                int numSeats = 0;
                cbSeatNumber.Items.Clear();

                try
                {
                    // Open the connection if it's not already open.
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    using (SqlCommand command = new SqlCommand("GetNumSeatsByMovieID", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add the Movie_ID parameter.
                        command.Parameters.AddWithValue("@Room_ID", cbMovieRoom.SelectedValue);

                        // Execute the command and read the number of seats.
                        object totalNumSeats = command.ExecuteScalar();

                        // Reading max number of seat from the database.
                        numSeats = Convert.ToInt32(totalNumSeats);

                        for (int i = 1; i <= numSeats; i++)
                        {
                            using (SqlCommand cmd = new SqlCommand("GetSeatByRoomIDAndSeatNum", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@Room_ID", cbMovieRoom.SelectedValue);
                                cmd.Parameters.AddWithValue("@Seat_Num", i);

                                // Execute the command and check if any seat number is returned.
                                object seatResult = cmd.ExecuteScalar();

                                // If seatResult is null, it means the seat does not exist and it can be added to the sbSeatNumber as available seat.
                                if (seatResult == null)
                                {
                                    cbSeatNumber.Items.Add(i);
                                }
                            }
                        }


                    }
                }
                catch (Exception ex)
                {
                    lblError.Text = ex.Message;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdd.Checked == true)
            {
                btnAction.Visible = true;
                btnAction.Text = "Add";

                gbSeatInfo.Visible = true;

                resetInputs();
            }
            else if (rbDelete.Checked == true)
            {
                btnAction.Visible = true;
                btnAction.Text = "Delete";

                gbSeatInfo.Visible = false;

                resetInputs();
            }
            else
            {
                gbSeatInfo.Visible = false;
            }
        }
    }
}
