using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeWeightCalculator.Custom_Exception
{
    public class WallThicknessBiggerThanPipeNominalDiameterException : Exception
    {
        public WallThicknessBiggerThanPipeNominalDiameterException()
        {

        }

        public WallThicknessBiggerThanPipeNominalDiameterException(string message) : base(message)
        {

        }

        public WallThicknessBiggerThanPipeNominalDiameterException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
