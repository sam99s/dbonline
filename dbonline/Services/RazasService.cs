using dbonline.DTOs;
using dbonline.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dbonline.Services
{
    public class RazasService : IRazaService
    {
        DbonlineContext dbonlineContext;

        public RazasService(DbonlineContext context)
        {
            dbonlineContext = context;
        }

        public async Task<List<RazaDTO>> GetRazaById(Guid id)
        {
            return await dbonlineContext.Personajes.Where(p => p.PersonajeId == id).Select(x => new RazaDTO
            {
                RazaId = x.Raza.RazaId,
                RazaNombre = x.Raza.RazaNombre
            }).ToListAsync();
        }
    }
}
