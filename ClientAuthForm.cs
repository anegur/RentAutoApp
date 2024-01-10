using Npgsql;
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
        public string clientIdAuto;
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

        private void to_back_button_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            String login = loginTextBox.Text;
            String pass = passTextBox.Text;

            if (login == "" || pass == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
            }

            string query =
                "SELECT * FROM client " +
                "WHERE fio = @login AND password = @pass";

            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand(query, DB.GetConnection());

            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@pass", pass);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                object value = table.Rows[0]["clientid"];
                clientIdAuto = value.ToString();
                Hide();
                ClientFullForm inspectorForm = new ClientFullForm(clientIdAuto);
                inspectorForm.Show();
                //Отформатируйте строку с использованием переменной employeeIdAuto
                //string successMessage = $"Вход успешен {employeeIdAuto}";
                // Выведите отформатированное сообщение
                //Messages.DisplayInfoMessage(successMessage);
            }
            else
            {
                Messages.DisplayErrorMessage("Неверные ФИО или пароль!");
            }
        }
    }
}
