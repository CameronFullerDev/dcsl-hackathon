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

        public async Task Share(Guid id)
        {
            var image = await _context.Set<ImageEntity>().FirstOrDefaultAsync(image => image.Id == id);
            if (image == null)
            {
                throw new Exception($"Can't find image {id}.");
            }
            return _logicAppService.PostToSlack(image.Url);
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
    }
}
