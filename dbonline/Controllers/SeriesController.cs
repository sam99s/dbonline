using dbonline.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace dbonline.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class SeriesController : ControllerBase
    {
        ISeriesService SeriesService { get; set; }

        public SeriesController(ISeriesService series)
        {
            SeriesService = series;
        }

        [HttpGet("{id}")]
        public IActionResult GetSerieByPersonajeId(Guid id)
        {
            return Ok(JsonSerializer.Serialize(SeriesService.GetSerieByPersonajeId(id).Result));
        }
    }
}
