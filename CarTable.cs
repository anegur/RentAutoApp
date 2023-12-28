using Npgsql;
using System;
using System.Data;

namespace WinFormsApp1
{
    public static class CarTable
    {
        static DataTable table  = new DataTable();

        public static DataTable GetTable()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;

            table.Clear();

            string query = "SELECT * FROM car";
            table.Clear();
            DB.openConnection();

            command = new NpgsqlCommand(query, DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DB.closeConnection();

            return table;
        }
        public static bool Insert(int feeid, string model, int release_year, int access)
        {
            NpgsqlCommand command;
            string query =
                "INSERT INTO car (feeid, model, release_year, access) " +
                "VALUES (@feeid, @model, @release_year, @access)";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@feeid", feeid);
                command.Parameters.AddWithValue("@model", model);
                command.Parameters.AddWithValue("@release_year", release_year);
                command.Parameters.AddWithValue("@access", access);

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

        public static bool Update(int carid, int feeid, string model, int release_year, int access)
        {
            NpgsqlCommand command;
            string query =
                "UPDATE Car SET feeid = @feeid, model = @model, release_year = @release_year, access = @access " +
                "WHERE carid = @carid";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@carid", carid);
                command.Parameters.AddWithValue("@feeid", feeid);
                command.Parameters.AddWithValue("@model", model);
                command.Parameters.AddWithValue("@release_year", release_year);
                command.Parameters.AddWithValue("@access", access);
                

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
        public static void Delete(int carid)
        {
            NpgsqlCommand command;
            string query =
                "DELETE FROM car " +
                "WHERE carid = @carid";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@carid", carid);
                command.ExecuteNonQuery();

                DB.closeConnection();
            }
            catch
            {
                DB.closeConnection();
            }
        }

        public static bool IsExistsDriver(int carid)
        {
            DataTable dataTableQuery = new DataTable();
            string query =
                "SELECT * FROM car " +
                "WHERE carid = @carid";


            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand(query, DB.GetConnection());

            command.Parameters.AddWithValue("@carid", carid);
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
