namespace Allaboutspace_API.DTO.Launch
{
    public class LaunchStatusDTO :BaseDto<LaunchStatusDTO,Core.Models.Launch.LaunchStatus>
    {
        public int id { get; set; }
        public string name { get; set; }
        public string abbrev { get; set; }
        public string description { get; set; }
    }
}
