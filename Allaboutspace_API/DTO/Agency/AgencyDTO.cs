

namespace Allaboutspace_API.DTO.Agency
{
    public class AgencyDTO :BaseDto<AgencyDTO, Core.Models.Agency.Agency>
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? type { get; set; }
    }
}
