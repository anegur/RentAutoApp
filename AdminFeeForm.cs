using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinFormsApp1
{
    public partial class AdminFeeForm : Form
    {
        public AdminFeeForm()
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
        }
        private void Form_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AdminFeeForm_Load(object sender, EventArgs e)
        {
            insert_fee_box.Visible = false;
            update_fee_box.Visible = false;

            feeDGV.DataSource = FeeTable.GetTable();

            if (feeDGV.RowCount < 1)
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

        private void insert_button_Click_1(object sender, EventArgs e)
        {
            insert_fee_box.Visible = true;
            insert_fee_box.BringToFront();
            update_fee_box.SendToBack();
        }

        private void update_button_Click_1(object sender, EventArgs e)
        {
            update_fee_box.Visible = true;
            update_fee_box.BringToFront();
            update_fee_box.SendToBack();

            DataGridViewRow ds = feeDGV.CurrentRow;

            string feeid = ds.Cells[0].Value.ToString();
            string name = ds.Cells[1].Value.ToString();
            string cost = ds.Cells[2].Value.ToString();

            update_feeid_tb.Text = feeid;
            update_name_tb.Text = name;
            update_cost_tb.Text = cost;
        }
        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void insert_table_button_Click(object sender, EventArgs e)
        {
            string name = insert_name_tb.Text;
            string cost = insert_cost_tb.Text;
            int cost_int;

            if (name == "" || cost == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            if (!Int32.TryParse(cost, out cost_int) || (cost_int < 0))
            {
                Messages.DisplayErrorMessage("Неправильно введёная цена");
                return;
            }


            if (FeeTable.Insert(name, cost_int))
            {
                insert_name_tb.Text = "";
                insert_cost_tb.Text = "";

                insert_fee_box.Visible = false;

                feeDGV.DataSource = FeeTable.GetTable();
                Messages.DisplayInfoMessage("Данные успешно добавлены!");
            }
            else
                Messages.DisplayErrorMessage("Ошибка при добавлении данных!");
        }

        private void insert_cancel_button_Click(object sender, EventArgs e)
        {
            insert_fee_box.Visible = false;
        }

        private void update_table_button_Click(object sender, EventArgs e)
        {
            string feeid = update_feeid_tb.Text;
            string name = update_name_tb.Text;
            string cost = update_cost_tb.Text;
            int feeid_int;
            int cost_int;

            int currentFeeId = (int)feeDGV.CurrentRow.Cells[0].Value;

            if (name == "" || cost == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            if (!Int32.TryParse(cost, out cost_int) || (cost_int < 0))
            {
                Messages.DisplayErrorMessage("Неправильно введёная цена");
                return;
            }

            if (!Int32.TryParse(feeid, out feeid_int))
            {
                Messages.DisplayErrorMessage("Ошибка ввода ID машины!");
                return;
            }


            if (FeeTable.IsExistsDriver(feeid_int))
            {
                if (FeeTable.Update(feeid_int, name, cost_int))
                {
                    feeDGV.DataSource = FeeTable.GetTable();
                    update_fee_box.Visible = false;
                    Messages.DisplayInfoMessage("Данные успешно обновлены!");
                }
                else
                {
                    Messages.DisplayErrorMessage("Ошибка при изменении данных!");
                }
            }
            else
            {
                Messages.DisplayErrorMessage("Такого ID тарифа нет!!!");
            }
        }

        private void update_cancel_button_Click(object sender, EventArgs e)
        {
            update_fee_box.Visible = false;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                int feeid = (int)feeDGV.CurrentRow.Cells[0].Value;
                DialogResult dr = Messages.DisplayQuestionMessage("Вы действительно хотите удалить данные? Они могут быть связаны");
                if (dr == DialogResult.Yes)
                {
                    FeeTable.Delete(feeid);
                    feeDGV.DataSource = FeeTable.GetTable();
                    Messages.DisplayInfoMessage("Данные успешно удалены!");
                }
                if (HasRelatedRecords(feeid))
                {
                    DialogResult dr2 = Messages.DisplayQuestionMessage("Существуют связанные записи, которые также будут удалены. Вы действительно хотите продолжить?");
                    if (dr2 != DialogResult.Yes)
                    {
                        return;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                // Используем регулярные выражения для извлечения имени таблицы из сообщения об ошибке
                var match = Regex.Match(ex.Message, @"на ключ \(.+\) всё ещё есть ссылки в таблице ""(.+?)""");
                if (match.Success)
                {
                    string tableName = match.Groups[1].Value;
                    Messages.DisplayErrorMessage($"Ошибка: Невозможно удалить запись, поскольку на нее ссылаются в таблице '{tableName}'!");
                }
                else
                {
                    Messages.DisplayErrorMessage("Ошибка при удалении данных! (что-то в таблицах)");
                }
            }
            catch
            {
                Messages.DisplayErrorMessage("Ошибка при удалении данных!");
            }
        }

        private bool HasRelatedRecords(int feeid)
        {
            NpgsqlCommand command;
            string query =
                "SELECT COUNT(*) " +
                "FROM car " +
                "WHERE feeid = @feeid";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@feeid", feeid);
                int count = (int)command.ExecuteScalar();

                DB.closeConnection();

                return count > 0;
            }
            catch
            {
                DB.closeConnection();
                throw;
            }
        }

        private void feeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
