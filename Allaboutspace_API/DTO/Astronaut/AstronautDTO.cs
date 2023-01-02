using Allaboutspace_API.DTO.Common;
using Allaboutspace_API.DTO.Spacecraft;

namespace Allaboutspace_API.DTO.Astronaut
{
    public class AstronautDTO: BaseDto<AstronautDTO,Core.Models.Astronaut.Astronaut>
    {
        public int id { get; set; }
        public string name { get; set; }
        public StatusDTO status { get; set; }

        public StatusDTO type { get; set; }

        public Agency.AgencyDTO agency { get; set; }
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
        public IEnumerable<Launch.LaunchDTO> flights { get; set; }
        public IEnumerable<SpacecraftFlightDTO> landings { get; set; }
        public int? flights_count { get; set; }
        public int? landings_count { get; set; }
        public string? last_flight { get; set; }
        public string? first_flight { get; set; }

    }
}
