using dbonline.DTOs;
using dbonline.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dbonline.Services
{
    public class SagasService : ISagasService
    {
        DbonlineContext dbonlineContext;

        public SagasService(DbonlineContext context)
        {
            dbonlineContext = context;
        }

        public async Task<List<SagaDTO>> GetSagaByPersonajeId(Guid id)
        {
            return await dbonlineContext.Personajes.Where(p => p.PersonajeId == id).Select(x => new SagaDTO
            {
                SagaId = x.SagaId,
                SagaNombre = x.Saga.SagaNombre
            }).ToListAsync();
        }
    }
}
