using Core.Models.Common;

namespace Core.Models.Spacecraft
{
    public class Spacecraft
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? serial_number { get; set; }
        public Status status { get; set; }
        public string? description { get; set; }

        public SpacecraftConfig spacecraft_config { get; set; }
    }
}
