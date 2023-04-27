using PipeWeightCalculator.Custom_Exception;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            try
            {
                if (wallThickness > pipeNominalDiameter)
                {
                    //return "";
                    throw new WallThicknessBiggerThanPipeNominalDiameterException();

                }
                else if (wallThickness > pipeNominalDiameter / 2)
                {
                    throw new WallThicknessBiggerThanHalfOfPipeNominalDiameterException();
                }
                else
                {
                    double pipeMassResult1 = Math.Pow((pipeNominalDiameter / 1000) / 2, 2);
                    double pipeMassResult2 = Math.Pow(((pipeNominalDiameter / 1000) - 2 * (wallThickness / 1000)) / 2, 2);
                    double pipeMassResult = (pi * (pipeMassResult1 - pipeMassResult2) * pipeLength) * material;

                    return pipeMassResult.ToString("N3");
                }
            }
            catch (WallThicknessBiggerThanPipeNominalDiameterException)
            {
                return string.Empty;
                throw new WallThicknessBiggerThanPipeNominalDiameterException("Pipe wall thickness cannot be larger than outside diameter! Incorrect action!");
            }
            catch (WallThicknessBiggerThanHalfOfPipeNominalDiameterException)
            {
                return string.Empty;
                throw new WallThicknessBiggerThanHalfOfPipeNominalDiameterException("Pipe wall thickness cannot be larger than half of outside diameter! Incorrect action!");
            }

        }
    }
}


