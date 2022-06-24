using OneBeyondHackathon.Logic.Dto;

namespace OneBeyondHackathon.Logic.Service
{
    public interface IQuoteService
    {
        Task<IEnumerable<QuoteDTO>> GetQuotesAsync(int count);
        Task ShareQuoteAsync(Guid id);
    }
}