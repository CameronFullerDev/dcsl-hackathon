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
    }
}
