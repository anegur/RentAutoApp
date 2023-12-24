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
    public partial class ClientAuthForm : Form
    {
        public ClientAuthForm()
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
        }

        private void Form_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ClientAuthForm_Load(object sender, EventArgs e)
        {

        }

    }
}
