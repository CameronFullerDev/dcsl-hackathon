using Microsoft.AspNetCore.Mvc;
using OneBeyondHackathon.Logic.Dto;
using OneBeyondHackathon.Logic.Service;

namespace OneBeyondHackathon.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet]
        public Task<ImageDTO?> GetRandomImageAsync()
            => _imageService.GetRandomImageAsync();

        [HttpPost("Share")]
        public Task ShareImageAsync([FromQuery]Guid id)
            => _imageService.ShareImageAsync(id);
    }
}
