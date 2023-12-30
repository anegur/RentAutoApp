using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class RentTable
    {
        static DataTable table = new DataTable();

        public static DataTable GetTable()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;

            table.Clear();

            string query = "SELECT * FROM rent";
            table.Clear();
            DB.openConnection();

            command = new NpgsqlCommand(query, DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DB.closeConnection();

            return table;
        }

        public static bool Insert(int clientid, int employeeid, int carid, DateTime start_date, DateTime end_date)
        {
            NpgsqlCommand command;
            string query =
                "INSERT INTO driver (employeeid, carid, start_date, end_date) " +
                "VALUES (@clientid, @employeeid, @carid, @start_date, @end_date)";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@clientid", clientid);
                command.Parameters.AddWithValue("@employeeid", employeeid);
                command.Parameters.AddWithValue("@carid", carid);
                command.Parameters.AddWithValue("@start_date", start_date);
                command.Parameters.AddWithValue("@end_date", end_date);

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


        public static bool Update(int rentid, int clientid, int employeeid, int carid, DateTime start_date, DateTime end_date)
        {
            NpgsqlCommand command;
            string query =
                "UPDATE driver SET clientid = @clientid, employeeid = @employeeid, carid = @carid, start_date = @start_date, end_date = @end_date " +
                "WHERE rentid = @rentid";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@rentid", rentid);
                command.Parameters.AddWithValue("@clientid", clientid);
                command.Parameters.AddWithValue("@employeeid", employeeid);
                command.Parameters.AddWithValue("@carid", carid);
                command.Parameters.AddWithValue("@start_date", start_date);
                command.Parameters.AddWithValue("@end_date", end_date);

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

        
        public static void Delete(int rentid)
        {
            NpgsqlCommand command;
            string query =
                "DELETE FROM rent " +
                "WHERE rentid = @rentid";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@rentid", rentid);
                command.ExecuteNonQuery();

                DB.closeConnection();
            }
            catch
            {
                DB.closeConnection();
            }
        }

        public static bool IsExistsDriver(int rentid)
        {
            DataTable dataTableQuery = new DataTable();
            string query =
                "SELECT * FROM rent " +
                "WHERE rentid = @rentid";


            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand(query, DB.GetConnection());

            command.Parameters.AddWithValue("@rentid", rentid);
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
