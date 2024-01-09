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
    public partial class EmployeeRentForm : Form
    {
        private string employeeIdAuto;
        public EmployeeRentForm(string employeeIdAuto1)
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
            employeeIdAuto = employeeIdAuto1;
        }
        public bool ChekEmployee()
        {
            int employeeIdInt = (int)rentDGV.CurrentRow.Cells[2].Value;
            string employeeid1 = employeeIdInt.ToString();
            return employeeid1 == employeeIdAuto;

        }
        private void Form_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void EmployeeRentForm_Load(object sender, EventArgs e)
        {
            insert_rent_box.Visible = false;
            update_rent_box.Visible = false;

            rentDGV.DataSource = RentTable.GetTable();
            dataGridView1.DataSource = ClientTable.GetTable();
            dataGridView2.DataSource = EmployeeTable.GetTable();
            dataGridView3.DataSource = CarTable.GetTable();
            Width = 1072;
            CenterToScreen();

            if (rentDGV.RowCount < 1)
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
            //update_clientid_tb.Text = employeeid;
            update_carid_tb.Text = carid;
            update_start_dtp.Value = start_date;
            update_end_dtp.Value = end_date;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (ChekEmployee())
            {
                try
                {
                    int rentid = (int)rentDGV.CurrentRow.Cells[0].Value;
                    DialogResult dr = Messages.DisplayQuestionMessage("Вы действительно хотите удалить данные? Они могут быть связаны");
                    if (dr == DialogResult.Yes)
                    {
                        RentTable.Delete(rentid);
                        rentDGV.DataSource = RentTable.GetTable();
                        Messages.DisplayInfoMessage("Данные успешно удалены!");
                    }
                }
                catch
                {
                    Messages.DisplayErrorMessage("Ошибка при удалении данных!");
                }
            }
            else { Messages.DisplayErrorMessage("Вы не можете удалить чужие записи!"); }
        }

        private void insert_rent_box_Enter(object sender, EventArgs e)
        {

        }

        private void update_rent_box_Enter(object sender, EventArgs e)
        {

        }

        private void insert_table_button_Click(object sender, EventArgs e)
        {
            //int employeeid = (int)rentDGV.CurrentRow.Cells[2].Value;
            string employeeid1 = employeeIdAuto;

            string clientid = insert_clientid_tb.Text;
            //string employeeid = insert_employeeid_tb.Text;
            string carid = insert_carid_tb.Text;
            DateTime start_date = insert_start_dtp.Value;
            DateTime end_date = insert_end_dtp.Value;
            int clientId;
            int employeeId;
            int carId;

            // При добавлении записи в таблицу "Rent", используйте выбранное значение из выпадающего списка
            //int selectedEmployeeId = Convert.ToInt32(comboBoxEmployee.SelectedValue);
            // Ваш код добавления записи в таблицу "Rent" с использованием selectedEmployeeIdint Selected

            if (employeeid1 == "" || clientid == "" || carid == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            if (!Int32.TryParse(employeeid1, out employeeId))
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
                //insert_employeeidnew_tb.Text = "";
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
            int employeeid = (int)rentDGV.CurrentRow.Cells[2].Value;
            string employeeid1 = employeeid.ToString();

            string rentid = update_rentid_tb.Text;
            //string employeeid = update_employeeid_tb.Text;
            string clientid = update_clientid_tb.Text;
            string carid = update_carid_tb.Text;
            DateTime start_date = update_start_dtp.Value;
            DateTime end_date = update_end_dtp.Value;
            int rentId;
            int employeeId;
            int clientId;
            int carId;

            if (rentid == "" || clientid == "" || carid == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            if (!Int32.TryParse(rentid, out rentId))
            {
                Messages.DisplayErrorMessage("ошибка ввода айди машины");
                return;
            }

            if (!Int32.TryParse(employeeid1, out employeeId))
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

            // Предположим, у вас есть объект формы EmployeeAuthForm
            //EmployeeAuthForm authForm = new EmployeeAuthForm();

            //// Теперь вы можете получить значение переменной employeeIdAuto через этот объект
            //string employeeIdFromAuthForm = authForm.employeeIdAuto;

            // Теперь вы можете использовать employeeIdFromAuthForm в текущем контексте
            if(ChekEmployee())
            {
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
            else
            {
                Messages.DisplayErrorMessage("Вы не можете редактировать чужие записи!");
            }
            
        }

        private void insert_cancel_button_Click(object sender, EventArgs e)
        {

        }

        private void update_cancel_button_Click(object sender, EventArgs e)
        {

        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm adminForm = new EmployeeForm();
            adminForm.Show();
        }

        private void buttonIncreaseWidth_Click(object sender, EventArgs e)
        {
            Width += 700;
            CenterToScreen();
        }

        private void buttonResetSize_Click(object sender, EventArgs e)
        {
            Width = 1072;
            CenterToScreen();
        }

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
