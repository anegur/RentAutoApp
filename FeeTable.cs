using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public static class FeeTable
    {
        static DataTable table = new DataTable();

        public static DataTable GetTable()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;

            table.Clear();

            string query = "SELECT * FROM fee";
            table.Clear();
            DB.openConnection();

            command = new NpgsqlCommand(query, DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DB.closeConnection();

            return table;
        }
        public static bool Insert(string name, int cost)
        {
            NpgsqlCommand command;
            string query =
                "INSERT INTO fee (name, cost) " +
                "VALUES (@name, @cost)";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@cost", cost);

                if (command.ExecuteNonQuery() > 0)
                {
                    DB.closeConnection();
                    return true;
                }
                else
                {
                    DB.closeConnection();
                    return false;
                }
            }
            catch
            {
                DB.closeConnection();
                return false;
            }
        }

        public static bool Update(int feeid, string name, int cost)
        {
            NpgsqlCommand command;
            string query =
                "UPDATE Fee SET name = @name, cost = @cost " +
                "WHERE feeid = @feeid";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@feeid", feeid);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@cost", cost);

                if (command.ExecuteNonQuery() > 0)
                {
                    DB.closeConnection();
                    return true;
                }
                else
                {
                    DB.closeConnection();
                    return false;
                }
            }
            catch
            {
                DB.closeConnection();
                MessageBox.Show("Ошибка при редактировании данных");
                return false;
            }
        }
        public static void Delete(int feeid)
        {
            NpgsqlCommand command;
            string query =
                "DELETE FROM fee " +
                "WHERE feeid = @feeid";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@feeid", feeid);
                command.ExecuteNonQuery();

                DB.closeConnection();
            }
            catch
            {
                DB.closeConnection();
                throw;
            }
        }

        public static bool IsExistsDriver(int feeid)
        {
            DataTable dataTableQuery = new DataTable();
            string query =
                "SELECT * FROM fee " +
                "WHERE feeid = @feeid";


            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand(query, DB.GetConnection());

            command.Parameters.AddWithValue("@feeid", feeid);
            adapter.SelectCommand = command;
            adapter.Fill(dataTableQuery);

            if (dataTableQuery.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
