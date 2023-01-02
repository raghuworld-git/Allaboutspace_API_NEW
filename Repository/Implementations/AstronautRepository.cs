using Core.Contracts.Repository;
using Core.Models.Astronaut;
using Core;

namespace Repository.Implementations
{
    public class AstronautRepository : IAstronautRepository
    {        
        private string baseURL;
        private string astronautURL;

        private readonly IConfigurationRepository _configRepo;
        private readonly IHttpWrapper _httpClient;
       public AstronautRepository(IConfigurationRepository configRepo,IHttpWrapper httpClient)
        {
            _configRepo = configRepo;
            _httpClient = httpClient;
            baseURL = _configRepo.GetSpaceDevLaunchURL();
            astronautURL = $"{baseURL}{Constants.astronaut_action}";
        }
        public async Task<Astronaut?> GetAstronautByIdAsync(int astroId)
        {
            try
            {
              return await _httpClient.GetAsync<Astronaut>($"{astronautURL}/{astroId}");              

            }           
            catch (CustomException ex)
            {
                throw new CustomException(ex);
            }
        }     
        public async Task<PaginatedResult<Astronaut>?> GetAstronautsAsync(int offset, int limit)
        {
            try
            {
                return await _httpClient.GetAsyncWithQueryParams<PaginatedResult<Astronaut>>(astronautURL, (new { limit, offset }));               
            }
            catch (CustomException ex)
            {
                throw new CustomException(ex);
            }
        }
    }
}
