using dbonline.DTOs;
using dbonline.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dbonline.Services
{
    public class BatallasService : IBatallasService
    {
        DbonlineContext dbonlineContext;

        public BatallasService (DbonlineContext context)
        {
            dbonlineContext = context;
        }

        public async Task<List<BatallaDTO>> GetBatallas()
        {
            return await dbonlineContext.Batallas.Select(b => new BatallaDTO()
            {
                BatallaId = b.BatallaId,
                NombreBatalla = b.NombreBatalla,
                UrlBatalla = b.url,
                UrlImagen = b.Imagen.url,
                Saga = b.Saga.SagaNombre
            }).ToListAsync();
        }

        public async Task<List<BatallaDTO>> GetBatallasBySagaId(int id)
        {
            return await dbonlineContext.Batallas.Where(x => x.SagaId == id).Select(b => new BatallaDTO()
            {
                BatallaId = b.BatallaId,
                NombreBatalla = b.NombreBatalla,
                UrlBatalla = b.url,
                UrlImagen = b.Imagen.url,
                Saga = b.Saga.SagaNombre
            }).ToListAsync();
        }
    }
}
