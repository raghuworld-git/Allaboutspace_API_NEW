namespace Core.Contracts.Repository
{
    public interface IConfigurationRepository
    {
        public string GetSpaceDevLaunchURL();
        public string? GetConfigValueByKey(string key);
        public string GetNASAApodURL();

    }
}
