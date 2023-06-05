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

        [DataNames("id_materials")]
        public string id_materials { get; set; }

        [DataNames("material_name")]
        public string material_name { get; set; }

        [DataNames("material_density")]
        public string material_density { get; set; }

        [DataNames("id_wallthickness")]
        public string id_wallthickness { get; set; }

        [DataNames("name_wallthickness")]
        public string name_wallthickness { get; set; }

        [DataNames("value_wallthickness")]
        public string value_wallthickness { get; set; }
    }
}
