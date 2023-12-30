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
    public partial class AdminEmloyeeForm : Form
    {
        public AdminEmloyeeForm()
        {
            InitializeComponent();
        }

        private void AdminEmloyeeForm_Load(object sender, EventArgs e)
        {
            insert_employee_box.Visible = false;
            update_employee_box.Visible = false;

            employeeDGV.DataSource = EmployeeTable.GetTable();

            if (employeeDGV.RowCount < 1)
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
            insert_employee_box.Visible = true;
            insert_employee_box.BringToFront();
            update_employee_box.SendToBack();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            update_employee_box.Visible = true;
            update_employee_box.BringToFront();
            update_employee_box.SendToBack();

            DataGridViewRow ds = employeeDGV.CurrentRow;

            string employeeid = ds.Cells[0].Value.ToString();
            string fio = ds.Cells[1].Value.ToString();
            string phone_n = ds.Cells[2].Value.ToString();
            string email = ds.Cells[3].Value.ToString();
            string password = ds.Cells[4].Value.ToString();

            update_employeeid_tb.Text = employeeid;
            update_fio_tb.Text = fio;
            update_numb_tb.Text = phone_n;
            update_email_tb.Text = email;
            update_pass_tb.Text = password;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeid = (int)employeeDGV.CurrentRow.Cells[0].Value;
                DialogResult dr = Messages.DisplayQuestionMessage("Вы действительно хотите удалить данные? Они могут быть связаны");
                if (dr == DialogResult.Yes)
                {
                    EmployeeTable.Delete(employeeid);
                    employeeDGV.DataSource = EmployeeTable.GetTable();
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

            if (fio == "" || phone_n == "" || email == "" || password == "")
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

            if (EmployeeTable.Insert(fio, phone_n, email, password))
            {
                insert_fio_tb.Text = "";
                insert_numb_tb.Text = "";
                insert_mail_tb.Text = "";
                insert_pass_tb.Text = "";

                insert_employee_box.Visible = false;

                employeeDGV.DataSource = EmployeeTable.GetTable();
                Messages.DisplayInfoMessage("Данные успешно добавлены!");
            }
            else
                Messages.DisplayErrorMessage("Ошибка при добавлении данных!");
        }

        private void insert_cancel_button_Click(object sender, EventArgs e)
        {
            insert_employee_box.Visible = false;
        }

        private void update_table_button_Click(object sender, EventArgs e)
        {
            string employeeid = update_employeeid_tb.Text;
            string fio = update_fio_tb.Text;
            string phone_n = update_numb_tb.Text;
            string email = update_email_tb.Text;
            string password = update_pass_tb.Text;
            int clientId;

            int currentClientId = (int)employeeDGV.CurrentRow.Cells[0].Value;

            if (fio == "" || phone_n == "" || email == "" || employeeid == "" || password == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            if (!Int32.TryParse(employeeid, out clientId))
            {
                Messages.DisplayErrorMessage("Ошибка ввода ID сотрудника!");
                return;
            }

            //вставить те же проверки, что и на вводе

            if (EmployeeTable.IsExistsDriver(clientId))
            {
                if (EmployeeTable.Update(clientId, fio, phone_n, email, password))
                {
                    employeeDGV.DataSource = EmployeeTable.GetTable();
                    update_employee_box.Visible = false;
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

        private void update_cancel_button_Click(object sender, EventArgs e)
        {
            update_employee_box.Visible = false;
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
    }
}
