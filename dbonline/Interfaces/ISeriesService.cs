using dbonline.DTOs;

namespace dbonline.Interfaces
{
    public interface ISeriesService
    {
        Task<List<SerieDTO>> GetSerieByPersonajeId(Guid id);
    }
}
