using dbonline.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace dbonline.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PersonajesController : ControllerBase
    {
        IPersonajesService PersonajesService { get; set; }

        public PersonajesController(IPersonajesService personajes)
        {
            PersonajesService = personajes;
        }

        [HttpGet]
        public IActionResult GetPersonajes()
        {
            return Ok(JsonSerializer.Serialize(PersonajesService.GetPersonajes().Result));
        }

        [HttpGet("byId")]
        public IActionResult GetPersonajeById([FromQuery] string id)
        {
            return Ok(JsonSerializer.Serialize(PersonajesService.GetPersonajeById(id).Result));
        }

        [HttpGet("byraza")]
        public IActionResult GetPersonajesByRaza([FromQuery] int id)
        {
            return Ok(JsonSerializer.Serialize(PersonajesService.GetPersonajesByRaza(id).Result));
        }

        [HttpGet("bysaga")]
        public IActionResult GetPersonajesBySaga([FromQuery] int id)
        {
            return Ok(JsonSerializer.Serialize(PersonajesService.GetPersonajesBySaga(id).Result));
        }

        [HttpGet("byserie")]
        public IActionResult GetPersonajesBySerie([FromQuery] int id)
        {
            return Ok(JsonSerializer.Serialize(PersonajesService.GetPersonajesBySerie(id).Result));
        }
    }
}
