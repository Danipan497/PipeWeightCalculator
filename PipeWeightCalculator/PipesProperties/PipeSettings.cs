using PipeWeightCalculator.Attributes;

namespace PipeWeightCalculator.PipesProperties
{
    public class PipeSettings
    {
        [DataNames("id_pipe")]
        public string id_pipe { get; set; }

        [DataNames("name_pipe")]
        public string name_pipe { get; set; }

        [DataNames("value_pipe")]
        public string value_pipe { get; set; }

        [DataNames("id_material")]
        public string id_material { get; set; }

        [DataNames("name_material")]
        public string name_material { get; set; }

        [DataNames("value_material")]
        public string value_material { get; set; }

        [DataNames("id_wallthickness")]
        public string id_wallthickness { get; set; }

        [DataNames("name_wallthickness")]
        public string name_wallthickness { get; set; }

        [DataNames("value_wallthickness")]
        public string value_wallthickness { get; set; }
    }
}
