using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PipeWeightCalculator
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["PipeWeightCalculator.Properties.Settings.WeightConnectionString"].ConnectionString;
        }
        double pi = Math.PI;
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDatabase();
  
        }

        public void PopulateDatabase()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pipes", connection))
            using (SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM Wallthickness", connection))
            using (SqlDataAdapter adapter3 = new SqlDataAdapter("SELECT * FROM Materials", connection))
            {
                connection.Open();

                DataTable materialsTable = new DataTable();
                DataTable pipesTable = new DataTable();
                DataTable wallthicknessTable = new DataTable();
                adapter.Fill(pipesTable);
                adapter2.Fill(wallthicknessTable);
                adapter3.Fill(materialsTable);

                pipeNominalDiameterComboBox.DisplayMember = "Name";
                pipeNominalDiameterComboBox.ValueMember = "NominalDiameter";
                pipeNominalDiameterComboBox.DataSource = pipesTable;
                pipeNominalDiameterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                wallThicknessComboBox.DisplayMember = "Name";
                wallThicknessComboBox.ValueMember = "Wall";
                wallThicknessComboBox.DataSource = wallthicknessTable;
                wallThicknessComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                materialComboBox.DisplayMember = "Name";
                materialComboBox.ValueMember = "Density";
                materialComboBox.DataSource = materialsTable;
                materialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void calculateButton1_Click(object sender, EventArgs e)
        {
            double pipeNominalDiameterComboBoxValue = (double)pipeNominalDiameterComboBox.SelectedValue;
            double wallThicknessComboBoxValue = (double)wallThicknessComboBox.SelectedValue;
            double pipeLength1 = Convert.ToDouble(pipeLengthTextBox1.Text);
            int materialComboBoxValue = Convert.ToInt32(materialComboBox.SelectedValue);
            double pipeMassResult1 = Math.Pow((pipeNominalDiameterComboBoxValue / 1000) / 2, 2);
            if (wallThicknessComboBoxValue > pipeNominalDiameterComboBoxValue || wallThicknessComboBoxValue > pipeNominalDiameterComboBoxValue / 2)
            {
                MessageBox.Show("Pipe wall thickness cannot be larger or equal to the half of the outside diameter! Incorrect action!");
            }
            else
            {
                double pipeMassResult2 = Math.Pow(((pipeNominalDiameterComboBoxValue / 1000) - 2 * (wallThicknessComboBoxValue / 1000)) / 2, 2);
                double pipeMassResult = (pi * (pipeMassResult1 - pipeMassResult2) * pipeLength1) * materialComboBoxValue;
                pipeMassResultLabel1.Text = pipeMassResult.ToString("N3");
            }
        }

        private void calculateButton2_Click(object sender, EventArgs e)
        {
            double pipeNominalDiameter = Convert.ToDouble(pipeNominalDiameterTextBox.Text);
            double wallThickness = Convert.ToDouble(wallThicknessTextBox.Text);
            double pipeLength2 = Convert.ToDouble(pipeLengthTextBox.Text);
            int materialComboBoxValue = Convert.ToInt32(materialComboBox.SelectedValue); //Ta wartość pobiera z comboBox.
            double pipeMassResult1 = Math.Pow((pipeNominalDiameter / 1000) / 2, 2);

            if (wallThickness > pipeNominalDiameter || wallThickness == pipeNominalDiameter / 2)
            {
                MessageBox.Show("Pipe wall thickness cannot be larger or equal to the half of the outside diameter! Incorrect action!");
            }
            else
            {
                double pipeMassResult2 = Math.Pow(((pipeNominalDiameter / 1000) - 2 * (wallThickness / 1000)) / 2, 2);
                double pipeMassResult = (pi * (pipeMassResult1 - pipeMassResult2) * pipeLength2) * materialComboBoxValue;
                pipeMassResultLabel2.Text = pipeMassResult.ToString("N3");
            }
        }

        private void pipeNominalDiameterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void wallThicknessTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void pipeLengthTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void pipeLengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
