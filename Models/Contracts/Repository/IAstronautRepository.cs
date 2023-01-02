
using Core.Models.Astronaut;

namespace Core.Contracts.Repository
{
    public interface IAstronautRepository
    {
        Task<Astronaut?> GetAstronautByIdAsync(int astroId);
        Task<PaginatedResult<Astronaut>?> GetAstronautsAsync(int offset, int limit);
    }
}
