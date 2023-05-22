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
using PipeWeightCalculator.DatabaseConnection;
using System.Drawing.Text;
using PipeWeightCalculator.WeightDataSetTableAdapters;
using System.Reflection;

namespace PipeWeightCalculator
{
    public partial class Form1 : Form
    {
        private readonly IPipe pipe;
        private ConnectionToDatabase connectionToDatabase;
        
        public Form1(IPipe pipe)
        {
            InitializeComponent();
            this.pipe = pipe;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void pipeNominalDiameterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}


