using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename='C:\Users\hp\OneDrive - NSBM\Documents\NSBM_DEMO\C# lectures\C# practical\EmployeeManagement\EmployeeManagement\Employee.mdf';Integrated Security = True");


        private void searchbtn_Click(object sender, EventArgs e)
        {
            string username = searchtxt.Text;

            sqlConnection.Open();

            string query = $"SELECT e.Name, e.DOB, e.Password, c.Username, c.ContactNumber, c.Email, c.Address FROM Employee e INNER JOIN Contact c ON e.Username = c.Username WHERE c.Username = '{username}'";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();//one table of in-memory data
            adapter.Fill(dataTable);


            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = dataTable;

                dataGridView1.ReadOnly = false;//allowing users to edit the data in the grid
            }
            else
            {
                MessageBox.Show("Employee not found.");
            }
            sqlConnection.Close();


        }

       /* private DataTable GetDataTable(string query)
        {
            DataTable dataTable = new DataTable();

            sqlConnection.Open();
            
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
            {
                adapter.Fill(dataTable);
            }

            sqlConnection.Close();

            return dataTable;
        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Get the updated value from the cell
            string newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            // Get the username of the employee being edited
            string username = dataGridView1.Rows[e.RowIndex].Cells["Username"].Value.ToString();

            string updateQuery= "";

            // Update the database with the new value
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (columnName == "Name" || columnName == "DOB" || columnName == "Password")
            {
                updateQuery = $"UPDATE Employee SET {columnName} = '{newValue}' WHERE Username = '{username}'";

            }else if (columnName == "Email" || columnName == "Address" || columnName == "ContactNumber")
            {
                updateQuery = $"UPDATE Contact SET {columnName} = '{newValue}' WHERE Username = '{username}'";

            }

            sqlConnection.Open();

            SqlCommand command = new SqlCommand(updateQuery, sqlConnection);
            command.ExecuteNonQuery();


            MessageBox.Show("Employee details updated successfully.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            display.Show();
            this.Close();
        }
    }
}
