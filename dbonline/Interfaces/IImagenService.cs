using dbonline.DTOs;

namespace dbonline.Interfaces
{
    public interface IImagenService
    {
        Task<List<ImagenDTO>> GetImagenes();
    }
}
