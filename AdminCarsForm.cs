using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class AdminCarsForm : Form
    {
        public AdminCarsForm()
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
        }
        private void Form_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void AdminCarsForm_Load_1(object sender, EventArgs e)
        {
            insert_car_box.Visible = false;
            update_car_box.Visible = false;

            dataGridView1.DataSource = CarTable.GetTable();

            if (dataGridView1.RowCount < 1)
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
        private void update_button_Click(object sender, EventArgs e)
        {
            update_car_box.Visible = true;
            update_car_box.BringToFront();
            insert_car_box.SendToBack();

            DataGridViewRow ds = dataGridView1.CurrentRow;

            string carid = ds.Cells[0].Value.ToString();
            string feeid = ds.Cells[1].Value.ToString();
            string model = ds.Cells[2].Value.ToString();
            string current_year = ds.Cells[3].Value.ToString();
            string access = ds.Cells[4].Value.ToString();

            update_carid_tb.Text = carid;
            update_fee_tb.Text = feeid;
            update_model_tb.Text = model;
            update_year_tb.Text = current_year;
            update_access_tb.Text = access;
        }
        private void insert_button_Click(object sender, EventArgs e)
        {
            insert_car_box.Visible = true;
            insert_car_box.BringToFront();
            update_car_box.SendToBack();
        }

        private void insert_cancel_button_Click(object sender, EventArgs e)
        {
            insert_car_box.Visible = false;
        }

        private void update_cancel_button_Click(object sender, EventArgs e)
        {
            update_car_box.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void insert_car_box_Enter(object sender, EventArgs e)
        {

        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void insert_table_button_Click(object sender, EventArgs e)
        {
            string fee_id = insert_fee_tb.Text;
            string model = insert_car_tb.Text;
            string release_year = insert_year_tb.Text;
            string access = insert_access_tb.Text;
            int releaseYear;
            int feeId;
            int accesS;

            if (!Int32.TryParse(fee_id, out feeId))
            {
                Messages.DisplayErrorMessage("Ошибка ввода тарифа!");
                return;
            }

            if (fee_id == "" || model == "" || release_year == "" || access == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            if (!Int32.TryParse(access, out accesS) || (accesS != 0 && accesS != 1))
            {
                Messages.DisplayErrorMessage("Ввести можно либо 1 - доступно, либо 0 - недоступно");
                return;
            }

            if (!Int32.TryParse(access, out accesS) || (accesS != 0 && accesS != 1))
            {
                Messages.DisplayErrorMessage("Ввести можно либо 1 - доступно, либо 0 - недоступно");
                return;
            }

            if (release_year.Length > 4 || !Int32.TryParse(release_year, out releaseYear))
            {
                Messages.DisplayErrorMessage("В году ошибка");
                return;
            }


            if (CarTable.Insert(feeId, model, releaseYear, accesS))
            {
                insert_fee_tb.Text = "";
                insert_car_tb.Text = "";
                insert_year_tb.Text = "";
                insert_access_tb.Text = "";

                insert_car_box.Visible = false;

                dataGridView1.DataSource = CarTable.GetTable();
                Messages.DisplayInfoMessage("Данные успешно добавлены!");
            }
            else
                Messages.DisplayErrorMessage("Ошибка при добавлении данных!");
        }

        private void update_table_button_Click(object sender, EventArgs e)
        {
            string fee_id = update_fee_tb.Text;
            string model = update_model_tb.Text;
            string release_year = update_year_tb.Text;
            string access = update_access_tb.Text;
            string carid = update_carid_tb.Text;
            int releaseYear;
            int feeId;
            int accesS;
            int carId;

            int currentCarId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            if (fee_id == "" || model == "" || release_year == "" || access == "" || carid == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            if (!Int32.TryParse(carid, out carId))
            {
                Messages.DisplayErrorMessage("Ошибка ввода ID машины!");
                return;
            }

            if (!Int32.TryParse(fee_id, out feeId))
            {
                Messages.DisplayErrorMessage("Ошибка ввода тарифа!");
                return;
            }
            if (!Int32.TryParse(access, out accesS) || (accesS != 0 && accesS != 1))
            {
                Messages.DisplayErrorMessage("Ввести можно либо 1 - доступно, либо 0 - недоступно");
                return;
            }

            if (!Int32.TryParse(access, out accesS) || (accesS != 0 && accesS != 1))
            {
                Messages.DisplayErrorMessage("Ввести можно либо 1 - доступно, либо 0 - недоступно");
                return;
            }

            if (release_year.Length > 4 || !Int32.TryParse(release_year, out releaseYear))
            {
                Messages.DisplayErrorMessage("В году ошибка");
                return;
            }


            if (CarTable.IsExistsDriver(carId))
            {
                if (CarTable.Update(carId, feeId, model, releaseYear, accesS))
                {
                    dataGridView1.DataSource = CarTable.GetTable();
                    update_car_box.Visible = false;
                    Messages.DisplayInfoMessage("Данные успешно обновлены!");
                }
                else
                {
                    Messages.DisplayErrorMessage("Ошибка при изменении данных!");
                }
            }
            else
            {
                Messages.DisplayErrorMessage("Такого ID машины нет!!!");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                int carid = (int)dataGridView1.CurrentRow.Cells[0].Value;
                DialogResult dr = Messages.DisplayQuestionMessage("Вы действительно хотите удалить данные?");
                if (dr == DialogResult.Yes)
                {
                    CarTable.Delete(carid);
                    dataGridView1.DataSource = CarTable.GetTable();
                    Messages.DisplayInfoMessage("Данные успешно удалены!");
                }
            }
            catch
            {
                Messages.DisplayErrorMessage("Ошибка при удалении данных!");
            }
        }
    }
}
