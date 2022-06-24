using OneBeyondHackathon.Logic.Dto;

namespace OneBeyondHackathon.Logic.Service
{
    public interface IQuoteService
    {
        Task<IEnumerable<QuoteDto>> GetQuotesAsync(int count);
    }
}