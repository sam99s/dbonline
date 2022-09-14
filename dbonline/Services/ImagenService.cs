using dbonline.DTOs;
using dbonline.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dbonline.Services
{
    public class ImagenService : IImagenService
    {
        DbonlineContext dbonlineContext;

        public ImagenService(DbonlineContext context)
        {
            dbonlineContext = context;
        }

        public async Task<List<ImagenDTO>> GetImagenes()
        {
            //se puede hacer tambien a traves de navegación desde la tabla personaje. Es a modo demostración.
            var personajes = await (from imagen in dbonlineContext.Imagenes
                        join personaje in dbonlineContext.Personajes
                        on imagen.ImagenId equals personaje.ImagenId
                        select new ImagenDTO
                        {
                            id = imagen.ImagenId,
                            personaje = personaje.Nombre,
                            url = imagen.url
                        }).ToListAsync();

            var transformaciones = await dbonlineContext.PersonajesForma.Select(i => new ImagenDTO
            {
                id = i.ImagenId,
                personaje = i.Nombre,
                url = i.Imagen.url
            }).ToListAsync();

            List<ImagenDTO> result = new List<ImagenDTO>();
            foreach (var imagen in personajes)
            {
                result.Add(imagen);
            }
            foreach (var imagen in transformaciones)
            {
                result.Add(imagen);
            }
            return result;
        }
    }
}
