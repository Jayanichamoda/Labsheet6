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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace EmployeeManagement
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename='C:\Users\hp\OneDrive - NSBM\Documents\NSBM_DEMO\C# lectures\C# practical\EmployeeManagement\EmployeeManagement\Employee.mdf';Integrated Security = True");


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void displaybtn_Click(object sender, EventArgs e)
        {

            string Query = "SELECT e.Name, e.DOB, e.Username, e.Password, c.ContactNumber, c.Email, c.Address FROM Employee e INNER JOIN Contact c ON e.Username = c.Username";

            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);//SQLDataAdapter is for retrieve data from a database
                                                                              //and populate a DataSet by creating a connection
                                                                              //with the database
            DataSet set = new DataSet();//Dataset hold multiple data tables retrieved from a database temporary.

            adapter.Fill(set, "Employee"); //create a dataset called Employee uing retrieved data

            dataGridView1.DataSource = set.Tables["Employee"];//assign the values to the grid view
                                                              //using created temporary dataset

        }
    }
}
