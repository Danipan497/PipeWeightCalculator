using PipeWeightCalculator.Dtos;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace PipeWeightCalculator.DatabaseConnection
{
    public class ConnectionToDatabase : IConnectionToDatabase
    {
        private static string connectionString= "PipeWeightCalculator.Properties.Settings.WeightConnectionString";
        SqlConnection Connection;
        string ConnectionStringForDatabase;

        public ConnectionToDatabase()
        {

        }

        public PipesPropertiesDto PopulateDatabase()
        {
            string ConnectionStringForDatabase = ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;

            var listOfPipes = GetPipes(ConnectionStringForDatabase);

          

            GetWallthickness(ConnectionStringForDatabase);
            GetMaterial(ConnectionStringForDatabase);

            return new PipesPropertiesDto()
            {
                Pipes = listOfPipes,

            };
        }

        public List<PipesDto> GetPipes(string connectionStringForDatabase)
        {
            List<PipesDto> listOfPipes=new List<PipesDto>();
            using (Connection = new SqlConnection(connectionStringForDatabase))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pipes", Connection))
            {
                Connection.Open();
                DataTable pipesTable = new DataTable();
                var filledTable=adapter.Fill(pipesTable); 
                foreach(var row in pipesTable.Rows)
                {
                    pipesTable.Rows.Add(row);
                    //listOfPipes Mappowanie albo reflexion. Moze convert na json. Dbcontex.
                }
                return listOfPipes;
            }
            
        }

        public void GetWallthickness(string connectionStringForDatabase)
        {
            using (Connection = new SqlConnection(connectionStringForDatabase))
            using (SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM Wallthickness", Connection))
            {
                Connection.Open();
                DataTable wallthicknessTable = new DataTable();
                adapter2.Fill(wallthicknessTable);
            }
        }

        public void GetMaterial(string connectionStringForDatabase)
        {
            using (Connection = new SqlConnection(connectionStringForDatabase))
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