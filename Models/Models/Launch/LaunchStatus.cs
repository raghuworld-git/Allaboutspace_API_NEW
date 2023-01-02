using Core.Models.Common;

namespace Core.Models.Launch
{
    public class LaunchStatus : Status
    {
        public string abbrev { get; set; }
        public string description { get; set; }
    }
}
