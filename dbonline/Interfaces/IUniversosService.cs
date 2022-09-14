using dbonline.DTOs;

namespace dbonline.Interfaces
{
    public interface IUniversosService
    {
        Task<List<UniversoDTO>> GetUniversoByPersonajeId(Guid id);
    }
}
