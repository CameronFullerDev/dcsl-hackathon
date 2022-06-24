using Microsoft.AspNetCore.Mvc;
using OneBeyondHackathon.WebApi.Dto;

namespace OneBeyondHackathon.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagesController : ControllerBase
    {
        private readonly IList<string> _imageUrls = new List<string>
        {
            "https://images.squarespace-cdn.com/content/v1/5d15594116124000014ec5aa/1633813755009-PX3BGXB1L41JTKYFMWDU/lizfosslienyoucanstillsucceed.png?format=500w"
        };

        [HttpGet("random")]
        public ImageDTO Get()
        {
            var random = new Random();
            var randomUrl = random.Next(_imageUrls.Count);
            return new ImageDTO { Url = _imageUrls[randomUrl] };
        }
    }
}
