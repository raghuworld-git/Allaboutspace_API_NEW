using Core.Models.Common;
using Core.Models.Spacecraft;

namespace Core.Models.Astronaut
{
    public class Astronaut
    {
        public int id { get; set; }
        public string name { get; set; }
        public Status status { get; set; }

        public Status type { get; set; }

        public Core.Models.Agency.Agency agency { get; set; }
        public int? age { get; set; }
        public string? date_of_birth { get; set; }
        public string? date_of_death { get; set; }
        public string nationality { get; set; }
        public string? twitter { get; set; }
        public string? instagram { get; set; }
        public string bio { get; set; }
        public string? profile_image { get; set; }
        public string? profile_image_thumbnail { get; set; }
        public string? wiki { get; set; }
        public IEnumerable<Launch.Launch> flights { get; set; }
        public IEnumerable<SpacecraftFlight> landings { get; set; }
        public int? flights_count { get; set; }
        public int? landings_count { get; set; }
        public string? last_flight { get; set; }
        public string? first_flight { get; set; }

    }
}
