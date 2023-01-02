using Allaboutspace_API.DTO.Common;

namespace Allaboutspace_API.DTO.Spacecraft
{
    public class SpacecraftDTO :BaseDto<SpacecraftDTO,Core.Models.Spacecraft.Spacecraft>
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? serial_number { get; set; }
        public StatusDTO status { get; set; }
        public string? description { get; set; }

        public SpacecraftConfigDTO spacecraft_config { get; set; }
    }
}
