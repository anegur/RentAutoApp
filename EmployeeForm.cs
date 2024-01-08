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
    }
}
