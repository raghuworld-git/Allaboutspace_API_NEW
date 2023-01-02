using Core.Models.Astronaut;


namespace Core.Contracts.BusinessLogic
{
    public interface IAstronautBL
    {
        Task<Astronaut?> GetAstronautByIdAsync(int astroId);
        Task<Core.PaginatedResult<Astronaut>?> GetAstronautsAsync(int page, int limit);
    }
}
