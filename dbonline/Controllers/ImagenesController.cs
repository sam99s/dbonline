using dbonline.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace dbonline.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ImagenesController : ControllerBase
    {
        IImagenService ImagenService { get; set; }

        public ImagenesController(IImagenService imagenes)
        {
            ImagenService = imagenes;
        }

        [HttpGet]
        public IActionResult GetImagenes()
        {
            return Ok(JsonSerializer.Serialize(ImagenService.GetImagenes().Result));
        }
    }
}
