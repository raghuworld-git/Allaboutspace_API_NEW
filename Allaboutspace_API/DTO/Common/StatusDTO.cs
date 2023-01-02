namespace Allaboutspace_API.DTO.Common
{
    public class StatusDTO:BaseDto<StatusDTO,Core.Models.Common.Status>
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
