using dbonline.Interfaces;
using dbonline.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace dbonline.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TransformacionesController : ControllerBase
    {
        ITransformacionesService TransformacionesService { get; set; }
        public TransformacionesController(ITransformacionesService transformaciones)
        {
            TransformacionesService = transformaciones;
        }
        [HttpGet]
        public IActionResult GetTransformaciones()
        {
            return Ok(JsonSerializer.Serialize(TransformacionesService.GetTransformaciones().Result));
        }
    }
}
