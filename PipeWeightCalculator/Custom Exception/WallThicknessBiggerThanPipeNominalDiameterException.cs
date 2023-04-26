using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeWeightCalculator.Custom_Exception
{
    [Serializable]
    public class WallThicknessBiggerThanPipeNominalDiameterException : Exception
    {
        public WallThicknessBiggerThanPipeNominalDiameterException()
        {
          
        }

        public WallThicknessBiggerThanPipeNominalDiameterException(string message) : base(message)
        {
            
        }

        public WallThicknessBiggerThanPipeNominalDiameterException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
