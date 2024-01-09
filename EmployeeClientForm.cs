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
    public partial class EmployeeClientForm : Form
    {
        public EmployeeClientForm()
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
        }
        private void Form_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EmployeeClientForm_Load(object sender, EventArgs e)
        {
            insert_client_box.Visible = false;
            update_client_box.Visible = false;

            clientDGV.DataSource = ClientTable.GetTable();

            if (clientDGV.RowCount < 1)
            {
                insert_table_button.Enabled = false;
                delete_button.Enabled = false;
            }
            else
            {
                update_table_button.Enabled = true;
                delete_button.Enabled = true;
            }
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            insert_client_box.Visible = true;
            insert_client_box.BringToFront();
            update_client_box.SendToBack();
        }

        private void update_button_Click_1(object sender, EventArgs e)
        {
            update_client_box.Visible = true;
            update_client_box.BringToFront();
            update_client_box.SendToBack();

            DataGridViewRow ds = clientDGV.CurrentRow;

            string clientid = ds.Cells[0].Value.ToString();
            string fio = ds.Cells[1].Value.ToString();
            string phone_n = ds.Cells[2].Value.ToString();
            string email = ds.Cells[3].Value.ToString();
            string password = ds.Cells[4].Value.ToString();

            update_clientid_tb.Text = clientid;
            update_fio_tb.Text = fio;
            update_numb_tb.Text = phone_n;
            update_email_tb.Text = email;
            update_pass_tb.Text = password;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                int clientid = (int)clientDGV.CurrentRow.Cells[0].Value;
                DialogResult dr = Messages.DisplayQuestionMessage("Вы действительно хотите удалить данные? Они могут быть связаны");
                if (dr == DialogResult.Yes)
                {
                    ClientTable.Delete(clientid);
                    clientDGV.DataSource = ClientTable.GetTable();
                    Messages.DisplayInfoMessage("Данные успешно удалены!");
                }
            }
            catch
            {
                Messages.DisplayErrorMessage("Ошибка при удалении данных!");
            }
        }

        private void insert_table_button_Click(object sender, EventArgs e)
        {
            string fio = insert_fio_tb.Text;
            string phone_n = insert_numb_tb.Text;
            string email = insert_mail_tb.Text;
            string password = insert_pass_tb.Text;

            if (fio == "" || phone_n == "" || email == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            //var words = fio.Split(' ');
            //if (words.Length != 3)
            //{
            //    Messages.DisplayErrorMessage("Строка должна содержать ровно три слова");
            //    return;
            //}
            //foreach (var word in words)
            //{
            //    if (!word.All(char.IsLetter))
            //    {
            //        Messages.DisplayErrorMessage("Слова должны содержать только буквы");
            //        return;
            //    }
            //    if (!char.IsUpper(word[0]))
            //    {
            //        Messages.DisplayErrorMessage("Слова должны начинаться с заглавной буквы");
            //        return;
            //    }
            //    if (!word.Substring(1).All(char.IsLower))
            //    {
            //        Messages.DisplayErrorMessage("Все буквы после первой должны быть строчными");
            //        return;
            //    }
            //}

            //if (phone_n.Length != 11)
            //{
            //    Messages.DisplayErrorMessage("Номер телефона должен содержать ровно 11 символов");
            //    return;
            //}
            //if (!phone_n.All(char.IsDigit))
            //{
            //    Messages.DisplayErrorMessage("Номер телефона должен содержать только цифры");
            //    return;
            //}
            //if (phone_n[0] != '8')
            //{
            //    Messages.DisplayErrorMessage("Номер телефона должен начинаться с '8'");
            //    return;
            //}

            //if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            //{
            //    Messages.DisplayErrorMessage("Электронная почта должна быть в формате example@example.com");
            //    return;
            //}

            if (ClientTable.Insert(fio, phone_n, email, password))
            {
                insert_fio_tb.Text = "";
                insert_numb_tb.Text = "";
                insert_mail_tb.Text = "";
                insert_pass_tb.Text = "";

                insert_client_box.Visible = false;

                clientDGV.DataSource = ClientTable.GetTable();
                Messages.DisplayInfoMessage("Данные успешно добавлены!");
            }
            else
                Messages.DisplayErrorMessage("Ошибка при добавлении данных!");
        }

        private void update_table_button_Click(object sender, EventArgs e)
        {
            string clientid = update_clientid_tb.Text;
            string fio = update_fio_tb.Text;
            string phone_n = update_numb_tb.Text;
            string email = update_email_tb.Text;
            string password = update_pass_tb.Text;
            int clientId;

            int currentClientId = (int)clientDGV.CurrentRow.Cells[0].Value;

            if (fio == "" || phone_n == "" || email == "" || clientid == "" || password == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            if (!Int32.TryParse(clientid, out clientId))
            {
                Messages.DisplayErrorMessage("Ошибка ввода ID клиента!");
                return;
            }

            //вставить те же проверки, что и на вводе

            if (ClientTable.IsExistsDriver(clientId))
            {
                if (ClientTable.Update(clientId, fio, phone_n, email, password))
                {
                    clientDGV.DataSource = ClientTable.GetTable();
                    update_client_box.Visible = false;
                    Messages.DisplayInfoMessage("Данные успешно обновлены!");
                }
                else
                {
                    Messages.DisplayErrorMessage("Ошибка при изменении данных!");
                }
            }
            else
            {
                Messages.DisplayErrorMessage("Такого ID клиента нет!!!");
            }
        }

        private void insert_cancel_button_Click(object sender, EventArgs e)
        {
            insert_client_box.Visible = false;
        }

        private void update_cancel_button_Click(object sender, EventArgs e)
        {
            update_client_box.Visible = false;
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm adminForm = new EmployeeForm();
            adminForm.Show();
        }

        private void clientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void insert_client_box_Enter(object sender, EventArgs e)
        {

        }

        private void update_client_box_Enter(object sender, EventArgs e)
        {

        }

        private void insert_pass_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
