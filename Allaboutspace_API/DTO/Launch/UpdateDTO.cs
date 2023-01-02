namespace Allaboutspace_API.DTO.Launch
{
    public class UpdateDTO:BaseDto<UpdateDTO,Core.Models.Launch.Update>
    {
        public int id { get; set; }
        public string profile_image { get; set; }
        public string? comment { get; set; }
        public string? info_url { get; set; }
        public string created_by { get; set; }
        public string created_on { get; set; }

    }
}
