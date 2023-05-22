using PipeWeightCalculator.Calculations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeWeightCalculator.DatabaseConnection;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Net.Mail;
using System.Drawing.Text;
using System.Diagnostics;
using PipeWeightCalculator.WeightDataSetTableAdapters;

namespace PipeWeightCalculator.DatabaseConnection
{
    public class ConnectionToDatabase
    {
        //public SqlConnection connection;
        //string connectionString;
        public string ConnectionString { get; set; }
        public SqlConnection Connection { get; set; }

        public ConnectionToDatabase(string connectionString, SqlConnection connection)
        {
            this.ConnectionString = connectionString;
            this.Connection = connection;
            GetPipes();
            GetWallthickness();
            GetMaterial();
        }

        public void PopulateDatabase()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["PipeWeightCalculator.Properties.Settings.WeightConnectionString"].ConnectionString;
        }

        public void GetPipes()
        {
            using (Connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pipes", Connection))
            {
                Connection.Open();
                DataTable pipesTable = new DataTable();
                adapter.Fill(pipesTable);
            }
        }

        public void GetWallthickness()
        {
            using (Connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM Wallthickness", Connection))
            {
                Connection.Open();
                DataTable wallthicknessTable = new DataTable();
                adapter2.Fill(wallthicknessTable);
            }
        }

        public void GetMaterial()
        {
            using (Connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter3 = new SqlDataAdapter("SELECT * FROM Materials", Connection))
            {
                Connection.Open();
                DataTable materialsTable = new DataTable();
                adapter3.Fill(materialsTable);
            }
        }
    }
}

        //private DataTable pipesTableTry;

        //public DataTable PipesTableTry
        //{
        //    get
        //    {
        //        return pipesTableTry;
        //    }
        //    set
        //    {
        //        connectionString = ConfigurationManager.ConnectionStrings["PipeWeightCalculator.Properties.Settings.WeightConnectionString"].ConnectionString;
        //        using (connection = new SqlConnection(connectionString))
        //        using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pipes", connection))
        //        {
        //            connection.Open();
        //            DataTable pipesTable = new DataTable();
        //            adapter.Fill(pipesTable);

        //            pipesTableTry = pipesTable;
        //        }
        //    }
        //}