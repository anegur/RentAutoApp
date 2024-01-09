using Npgsql;
using NpgsqlTypes;
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
    public partial class EmployeeAuthForm : Form
    {

        public string employeeIdAuto;
        public EmployeeAuthForm()
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
        }
        private void Form_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

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
                "SELECT * FROM employee " +
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
                object value = table.Rows[0]["employeeid"];
                employeeIdAuto = value.ToString();
                Hide();
                EmployeeForm inspectorForm = new EmployeeForm(employeeIdAuto);
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
