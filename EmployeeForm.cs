//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EmployeeForm : Form
    {
        private string _employeeName;
        public EmployeeForm(string employeeIdAuto)
        {
            _employeeName = employeeIdAuto;
            InitializeComponent();
        }

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainFrom = new MainForm();
            mainFrom.Show();
        }

        private void client_button_Click(object sender, EventArgs e)
        {
            Hide();
            EmployeeClientForm employeeClientForm = new EmployeeClientForm();
            employeeClientForm.Show();
        }

        private void rent_button_Click(object sender, EventArgs e)
        {
            Hide();
            EmployeeRentForm employeeRentForm = new EmployeeRentForm(_employeeName); 
            employeeRentForm.Show();
        }
    }
}
