namespace Allaboutspace_API.DTO.Spacecraft
{
    public class SpacecraftConfigDTO:BaseDto<SpacecraftConfigDTO,Core.Models.Spacecraft.SpacecraftConfig>
    {
        public int id { get; set; }
        public string name { get; set; }
        public Common.StatusDTO type { get; set; }
        public Agency.AgencyDTO agency { get; set; }
        public bool in_use { get; set; }
        public string? image_url { get; set; }
    }
}
