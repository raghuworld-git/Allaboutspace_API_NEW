namespace Core.Models.Spacecraft
{
    public class SpacecraftFlight
    {
        public int id { get; set; }
        public string? destination { get; set; }
        public string? mission_end { get; set; }
        public Spacecraft spacecraft { get; set; }
        public Launch.Launch launch { get; set; }
    }
}
