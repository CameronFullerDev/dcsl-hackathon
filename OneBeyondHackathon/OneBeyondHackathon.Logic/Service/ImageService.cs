using Microsoft.EntityFrameworkCore;
using OneBeyondHackathon.Logic.Dto;
using OneBeyondHackathon.Logic.Storage;

namespace OneBeyondHackathon.Logic.Service
{
    public sealed class ImageService : IImageService
    {
        private readonly DatabaseContext _context;

        public ImageService(DatabaseContext context)
        {
            _context = context;
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
            var imageUrl = await _context.Images
                .Where(image => image.Id == id)
                .Select(image => image.Url)
                .FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(imageUrl))
            {
                return;
            }

            // TODO Share image url.
        }
    }
}
