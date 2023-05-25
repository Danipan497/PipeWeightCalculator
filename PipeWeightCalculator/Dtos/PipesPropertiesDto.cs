using System.Collections.Generic;

namespace PipeWeightCalculator.Dtos
{
    public class PipesPropertiesDto
    {
        public List<PipesDto> Pipes { get; set; }
        public List<string> WallThickness { get; set; }
        public List<string> Material { get; set; }

    }
}
