using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PipeWeightCalculator.Calculations;
using System.Configuration;
using System.Windows.Forms;

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

        public static DataSet WallThickness()
        {
            string connectionString = ConfigurationManager.
                ConnectionStrings["PipeWeightCalculator.Properties.Settings.WeightConnectionString"].ConnectionString;
            string queryString = "SELECT * FROM dbo.Wallthickness";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.SelectCommand = new SqlCommand(queryString, connection);

                DataSet wallThicknessTableDataSet = new DataSet();
                adapter.Fill(wallThicknessTableDataSet);

                return wallThicknessTableDataSet;
            }
        }
        public static DataSet Materials()
        {
            string connectionString = ConfigurationManager.
                ConnectionStrings["PipeWeightCalculator.Properties.Settings.WeightConnectionString"].ConnectionString;
            string queryString = "SELECT * FROM dbo.Materials";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.SelectCommand = new SqlCommand(queryString, connection);

                DataSet materialsTableDataSet = new DataSet();
                adapter.Fill(materialsTableDataSet);

                return materialsTableDataSet;
            }
        }
    }
}

