namespace Core.Models.Launch
{
    public class Launch
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string? flightclub_url { get; set; }
        public string? r_spacex_api_id { get; set; }
        public string name { get; set; }
        public LaunchStatus status { get; set; }
        public string last_updated { get; set; }

        public IEnumerable<Update> updates { get; set; }

        public string? net { get; set; }
        public string? window_end { get; set; }
        public string? window_start { get; set; }
        public int? probability { get; set; }
        public string? holdreason { get; set; }
        public string? failreason { get; set; }
        public string? hashtag { get; set; }

        //public int launch_service_provider { get; set; }

        /** 
         * Many more properties to include. For now pausing it and keeping it in TODO list . 
         * 
         * **/
    }
}
