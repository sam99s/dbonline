using dbonline.DTOs;
using dbonline.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dbonline.Services
{
    public class SeriesService : ISeriesService
    {
        DbonlineContext dbonlineContext;

        public SeriesService(DbonlineContext context)
        {
            dbonlineContext = context;
        }

        public async Task<List<SerieDTO>> GetSerieByPersonajeId(Guid id)
        {
            return await dbonlineContext.Personajes.Where(p => p.PersonajeId == id).Select(x => new SerieDTO
            {
                Id = x.SerieId,
                Serie = x.Serie.SerieNombre
            }).ToListAsync();
        }
    }
}
