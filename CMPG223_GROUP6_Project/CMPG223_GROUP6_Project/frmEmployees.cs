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
            //Sql run stored procedure
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

            //Populates the combobox
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

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surname, cellNum, username, password;
            bool isError = false;

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

                //SQL run stored procedure
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

                MessageBox.Show("A new employee was added!");

                conn.Close();
                showEmployees();
                populateComboBox();

                //Clears input
                txtNameAdd.Text = "";
                txtSurnameAdd.Text = "";
                txtUsernameAdd.Text = "";
                txtPasswordAdd.Text = "";
                txtCellNumAdd.Text = "";
                chkActiveAdd.Checked = false;
                chkIsAdminAdd.Checked = false;

                txtNameAdd.Focus();
            }
        }

        private void frmMaintainEmployees_Load(object sender, EventArgs e)
        {
            populateComboBox();
            showEmployees();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name, surname, cellNum, username, password;
            bool isError = false;
            int employeeID;

            name = txtNameUpdate.Text;
            surname = txtSurnameUpdate.Text;
            employeeID = int.Parse(cmbEmployeeIDUpdate.SelectedValue.ToString());
            cellNum = txtCellNumUpdate.Text;
            username = txtUsernameUpdate.Text;
            password = txtPasswordUpdate.Text;

            //Validates the input
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

                //SQL run stored procedure
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

                showEmployees();

                //Clears the input
                txtNameUpdate.Text = "";
                txtSurnameUpdate.Text = "";
                txtUsernameUpdate.Text = "";
                txtPasswordUpdate.Text = "";
                txtCellNumUpdate.Text = "";
                chkIsActiveUpdate.Checked = false;
                chkIsAdminUpdate.Checked = false;

                cmbEmployeeIDUpdate.Focus();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int employeeID = int.Parse(cmbEmployeeIDDelete.SelectedValue.ToString());

            conn.Open();

            //SQL run stored procedure
            comm = new SqlCommand("Delete_Employee", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@Employee_ID", employeeID);
            comm.ExecuteNonQuery();

            MessageBox.Show("Employee " + employeeID + " was deleted!");

            conn.Close();

            showEmployees();
            populateComboBox();

            cmbEmployeeIDDelete.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
