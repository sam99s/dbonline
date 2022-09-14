using dbonline.DTOs;

namespace dbonline.Interfaces
{
    public interface ISagasService
    {
        Task<List<SagaDTO>> GetSagaByPersonajeId(Guid id);
    }
}
