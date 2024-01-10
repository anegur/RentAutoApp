using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Npgsql;
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
    public partial class ClientFullForm : Form
    {
        int currentClient;
        public ClientFullForm()
        {
            currentClient = 1;
            InitializeComponent();
            FormClosing += Form_FormClosing;
        }

        public ClientFullForm(string clientid)
        {
            string strCurrClient = clientid;
            int.TryParse(strCurrClient, out currentClient);
            InitializeComponent();
            FormClosing += Form_FormClosing;
        }
        private void Form_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ClientFullForm_Load(object sender, EventArgs e)
        {
            clientRentDGV.DataSource = GetClientRent();
            freeCarDGV.DataSource = GetFreeCar();
            feeCostDGV.DataSource = GetFeeCost();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private DataTable GetFeeCost()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;
            DataTable table = new DataTable();

            string query = "SELECT name, cost FROM Fee";
            DB.openConnection();

            command = new NpgsqlCommand(query, DB.GetConnection());
            //command.Parameters.AddWithValue("@clientid", currentClient);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DB.closeConnection();

            return table;
        }

        private DataTable GetFreeCar()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;
            DataTable table = new DataTable();

            string query = "SELECT Car.model, Car.release_year, Fee.name "+
                "FROM Car "+ 
                "JOIN Fee ON car.feeID = fee.feeID "+
                "WHERE Car.access = 1;";
            DB.openConnection();

            command = new NpgsqlCommand(query, DB.GetConnection());
            //command.Parameters.AddWithValue("@clientid", currentClient);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DB.closeConnection();

            return table;
        }

        private DataTable GetClientRent()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;
            DataTable table = new DataTable();

            string query = "SELECT Car.model, Rent.start_date, Rent.end_date, ((Rent.end_date - Rent.start_date) * Fee.cost) AS total_fee " +
                "FROM Rent " +
                "JOIN Car ON Rent.carID = Car.carID " +
                "JOIN Fee ON Car.feeID = Fee.feeID " +
                "JOIN Client ON Rent.clientID = Client.clientID " +
                "WHERE Rent.clientid = @clientid";
            DB.openConnection();

            command = new NpgsqlCommand(query, DB.GetConnection());
            command.Parameters.AddWithValue("@clientid", currentClient);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DB.closeConnection();

            return table;
        }
    }
}
