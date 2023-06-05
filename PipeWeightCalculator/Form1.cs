using System;
using PipeWeightCalculator.PipesProperties;
using PipeWeightCalculator.DataSets;
using PipeWeightCalculator.Mapping;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PipeWeightCalculator.Calculations;

namespace PipeWeightCalculator
{
    public partial class Form1 : Form
    {
        private readonly IPipe pipe;
        public Form1(IPipe pipe)
        {
            InitializeComponent();
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
            pipeNominalDiameterComboBox.DisplayMember = "name_pipe";
            pipeNominalDiameterComboBox.ValueMember = "value_pipe";

            var materialsTableDataSet = DataSetsGenerator.Materials();
            DataNamesMapper<PipeSettings> mapperMaterials = new DataNamesMapper<PipeSettings>();
            List<PipeSettings> materialsList = mapperMaterials.Map(materialsTableDataSet.Tables[0]).ToList();

            materialComboBox.DataSource = materialsList;
            materialComboBox.DisplayMember = "name_material";
            materialComboBox.ValueMember = "value_material";

            var wallThicknessTableDataSet = DataSetsGenerator.WallThickness();
            DataNamesMapper<PipeSettings> mapperWallThickness = new DataNamesMapper<PipeSettings>();
            List<PipeSettings> wallThicknessList = mapperWallThickness.Map(wallThicknessTableDataSet.Tables[0]).ToList();

            wallThicknessComboBox.DataSource = wallThicknessList;
            wallThicknessComboBox.DisplayMember = "name_wallthickness";
            wallThicknessComboBox.ValueMember = "value_wallthickness";
        }

        private void calculateButton1_Click(object sender, EventArgs e)
        {
            double.TryParse(pipeNominalDiameterComboBox.SelectedValue.ToString(), out double nominalDiameterValue);
            int.TryParse(materialComboBox.SelectedValue.ToString(), out int materialValue);
            double.TryParse(wallThicknessComboBox.SelectedValue.ToString(), out double wallThicknessValue);
            double.TryParse(pipeLengthTextBox1.Text, out double pipeLength);

            string result = pipe.CalculatePipeWeight(nominalDiameterValue, wallThicknessValue, pipeLength, materialValue);
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


