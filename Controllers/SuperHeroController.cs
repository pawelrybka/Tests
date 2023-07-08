using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Services.SuperHeroService;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> ReadAllHeroes()
        {
            return await _superHeroService.ReadAllHeroes();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> ReadSingleHero(int id)
        {
            var result = await _superHeroService.ReadSingleHero(id);
            if (result is null)
                return NotFound("SuperHero not found!");
            
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> CreateHero(SuperHero hero)
        {
            var result = await _superHeroService.CreateHero(hero);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero request)
        {
            var result = await _superHeroService.UpdateHero(id, request);
            if (result is null)
                return NotFound("SuperHero not found!");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var result = await _superHeroService.DeleteHero(id);
            if (result is null)
                return NotFound("SuperHero not found!");

            return Ok(result);
        }
    }
}
 