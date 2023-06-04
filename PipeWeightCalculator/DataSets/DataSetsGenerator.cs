using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PipeWeightCalculator.Calculations;
using System.Configuration;

namespace PipeWeightCalculator.DataSets
{
    public class DataSetsGenerator
    {

        public static DataSet Pipes()
        {
            SqlConnection connection;
            string connectionString;
            connectionString = ConfigurationManager.
                ConnectionStrings["PipeWeightCalculator.Properties.Settings.WeightConnectionString"].ConnectionString;

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pipes", connection))
            {
                connection.Open();

                DataTable pipesTable = new DataTable();

                DataSet pipesTableDataSet = new DataSet();
                pipesTableDataSet.Tables.Add(pipesTable);

                return pipesTableDataSet;
            }
        }
    }
}
