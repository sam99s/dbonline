using dbonline.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace dbonline.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class BatallasController : ControllerBase
    {
        IBatallasService BatallasService { get; set; }

        public BatallasController(IBatallasService batallas)
        {
            BatallasService = batallas;
        }

        [HttpGet]
        public IActionResult GetBatallas()
        {
            return Ok(JsonSerializer.Serialize(BatallasService.GetBatallas().Result));
        }

        [HttpGet("bysaga")]
        public IActionResult GetBatallasBySagaId([FromQuery]int id)
        {
            return Ok(JsonSerializer.Serialize(BatallasService.GetBatallasBySagaId(id).Result));
        }
    }
}
