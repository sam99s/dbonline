using dbonline.DTOs;
using dbonline.Services;

namespace dbonline.Interfaces
{
    public interface IPersonajesService
    {
        Task<List<PersonajeDTO>> GetPersonajes();
        Task<List<PersonajeDTO>> GetPersonajeById(string id);
        Task<List<PersonajeByRasgoDTO>> GetPersonajesByRaza(int id);
        Task<List<PersonajeByRasgoDTO>> GetPersonajesBySaga(int id);
        Task<List<PersonajeByRasgoDTO>> GetPersonajesBySerie(int id);
    }
}
