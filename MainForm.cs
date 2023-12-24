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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Form_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAuthForm adminAuthForm = new AdminAuthForm();
            adminAuthForm.Show();
        }

        private void EmlpoyeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeAuthForm empAuthForm = new EmployeeAuthForm();
            empAuthForm.Show();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientAuthForm clientAuthForm = new ClientAuthForm();
            clientAuthForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
