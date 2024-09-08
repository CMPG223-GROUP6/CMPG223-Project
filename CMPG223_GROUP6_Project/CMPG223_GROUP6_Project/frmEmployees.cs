using CMPG223_GROUP6_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MaintainEmployees
{
    public partial class frmMaintainEmployees : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=R_LAPTOP\SQLEXPRESS;Initial Catalog=MoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;

        public frmMaintainEmployees()
        {
            InitializeComponent();

        }
        private void frmMaintainEmployees_Load_1(object sender, EventArgs e)
        {
            viewAllEmployees();
        }

        private void tabPageAdd_Click(object sender, EventArgs e)
        {
        }

        public void viewAllEmployees()
        {
            try
            {
                // Open the connection if it's not already open.
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // Corrected SQL query (fixed the bracket for Is_Active column).
                string sql = @"SELECT [Employee_ID], [Is_Admin], [Employee_Name], [Employee_Surname], 
                              [Cellphone_Num], [Username], [Password] 
                       FROM EMPLOYEE 
                       WHERE [Is_Active] = 1"; // Corrected the closing bracket here

                cmd = new SqlCommand(sql, con);
                ds = new DataSet();
                adapter = new SqlDataAdapter();

                // Filling dataset with results from the SQL query.
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "EMPLOYEE");

                // Displaying dataset.
                dgwDisplayEmployee.DataMember = "EMPLOYEE";
                dgwDisplayEmployee.DataSource = ds;

                // Renaming column names.
                dgwDisplayEmployee.Columns["Employee_ID"].HeaderText = "Employee ID";
                dgwDisplayEmployee.Columns["Is_Admin"].HeaderText = "Admin";
                dgwDisplayEmployee.Columns["Employee_Name"].HeaderText = "First Name";
                dgwDisplayEmployee.Columns["Employee_Surname"].HeaderText = "Surname";
                dgwDisplayEmployee.Columns["Cellphone_Num"].HeaderText = "Cell Number";
                dgwDisplayEmployee.Columns["Username"].HeaderText = "Username"; // Corrected "Usernamer" to "Username"
                dgwDisplayEmployee.Columns["Password"].HeaderText = "Password";
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
            txtNameAdd.Text = string.Empty;
            txtSurnameAdd.Text = string.Empty;
            txtCellNumAdd.Text = string.Empty;
            txtUsernameAdd.Text = string.Empty;
            txtPasswordAdd.Text = string.Empty;
            chkIsAdminAdd.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z]+$";
            int isAdmin = 0;

            // Check if textbox name is empty or contains invalid characters
            if (string.IsNullOrEmpty(txtNameAdd.Text) || !Regex.IsMatch(txtNameAdd.Text, pattern))
            {
                lblError.Text = "Please enter a valid name (letters only).";
                return ;
            }

            // Check if text box surname is empty or contains invalid characters
            if (string.IsNullOrEmpty(txtSurnameAdd.Text) || !Regex.IsMatch(txtSurnameAdd.Text, pattern))
            {
                lblError.Text = "Please enter a valid surname (letters only).";
                return ;
            }

            if (txtCellNumAdd.TextLength != 10)
            {
                lblError.Text = "A valid cellpone number must contain 10 numbers.";
                return;
            }

            if (string.IsNullOrEmpty(txtCellNumAdd.Text) || !Regex.IsMatch(txtCellNumAdd.Text, pattern))
            {
                lblError.Text = "Enter a valid cellphone number.";
                return;
            }

            if (string.IsNullOrEmpty(txtUsernameAdd.Text))
            {
                lblError.Text = "Enter a valid username.";
                return;
            }

            if (string.IsNullOrEmpty(txtPasswordAdd.Text))
            {
                lblError.Text = "Enter a valid password.";
                return;
            }

            if (chkIsAdminAdd.Checked == true)
            {
                isAdmin = 1;
            }

            try
            {
                // Open the connection if it's not already open.
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // Add new room seat record.
                using (SqlCommand command = new SqlCommand("Add_Employee", con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Is_Admin", isAdmin);
                    command.Parameters.AddWithValue("@Employee_Name", txtNameAdd.Text);
                    command.Parameters.AddWithValue("@Employee_Surname", txtSurnameAdd.Text);
                    command.Parameters.AddWithValue("@Cellphone_Num", txtCellNumAdd.Text);
                    command.Parameters.AddWithValue("@Username", txtUsernameAdd.Text);
                    command.Parameters.AddWithValue("@Password", txtPasswordAdd.Text);
                    command.ExecuteNonQuery();
                }

                viewAllEmployees();
                MessageBox.Show("You have successfully added an new employee.", "Success Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


    }

}

        
    
