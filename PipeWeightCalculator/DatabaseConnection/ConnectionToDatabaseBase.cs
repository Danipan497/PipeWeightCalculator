using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PipeWeightCalculator.DatabaseConnection
{
    public class ConnectionToDatabaseBase
    {
        SqlConnection cnn;
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

                //pipeNominalDiameterComboBox.DisplayMember = "Name";
                //pipeNominalDiameterComboBox.ValueMember = "NominalDiameter";
                //pipeNominalDiameterComboBox.DataSource = pipesTable;
                //pipeNominalDiameterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                //wallThicknessComboBox.DisplayMember = "Name";
                //wallThicknessComboBox.ValueMember = "Wall";
                //wallThicknessComboBox.DataSource = wallthicknessTable;
                //wallThicknessComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                //materialComboBox.DisplayMember = "Name";
                //materialComboBox.ValueMember = "Density";
                //materialComboBox.DataSource = materialsTable;
                //materialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }
    }
}