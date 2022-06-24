using Microsoft.EntityFrameworkCore;
using OneBeyondHackathon.Logic.Dto;
using OneBeyondHackathon.Logic.Storage;

namespace OneBeyondHackathon.Logic.Service
{
    public class QuoteService : IQuoteService
    {
        private readonly DatabaseContext _context;
        private readonly ILogicAppService _logicAppService;

        public QuoteService(
            DatabaseContext context,
            ILogicAppService logicAppService)
        {
            _context = context;
            _logicAppService = logicAppService;
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

            await _logicAppService.PostToSlack(quoteContent);
        }
    }
}
