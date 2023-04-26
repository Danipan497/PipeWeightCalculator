using PipeWeightCalculator.Custom_Exception;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeWeightCalculator.Calculations
{
    public class Pipe : IPipe
    {
        double pi = Math.PI;
        public string CalculatePipeWeight(double pipeNominalDiameter, double wallThickness, double pipeLength, int material)
        {
            //if (wallThickness > pipeNominalDiameter || wallThickness > pipeNominalDiameter / 2)
            //{
            //    //MessageBox.Show("Pipe wall thickness cannot be larger or equal to the half of the outside diameter! Incorrect action!");

            //    return "";
            //}
            //else
            //{
            //    double pipeMassResult1 = Math.Pow((pipeNominalDiameter / 1000) / 2, 2);
            //    double pipeMassResult2 = Math.Pow(((pipeNominalDiameter / 1000) - 2 * (wallThickness / 1000)) / 2, 2);
            //    double pipeMassResult = (pi * (pipeMassResult1 - pipeMassResult2) * pipeLength) * material;

            //    return pipeMassResult.ToString("N3");
            //}

            if (wallThickness > pipeNominalDiameter)
            {
                throw new WallThicknessBiggerThanPipeNominalDiameterException("Pipe wall thickness cannot be larger than outside diameter! Incorrect action!");
            }
            else if (wallThickness > pipeNominalDiameter / 2)
            {
                throw new WallThicknessBiggerThanHalfOfPipeNominalDiameterException("Pipe wall thickness cannot be larger than half of outside diameter! Incorrect action!");
            }
            else
            {
                double pipeMassResult1 = Math.Pow((pipeNominalDiameter / 1000) / 2, 2);
                double pipeMassResult2 = Math.Pow(((pipeNominalDiameter / 1000) - 2 * (wallThickness / 1000)) / 2, 2);
                double pipeMassResult = (pi * (pipeMassResult1 - pipeMassResult2) * pipeLength) * material;

                return pipeMassResult.ToString("N3");
            }

        }
    }
}


