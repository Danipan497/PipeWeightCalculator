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
            string connectionString = ConfigurationManager.
                ConnectionStrings["PipeWeightCalculator.Properties.Settings.WeightConnectionString"].ConnectionString;
            string queryString = "SELECT * FROM dbo.Pipes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(queryString, connection);

                DataSet pipesTableDataSet = new DataSet();
                adapter.Fill(pipesTableDataSet);

                return pipesTableDataSet;
            }
        }
    }
}
