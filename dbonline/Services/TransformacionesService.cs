using dbonline.Interfaces;
using dbonline.DTOs;
using Microsoft.EntityFrameworkCore;

namespace dbonline.Services
{
    public class TransformacionesService : ITransformacionesService
    {
        DbonlineContext dbonlineContext;

        public TransformacionesService(DbonlineContext context)
        {
            dbonlineContext = context;
        }

        public async Task<List<TransformacionesDTO>> GetTransformaciones()
        {
            return await dbonlineContext.PersonajesForma.Select(t => new TransformacionesDTO
            {
                IdTransformacion = t.PFId,
                PersonajeId = t.PersonajeId,
                transformacion = t.Nombre,
                Saga = t.Saga.SagaNombre,
                Raza = t.Raza.RazaNombre,
                Imagen = t.Imagen.url,
                Serie = t.Serie.SerieNombre
            }).ToListAsync();
        }
    }
}
