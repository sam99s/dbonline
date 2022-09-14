using dbonline.DTOs;
using dbonline.Services;

namespace dbonline.Interfaces
{
    public interface ITransformacionesService
    {
        Task<List<TransformacionesDTO>> GetTransformaciones();
    }
}
