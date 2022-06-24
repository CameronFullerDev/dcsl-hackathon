using Microsoft.AspNetCore.Mvc;
using OneBeyondHackathon.Logic.Dto;
using OneBeyondHackathon.Logic.Service;

namespace OneBeyondHackathon.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuoteController : Controller
    {
        private readonly IQuoteService _quoteService;

        public QuoteController(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        [HttpGet]
        public async Task<QuoteDto> GetQuote()
        {
            return await _quoteService.GetQuoteAsync();
        }
    }
}
