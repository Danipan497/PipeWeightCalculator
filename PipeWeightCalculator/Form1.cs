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
using PipeWeightCalculator.Calculations;

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
            string result = pipe.CalculatePipeWeight((double)pipeNominalDiameterComboBox.SelectedValue, (double)wallThicknessComboBox.SelectedValue,
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


