using OneBeyondHackathon.Logic.Dto;

namespace OneBeyondHackathon.Logic.Service
{
    public interface IQuoteService
    {
        Task<QuoteDto> GetQuoteAsync();
    }
}