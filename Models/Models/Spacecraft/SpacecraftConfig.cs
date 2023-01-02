using Core.Models.Common;


namespace Core.Models.Spacecraft
{
    public class SpacecraftConfig
    {
        public int id { get; set; }
        public string name { get; set; }
        public Status type { get; set; }
        public Core.Models.Agency.Agency agency { get; set; }
        public bool in_use { get; set; }
        public string? image_url { get; set; }
    }
}
