using dbonline.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace dbonline.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class RazasController : ControllerBase
    {
        IRazaService RazasService { get; set; }
        public RazasController(IRazaService razas)
        {
            RazasService = razas;
        }

        [HttpGet("{id}")]
        public IActionResult GetRazaById(Guid id)
        {
            return Ok(JsonSerializer.Serialize(RazasService.GetRazaById(id).Result));
        }
    }
}
