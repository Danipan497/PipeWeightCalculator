using System;
using PipeWeightCalculator.PipesProperties;
using PipeWeightCalculator.DataSets;
using PipeWeightCalculator.Mapping;
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
using PipeWeightCalculator.Calculations;
using PipeWeightCalculator.WeightDataSetTableAdapters;

namespace PipeWeightCalculator
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString;
        private readonly IPipe pipe;
        public Form1(IPipe pipe)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["PipeWeightCalculator.Properties.Settings.WeightConnectionString"].ConnectionString;
            this.pipe = pipe;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDatabase();
        }

        public void PopulateDatabase()
        {
            var pipesTableDataSet = DataSetsGenerator.Pipes();
            DataNamesMapper<PipeSettings> mapperPipes = new DataNamesMapper<PipeSettings>();
            List<PipeSettings> pipesList = mapperPipes.Map(pipesTableDataSet.Tables[0]).ToList();

            pipeNominalDiameterComboBox.DataSource = pipesList;
            pipeNominalDiameterComboBox.DisplayMember = "Name";
            pipeNominalDiameterComboBox.ValueMember = "NominalDiameter";

            using (connection = new SqlConnection(connectionString))

            using (SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM Wallthickness", connection))
            using (SqlDataAdapter adapter3 = new SqlDataAdapter("SELECT * FROM Materials", connection))
            {
                connection.Open();

                DataTable materialsTable = new DataTable();

                DataTable wallthicknessTable = new DataTable();

                adapter2.Fill(wallthicknessTable);
                adapter3.Fill(materialsTable);

                pipeNominalDiameterComboBox.DisplayMember = "Name";
                pipeNominalDiameterComboBox.ValueMember = "NominalDiameter";

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
            double.TryParse(pipeNominalDiameterComboBox.SelectedValue.ToString(), out double nominalDiameterValue);

            string result = pipe.CalculatePipeWeight(nominalDiameterValue, (double)wallThicknessComboBox.SelectedValue,
                                    Convert.ToDouble(pipeLengthTextBox1.Text), Convert.ToInt32(materialComboBox.SelectedValue));
            pipeMassResultLabel1.Text = result;
        }

        private void calculateButton2_Click(object sender, EventArgs e)
        {
            string result = pipe.CalculatePipeWeight(Convert.ToDouble(pipeNominalDiameterTextBox.Text), Convert.ToDouble(wallThicknessTextBox.Text),
                                                    Convert.ToDouble(pipeLengthTextBox.Text), Convert.ToInt32(materialComboBox.SelectedValue));
            pipeMassResultLabel2.Text = result;
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


