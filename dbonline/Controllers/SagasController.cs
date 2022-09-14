using dbonline.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace dbonline.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class SagasController : ControllerBase
    {
        ISagasService SagasService { get; set; }
        public SagasController(ISagasService sagas)
        {
            SagasService = sagas;
        }

        [HttpGet("{id}")]
        public IActionResult GetSagaByPersonajeId(Guid id)
        {
            return Ok(JsonSerializer.Serialize(SagasService.GetSagaByPersonajeId(id).Result));
        }
    }
}
