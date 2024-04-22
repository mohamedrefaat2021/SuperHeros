using Microsoft.AspNetCore.Mvc;
using MohamedRefaat_TechnicalTest.Application.DTOs;
using MohamedRefaat_TechnicalTest.Application.Interfaces;
using MohamedRefaat_TechnicalTest.Application.ServiceQueryParams;

namespace MohamedRefaat_TechnicalTest.Controllers
{
    [Route("api/Superhero")]
    [ApiController]
    public class SuperheroController : ControllerBase
    {

        private readonly ISuperheroService _superherosSvc;

        public SuperheroController(ISuperheroService SuperheroSvc)
        {
            _superherosSvc = SuperheroSvc;
        }



        [HttpPost("AddSuperhero")]
        public async Task<IActionResult> Create([FromBody] SuperheroDto createModel)
        
        {
            if (createModel == null)
                return BadRequest(ModelState);
            var res = await _superherosSvc.AddAsync(createModel);
            if (!res.Succeeded)
                return BadRequest(res);

            return Ok(res);
        }

       
      
        [HttpGet("GetSuperheros")]
        public async Task<IActionResult> Index(string superheroName)
        {
            string jsonResponse = "";
            try
            {
                 jsonResponse = await _superherosSvc.SearchSuperhero(superheroName);

                if (jsonResponse != null)
                {
                    return Content(jsonResponse, "application/json");
                }
               
            }
            catch (Exception ex)
            {
               
            }
            return Ok(jsonResponse);

        }
    }

}

