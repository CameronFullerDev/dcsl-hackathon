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

        public async Task<IEnumerable<QuoteDTO>> GetQuotesAsync(int count)
        {
            return await _context.Quotes
                .OrderBy(x => Guid.NewGuid())
                .Take(count)
                .Select(x => new QuoteDTO
                {
                    Id = x.Id,
                    Author = x.Author,
                    Quote = x.Quote,
                    QuoteDate = x.QuoteDate
                })
                .ToListAsync();
        }

        public async Task ShareQuoteAsync(Guid id)
        {
            var quoteContent = await _context.Quotes
                .Where(quote => quote.Id == id)
                .Select(quote => quote.Quote)
                .FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(quoteContent))
            {
                return;
            }

            // TODO Share quote content.
        }
    }
}
