
using Microsoft.AspNetCore.Mvc;
using Mapster;
using Allaboutspace_API.DTO.Astronaut;
using Core.Contracts.BusinessLogic;

namespace Allaboutspace_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AstronautController : ControllerBase
    {
        private readonly IAstronautBL _astronautBL;
        public AstronautController(IAstronautBL astronautBL)
        {
            _astronautBL = astronautBL;
        }

        [HttpGet]
        [Route("[action]/{astroId:int}")]
        public async Task<ActionResult<AstronautDTO>> GetAstronautById(int astroId)
        {
            var astronaut = await _astronautBL.GetAstronautByIdAsync(astroId);
                       

            if (astronaut != null)
            {
                return Ok(astronaut.Adapt<AstronautDTO>());
            }

            return NotFound();
        }
    }
}
