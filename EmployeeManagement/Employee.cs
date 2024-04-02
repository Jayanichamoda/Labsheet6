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
using System.Xml.Linq;

namespace EmployeeManagement
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename='C:\Users\hp\OneDrive - NSBM\Documents\NSBM_DEMO\C# lectures\C# practical\EmployeeManagement\EmployeeManagement\Employee.mdf';Integrated Security = True");

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string dob = dobtxt.Text;
            string email = emailtxt.Text;
            string address = addresstxt.Text;
            string contactNumber = contacttxt.Text;
            string username = usernametxt.Text;
            string password = passwordtxt.Text;

            string Query1 = $"INSERT INTO Employee(Username,Name,DOB,Password) VALUES('{username}','{name}','{dob}','{password}');";
            SqlCommand command1 = new SqlCommand(Query1, sqlConnection);

            string Query2 = $"INSERT INTO Contact(Username,ContactNumber,Email,Address) VALUES('{username}','{contactNumber}','{email}','{address}');";
            SqlCommand command2 = new SqlCommand(Query2, sqlConnection);

            try
            {
                sqlConnection.Open();//opens a connection to the database 
                command1.ExecuteNonQuery();//executes a SQL command (command1)
                sqlConnection.Close();//closes the connection to the database. 

                sqlConnection.Open();
                command2.ExecuteNonQuery();
                MessageBox.Show("Registration successful!");
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("errors:" + ex.Message);

            }

            ClearFields();

        }

        private void ClearFields()
        {
            nametxt.Text = "";
            dobtxt.Text = "";
            emailtxt.Text = "";
            addresstxt.Text = "";
            contacttxt.Text = "";
            usernametxt.Text = "";
            passwordtxt.Text = "";
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
