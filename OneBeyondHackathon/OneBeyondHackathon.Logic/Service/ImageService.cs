using Microsoft.EntityFrameworkCore;
using OneBeyondHackathon.Logic.Dto;
using OneBeyondHackathon.Logic.Storage;

namespace OneBeyondHackathon.Logic.Service
{
    public sealed class ImageService : IImageService
    {
        private readonly DatabaseContext _context;
        private readonly ILogicAppService _logicAppService;

        public ImageService(
            DatabaseContext context,
            ILogicAppService logicAppService)
        {
            _context = context;
            _logicAppService = logicAppService;
        }

        public async Task<ImageDTO?> GetRandomImageAsync()
        {
            return await _context.Images
                .OrderBy(x => Guid.NewGuid())
                .Select(x => new ImageDTO
                {
                    Id = x.Id,
                    Url = x.Url,
                })
                .FirstOrDefaultAsync();
        }

        public async Task ShareImageAsync(Guid id)
        {
            var image = await _context.Images
                .Where(image => image.Id == id)
                .FirstOrDefaultAsync();

            if (image is null)
            {
                throw new Exception($"Can't find image {id}.");
            }

            await _logicAppService.PostToSlack(image.Url);
        }
    }
}
