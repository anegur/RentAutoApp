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
    public partial class AdminRentForm : Form
    {
        public AdminRentForm()
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;

            //comboBoxEmployee.DataSource = ClientTable.GetTable(); // GetClients() - ваш метод для получения данных из таблицы "Client"
            //comboBoxEmployee.DisplayMember = "ClientName"; // Замените "ClientName" на поле, которое вы хотите отображать
            //comboBoxEmployee.ValueMember = "ClientId"; // Замените "ClientId" на поле с идентификатором
        }
        private void Form_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void update_end_date_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminRentForm_Load(object sender, EventArgs e)
        {
            insert_rent_box.Visible = false;
            update_rent_box.Visible = false;

            rentDGV.DataSource = RentTable.GetTable();
            dataGridView1.DataSource = ClientTable.GetTable();
            dataGridView2.DataSource = EmployeeTable.GetTable();
            dataGridView3.DataSource = CarTable.GetTable();
            Width = 930;
            CenterToScreen();

            //if (rentDGV.RowCount < 1)
            //{
            //    insert_table_button.Enabled = false;
            //    delete_button.Enabled = false;
            //}
            //else
            //{
            //    update_table_button.Enabled = true;
            //    delete_button.Enabled = true;
            //}
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            insert_rent_box.Visible = true;
            insert_rent_box.BringToFront();
            update_rent_box.SendToBack();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            update_rent_box.Visible = true;
            update_rent_box.BringToFront();
            update_rent_box.SendToBack();

            DataGridViewRow ds = rentDGV.CurrentRow;

            string rentid = ds.Cells[0].Value.ToString();
            string clientid = ds.Cells[1].Value.ToString();
            string employeeid = ds.Cells[2].Value.ToString();
            string carid = ds.Cells[3].Value.ToString();
            DateTime start_date = (DateTime)ds.Cells[4].Value;
            DateTime end_date = (DateTime)ds.Cells[5].Value;

            update_rentid_tb.Text = rentid;
            update_clientid_tb.Text = clientid;
            update_employeeid_tb.Text = employeeid;
            update_carid_tb.Text = carid;
            update_start_dtp.Value = start_date;
            update_end_dtp.Value = end_date;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                int rentid = (int)rentDGV.CurrentRow.Cells[0].Value;
                    
                    RentTable.Delete(rentid);
                    rentDGV.DataSource = RentTable.GetTable();
                    Messages.DisplayInfoMessage("Данные успешно удалены!");
            }
            catch
            {
                Messages.DisplayErrorMessage("Ошибка при удалении данных!");
            }
        }

        private void insert_rent_box_Enter(object sender, EventArgs e)
        {

        }

        private void update_rent_box_Enter(object sender, EventArgs e)
        {

        }

        private void insert_table_button_Click(object sender, EventArgs e)
        {
            string clientid = insert_clientid_tb.Text;
            string employeeid = insert_employeeidnew_tb.Text;
            string carid = insert_carid_tb.Text;
            DateTime start_date = insert_start_dtp.Value;
            DateTime end_date = insert_end_dtp.Value;
            int clientId;
            int employeeId;
            int carId;

            // При добавлении записи в таблицу "Rent", используйте выбранное значение из выпадающего списка
            //int selectedEmployeeId = Convert.ToInt32(comboBoxEmployee.SelectedValue);
            // Ваш код добавления записи в таблицу "Rent" с использованием selectedEmployeeIdint Selected

            if (employeeid == "" || clientid == "" || carid == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            if (!Int32.TryParse(employeeid, out employeeId))
            {
                Messages.DisplayErrorMessage("Ошибка ввода айди сотрудника!");
                return;
            }

            if (!Int32.TryParse(clientid, out clientId))
            {
                Messages.DisplayErrorMessage("Ошибка ввода айди клиента!");
                return;
            }

            if (!Int32.TryParse(carid, out carId))
            {
                Messages.DisplayErrorMessage("Ошибка ввода айди машины!");
                return;
            }

            //Messages.DisplayInfoMessage($"Selected Employee ID: {employeeId}");

            if (RentTable.Insert(clientId, employeeId, carId, start_date, end_date))
            {
                insert_employeeidnew_tb.Text = "";
                insert_clientid_tb.Text = "";
                insert_carid_tb.Text = "";

                insert_rent_box.Visible = false;

                rentDGV.DataSource = RentTable.GetTable();
                Messages.DisplayInfoMessage("Данные успешно добавлены!");
            }
            else
                Messages.DisplayErrorMessage("Ошибка при добавлении данных!");
        }

        private void update_table_button_Click(object sender, EventArgs e)
        {
            string rentid = update_carid_tb.Text;
            string employeeid = update_employeeid_tb.Text;
            string clientid = update_clientid_tb.Text;
            string carid = update_carid_tb.Text;
            DateTime start_date = update_start_dtp.Value;
            DateTime end_date = update_end_dtp.Value;
            int rentId;
            int employeeId;
            int clientId;
            int carId;

            if (rentid == "" || employeeid == "" || clientid == "" || carid == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            if (!Int32.TryParse(rentid, out rentId))
            {
                Messages.DisplayErrorMessage("ошибка ввода айди машины");
                return;
            }

            if (!Int32.TryParse(employeeid, out employeeId))
            {
                Messages.DisplayErrorMessage("Ошибка ввода айди сотрудника!");
                return;
            }

            if (!Int32.TryParse(clientid, out clientId))
            {
                Messages.DisplayErrorMessage("Ошибка ввода айди клиента!");
                return;
            }

            if (!Int32.TryParse(carid, out carId))
            {
                Messages.DisplayErrorMessage("Ошибка ввода айди машины!");
                return;
            }

            if (RentTable.IsExistsDriver(rentId))
            {
                if (RentTable.Update(rentId, clientId, employeeId, carId, start_date, end_date))
                {
                    update_rent_box.Visible = false;

                    rentDGV.DataSource = RentTable.GetTable();
                    Messages.DisplayInfoMessage("Данные успешно обновлены!");
                }
                else
                {
                    Messages.DisplayErrorMessage("Ошибка при изменении данных!");
                }
            }
            else
            {
                Messages.DisplayErrorMessage("Указанного айди проката не существует!");
            }
        }

        private void insert_cancel_button_Click(object sender, EventArgs e)
        {
            insert_rent_box.Hide(); 
        }

        private void update_cancel_button_Click(object sender, EventArgs e)
        {
            update_rent_box.Hide();
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void buttonIncreaseWidth_Click(object sender, EventArgs e)
        {
            Width = 1560;
            CenterToScreen();
        }

        private void buttonResetSize_Click(object sender, EventArgs e)
        {
            Width = 930;
            CenterToScreen();
        }

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
