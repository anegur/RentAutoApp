using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class ClientTable
    {
        
            static DataTable table = new DataTable();

            public static DataTable GetTable()
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
                NpgsqlCommand command;

                table.Clear();

                string query = "SELECT * FROM client";
                table.Clear();
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                DB.closeConnection();

                return table;
            }
            public static bool Insert(string fio, string phone_n, string email, string password)
            {
                NpgsqlCommand command;
                string query =
                    "INSERT INTO client (fio, phone_number, email, password) " +
                    "VALUES (@fio, @phone_n, @email, @password)";

                try
                {
                    DB.openConnection();

                    command = new NpgsqlCommand(query, DB.GetConnection());
                    command.Parameters.AddWithValue("@fio", fio);
                    command.Parameters.AddWithValue("@phone_n", phone_n);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

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

            public static bool Update(int clientid, string fio, string phone_n, string email, string password)
            {
                NpgsqlCommand command;
                string query =
                    "UPDATE client SET fio = @fio, phone_number = @phone_n, email = @email, password = @password " +
                    "WHERE clientid = @clientid";

                //try
                //{
                    DB.openConnection();

                    command = new NpgsqlCommand(query, DB.GetConnection());
                    command.Parameters.AddWithValue("@clientid", clientid);
                    command.Parameters.AddWithValue("@fio", fio);
                    command.Parameters.AddWithValue("@phone_n", phone_n);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);


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
                //}
                //catch
                //{
                //    DB.closeConnection();
                //    MessageBox.Show("Ошибка при редактировании данных");
                //    return false;
                //}
            }
            public static void Delete(int clientid)
            {
                NpgsqlCommand command;
                string query =
                    "DELETE FROM client " +
                    "WHERE clientid = @clientid";

                try
                {
                    DB.openConnection();

                    command = new NpgsqlCommand(query, DB.GetConnection());
                    command.Parameters.AddWithValue("@clientid", clientid);
                    command.ExecuteNonQuery();

                    DB.closeConnection();
                }
                catch
                {
                    DB.closeConnection();
                }
            }

            public static bool IsExistsDriver(int clientid)
            {
                DataTable dataTableQuery = new DataTable();
                string query =
                    "SELECT * FROM client " +
                    "WHERE clientid = @clientid";


                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
                NpgsqlCommand command = new NpgsqlCommand(query, DB.GetConnection());

                command.Parameters.AddWithValue("@clientid", clientid);
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
