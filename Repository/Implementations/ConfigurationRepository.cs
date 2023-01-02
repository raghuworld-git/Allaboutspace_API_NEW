using Core.Contracts.Repository;
using Microsoft.Extensions.Configuration;

namespace Repository.Implementations
{
    public class ConfigurationRepository : IConfigurationRepository
    {
        private readonly IConfiguration _config;
       public ConfigurationRepository(IConfiguration config)
        {
            _config = config;
        }
        public string? GetConfigValueByKey(string key)
        {
            return _config.GetSection(key).Value;
        }

        public string GetNASAApodURL()
        {
            var apikey = GetConfigValueByKey(Constants.nasaAPI_Key);
            var nasaAPODURL = GetConfigValueByKey(Constants.nasaApodURL);
            try
            {
                if(string.IsNullOrEmpty(apikey) || string.IsNullOrEmpty(nasaAPODURL))
                {
                    throw new NullReferenceException("Null value thrown  while fetching config data");
                }

                return $"{nasaAPODURL}?api_key={apikey}";
            }
            catch(Exception ex)
            {
                throw new Exception("Unable to fetch from GetNASAApodURL", ex.InnerException);
            }           
        }

        public string GetSpaceDevLaunchURL()
        {
            var isPROD = GetConfigValueByKey(Constants.isPROD);
            try
            {

                string? result;
                if ((isPROD != null || isPROD?.Trim() != string.Empty) && Boolean.Parse(isPROD!))
                {
                    result = _config.GetSection(Constants.spacedevLaunchApiUrlPROD).Value;
                }
                result = _config.GetSection(Constants.spacedevLaunchApiUrl).Value;

                if (string.IsNullOrEmpty(result))
                {
                    throw new NullReferenceException("Null value thrown  while fetching config data");
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to fetch from GetSpaceDevLaunchURL", ex.InnerException);
            }
        }
    }
}
