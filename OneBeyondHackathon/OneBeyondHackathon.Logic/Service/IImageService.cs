using OneBeyondHackathon.Logic.Dto;

namespace OneBeyondHackathon.Logic.Service
{
    public interface IImageService
    {
        Task<ImageDTO> GetRandomImageAsync();
    }
}
