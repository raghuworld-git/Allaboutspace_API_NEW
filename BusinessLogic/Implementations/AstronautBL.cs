using Core;
using Core.Contracts.BusinessLogic;
using Core.Contracts.Repository;
using Core.Models.Astronaut;

namespace BusinessLogic.Implementations
{
    public class AstronautBL : IAstronautBL
    {
        private readonly IAstronautRepository _astronautRepo;
        public AstronautBL(IAstronautRepository astronautRepo)
        {
            _astronautRepo = astronautRepo;
        }
        public async Task<Astronaut?> GetAstronautByIdAsync(int astroId)
        {
            try
            {
                return await _astronautRepo.GetAstronautByIdAsync(astroId);
            }
            catch (CustomException ex)
            {
                throw new CustomException(ex);
            }
        }

        public async Task<PaginatedResult<Astronaut>?> GetAstronautsAsync(int page, int limit)
        {
            try
            {
                page = page < 0 ? 0 : page;
                return await _astronautRepo.GetAstronautsAsync(page * limit, limit);
            }
            catch (CustomException ex)
            {
                throw new CustomException(ex);
            }
        }
    }
}
