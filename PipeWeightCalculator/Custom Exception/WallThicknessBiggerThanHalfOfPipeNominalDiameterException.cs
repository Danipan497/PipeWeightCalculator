using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeWeightCalculator.Custom_Exception
{
    [Serializable]
    public class WallThicknessBiggerThanHalfOfPipeNominalDiameterException : Exception
    {
        public WallThicknessBiggerThanHalfOfPipeNominalDiameterException()
        {

        }

        public WallThicknessBiggerThanHalfOfPipeNominalDiameterException(string message) : base(message)
        {

        }

        public WallThicknessBiggerThanHalfOfPipeNominalDiameterException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
