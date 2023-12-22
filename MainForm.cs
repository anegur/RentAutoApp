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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EmlpoyeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
