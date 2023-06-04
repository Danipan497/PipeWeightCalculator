using PipeWeightCalculator.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeWeightCalculator.PipesProperties
{
    public class PipeSettings
    {
        [DataNames("Id")]
        public string Id { get; set; }

        [DataNames("Name")]
        public string Name { get; set; }

        [DataNames("NominalDiameter")]
        public string NominalDiameter { get; set; } 
    }
}
