using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit editwindow = new Edit();
            editwindow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display displaywindow = new Display();
            displaywindow.Show();
        }
    }
}
