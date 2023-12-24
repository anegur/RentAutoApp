using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WinFormsApp1
{
    public static class DB
    {
        static string DBconnect = "Server=localhost; Port=5432; User Id=postgres; Database=CarRentalServiceDB";
        static NpgsqlConnection conn = new NpgsqlConnection(DBconnect);

        public static void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public static void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public static NpgsqlConnection GetConnection()
        {
            return conn;
        }
    }
}
