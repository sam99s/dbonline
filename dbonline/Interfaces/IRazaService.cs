using dbonline.DTOs;

namespace dbonline.Interfaces
{
    public interface IRazaService
    {
        Task<List<RazaDTO>> GetRazaById(Guid id);
    }
}
