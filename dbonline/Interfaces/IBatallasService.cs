using dbonline.DTOs;

namespace dbonline.Interfaces
{
    public interface IBatallasService
    {
        Task<List<BatallaDTO>> GetBatallas();
        Task<List<BatallaDTO>> GetBatallasBySagaId(int id);
    }
}
