namespace Allaboutspace_API.DTO.Spacecraft
{
    public class SpacecraftFlightDTO:BaseDto<SpacecraftFlightDTO,Core.Models.Spacecraft.SpacecraftFlight>
    {
        public int id { get; set; }
        public string? destination { get; set; }
        public string? mission_end { get; set; }
        public SpacecraftDTO spacecraft { get; set; }
        public Launch.LaunchDTO launch { get; set; }
    }
}
