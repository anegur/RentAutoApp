using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
        private void Form_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clients_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminClientForm adminClientForm = new AdminClientForm();
            adminClientForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAuthForm adminAuthForm = new AdminAuthForm();
            adminAuthForm.Show();
        }

        private void car_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminCarsForm adminCarsForm = new AdminCarsForm();
            adminCarsForm.Show();
        }

        private void fee_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFeeForm adminFeeForm = new AdminFeeForm();
            adminFeeForm.Show();
        }

        private void emp_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminEmloyeeForm adminEmloyeeForm = new AdminEmloyeeForm();
            adminEmloyeeForm.Show();
        }

        private void rent_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRentForm adminRentForm = new AdminRentForm();
            adminRentForm.Show();
        }
    }
}
