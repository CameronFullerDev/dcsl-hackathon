using Microsoft.EntityFrameworkCore;
using OneBeyondHackathon.Logic.Dto;
using OneBeyondHackathon.Logic.Storage;

namespace OneBeyondHackathon.Logic.Service
{
    public class QuoteService : IQuoteService
    {
        private readonly DatabaseContext _context;

        public QuoteService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<QuoteDto>> GetQuotesAsync(int count)
        {
            return await _context.Quotes
                .Take(count)
                .Select(x => new QuoteDto
                {
                    Id = x.Id,
                    Author = x.Author,
                    Quote = x.Quote,
                    QuoteDate = x.QuoteDate
                })
                .OrderBy(x => Guid.NewGuid())
                .ToListAsync();
        }
    }
}
