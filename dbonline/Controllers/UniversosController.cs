using dbonline.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace dbonline.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UniversosController : ControllerBase
    {
        IUniversosService UniversosService { get; set; }
        public UniversosController(IUniversosService universo)
        {
            UniversosService = universo;
        }

        [HttpGet("{id}")]
        public IActionResult GetUniversoByPersonajeId(Guid id)
        {
            return Ok(JsonSerializer.Serialize(UniversosService.GetUniversoByPersonajeId(id).Result));
        }
    }
}
