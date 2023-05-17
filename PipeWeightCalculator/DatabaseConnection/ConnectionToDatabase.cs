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

namespace PipeWeightCalculator.DatabaseConnection
{
    public class ConnectionToDatabase
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

                for (int i = 0; i < pipesTable.Rows.Count; i++)
                {
                    var pipesTableRowsName = pipesTable.Rows[i]["Name"].ToString();
                    var pipesTableRowsNominalDiameter = pipesTable.Rows[i]["NominalDiameter"].ToString();
                }
            }
        }

        

        private string getWallthickness;
        public string GetWallthickness { get { return getWallthickness; } set { getWallthickness = value; } }
    }
}
