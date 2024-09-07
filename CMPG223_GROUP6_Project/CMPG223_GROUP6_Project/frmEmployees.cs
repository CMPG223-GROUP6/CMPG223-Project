using CMPG223_GROUP6_Project;
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

namespace MaintainEmployees
{
    public partial class frmMaintainEmployees : Form
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename= '|DataDirectory|TestDB.mdf'; Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand comm;
        private DataSet ds;
        private SqlDataAdapter adap;

        public frmMaintainEmployees()
        {
            InitializeComponent();
            conn = new SqlConnection(conString);
        }

        private void showEmployees()
        {
            conn.Open();
            //Sql run stored procedure to display employees.
            comm = new SqlCommand("Show_Employees", conn);
            comm.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            dt.Load(comm.ExecuteReader());
            dgvView.DataSource = dt;

            conn.Close();
        }

        private void populateComboBox()
        {
            string sql;

            //Populates the combobox with employee IDs.
            DataSet ds = new DataSet();
            sql = "SELECT Employee_ID FROM EMPLOYEE";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(ds, "EMPLOYEE");

            cmbEmployeeIDDelete.DisplayMember = "Employee_ID";
            cmbEmployeeIDDelete.ValueMember = "Employee_ID";
            cmbEmployeeIDDelete.DataSource = ds.Tables["EMPLOYEE"];

            cmbEmployeeIDUpdate.DisplayMember = "Employee_ID";
            cmbEmployeeIDUpdate.ValueMember = "Employee_ID";
            cmbEmployeeIDUpdate.DataSource = ds.Tables["EMPLOYEE"];
        }

        private void frmMaintainEmployees_Load(object sender, EventArgs e)
        {
            //Displays the employees and populates the combobox with the employee IDs when the form loads.
            populateComboBox();
            showEmployees();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name, surname, cellNum, username, password;
            bool isError = false;

            //Gets the user's input.
            name = txtNameAdd.Text;
            surname = txtSurnameAdd.Text;
            cellNum = txtCellNumAdd.Text;
            username = txtUsernameAdd.Text;
            password = txtPasswordAdd.Text;

            //Validates the input.
            if (name == "")
            {
                MessageBox.Show("Enter a name.");
                isError = true;
            }
            else if (surname == "")
            {
                MessageBox.Show("Enter a surname.");
                isError = true;
            }
            else if (cellNum == "")
            {
                MessageBox.Show("Enter a cell number.");
                isError = true;
            }
            else if (username == "")
            {
                MessageBox.Show("Enter a username.");
                isError = true;
            }
            else if (password == "")
            {
                MessageBox.Show("Enter a password.");
                isError = true;
            }

            if (isError == false)
            {
                conn.Open();

                //SQL run stored procedure to add employees.
                comm = new SqlCommand("Add_Employee", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Is_Admin", chkIsAdminAdd.Checked);
                comm.Parameters.AddWithValue("@Is_Active", chkActiveAdd.Checked);
                comm.Parameters.AddWithValue("@Employee_Name", name);
                comm.Parameters.AddWithValue("@Employee_Surname", surname);
                comm.Parameters.AddWithValue("@Cellphone_Num", cellNum);
                comm.Parameters.AddWithValue("@Username", username);
                comm.Parameters.AddWithValue("@Password", password);
                comm.ExecuteNonQuery();

                //Displays confirmation message to the user.
                MessageBox.Show("A new employee was added!");

                conn.Close();

                //Displays the employees and populates the combobox with the employee IDs.
                showEmployees();
                populateComboBox();

                //Clears input.
                txtNameAdd.Text = "";
                txtSurnameAdd.Text = "";
                txtUsernameAdd.Text = "";
                txtPasswordAdd.Text = "";
                txtCellNumAdd.Text = "";
                chkActiveAdd.Checked = false;
                chkIsAdminAdd.Checked = false;

                //Sets focus to the first component.
                txtNameAdd.Focus();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Open dashboard form.
            this.Close();
            frmDashboard AdministratorDashboard = new frmDashboard();
            AdministratorDashboard.Show();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string name, surname, cellNum, username, password;
            bool isError = false;
            int employeeID;

            //Gets the user's input.
            name = txtNameUpdate.Text;
            surname = txtSurnameUpdate.Text;
            employeeID = int.Parse(cmbEmployeeIDUpdate.SelectedValue.ToString());
            cellNum = txtCellNumUpdate.Text;
            username = txtUsernameUpdate.Text;
            password = txtPasswordUpdate.Text;

            //Validates the input.
            if (name == "")
            {
                MessageBox.Show("Enter a name.");
                isError = true;
            }
            else if (surname == "")
            {
                MessageBox.Show("Enter a surname.");
                isError = true;
            }
            else if (cellNum == "")
            {
                MessageBox.Show("Enter a cell number.");
                isError = true;
            }
            else if (username == "")
            {
                MessageBox.Show("Enter a username.");
                isError = true;
            }
            else if (password == "")
            {
                MessageBox.Show("Enter a password.");
                isError = true;
            }


            if (isError == false)
            {
                conn.Open();

                //SQL run stored procedure to update the selected employee.
                comm = new SqlCommand("Update_Employee", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Is_Admin", chkIsAdminUpdate.Checked);
                comm.Parameters.AddWithValue("@Is_Active", chkIsActiveUpdate.Checked);
                comm.Parameters.AddWithValue("@Employee_Name", name);
                comm.Parameters.AddWithValue("@Employee_Surname", surname);
                comm.Parameters.AddWithValue("@Cellphone_Num", cellNum);
                comm.Parameters.AddWithValue("@Username", username);
                comm.Parameters.AddWithValue("@Password", password);
                comm.Parameters.AddWithValue("@Employee_ID", employeeID);
                comm.ExecuteNonQuery();

                MessageBox.Show("Employee " + employeeID + " " + name + " " + surname + " has been successfully updated!");

                conn.Close();

                //Displays the employees.
                showEmployees();

                //Clears the input.
                txtNameUpdate.Text = "";
                txtSurnameUpdate.Text = "";
                txtUsernameUpdate.Text = "";
                txtPasswordUpdate.Text = "";
                txtCellNumUpdate.Text = "";
                chkIsActiveUpdate.Checked = false;
                chkIsAdminUpdate.Checked = false;

                //Sets the focus to the first component.
                cmbEmployeeIDUpdate.Focus();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            //Gets the user's input.
            int employeeID = int.Parse(cmbEmployeeIDDelete.SelectedValue.ToString());

            conn.Open();

            //SQL run stored procedure to delete the selected employee.
            comm = new SqlCommand("Delete_Employee", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@Employee_ID", employeeID);
            comm.ExecuteNonQuery();

            MessageBox.Show("Employee " + employeeID + " was deleted!");

            conn.Close();

            //Displays the employees and populates the combobox with the employee IDs.
            showEmployees();
            populateComboBox();

            //Sets the focus to the first component.
            cmbEmployeeIDDelete.Focus();
        }

        private void btnBackUpdate_Click(object sender, EventArgs e)
        {
            //Open dashboard form.
            this.Close();
            frmDashboard AdministratorDashboard = new frmDashboard();
            AdministratorDashboard.Show();
        }

        private void btnBackDelete_Click(object sender, EventArgs e)
        {
            //Open dashboard form.
            this.Close();
            frmDashboard AdministratorDashboard = new frmDashboard();
            AdministratorDashboard.Show();
        }
    }

}

        
    
