using dbonline.DTOs;
using dbonline.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dbonline.Services
{
    public class UniversosService : IUniversosService
    {
        DbonlineContext dbonlineContext;

        public UniversosService(DbonlineContext context)
        {
            dbonlineContext = context;
        }
        public async Task<List<UniversoDTO>> GetUniversoByPersonajeId(Guid id)
        {
            return await dbonlineContext.Personajes.Where(p => p.PersonajeId == id).Select(x => new UniversoDTO
            {
                Id = x.UniversoId,
                Universo = x.Universo.UniversoNombre
            }).ToListAsync();
        }
    }
}
