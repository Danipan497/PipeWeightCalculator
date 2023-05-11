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

namespace PipeWeightCalculator.DatabaseConnection
{
    public class ConnectionToDatabase : IConnectionToDatabase
    {
        public SqlConnection cnn;
        string cnnString;

        public void PDatabase()
        {
            cnnString = ConfigurationManager.ConnectionStrings["PipeWeightCalculator.Properties.Settings.WeightConnectionString"].ConnectionString;
            using (cnn = new SqlConnection(cnnString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pipes", cnn))
            using (SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM Wallthickness", cnn))
            using (SqlDataAdapter adapter3 = new SqlDataAdapter("SELECT * FROM Materials", cnn))
            {


                cnn.Open();

                DataTable materialsTable = new DataTable();
                DataTable pipesTable = new DataTable();
                DataTable wallthicknessTable = new DataTable();
                adapter.Fill(pipesTable);
                adapter2.Fill(wallthicknessTable);
                adapter3.Fill(materialsTable);

            }
        }

        public List<String> JSONDataAll() //Tutaj obczaj czy może być to z JSON.
        {
            List<String> Pipes = new List<String>();
            cnnString = ConfigurationManager.ConnectionStrings["PipeWeightCalculator.Properties.Settings.WeightConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cnnString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Pipes", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pipes.Add(reader.GetString(0)); //Specify column index 
                        }
                    }
                }
            }
            return Pipes;
        }
    }
}
