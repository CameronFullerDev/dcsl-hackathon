using Microsoft.AspNetCore.Mvc;
using OneBeyondHackathon.WebApi.Dto;

namespace OneBeyondHackathon.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuoteController : Controller
    {

        [HttpGet]
        public QuoteDto GetQuote()
        {
            var random = new Random();
            var randomQuote = random.Next(_quotes.Count());

            var quote = _quotes.Skip(randomQuote).First();

            return quote;
        }

        private static readonly IEnumerable<QuoteDto> _quotes = new List<QuoteDto>
        {
            new QuoteDto
            {
                Id = Guid.NewGuid(),
                Author = "Bob Smith",
                QuoteDate = DateTime.UtcNow,
                Quote = "Let's win the hackathon."
            },
            new QuoteDto
            {
                Id = Guid.NewGuid(),
                Author = "John Smith",
                QuoteDate = DateTime.UtcNow,
                Quote = "Let's win the hackathon."
            },
            new QuoteDto
            {
                Id = Guid.NewGuid(),
                Author = "Tim Smith",
                QuoteDate = DateTime.UtcNow,
                Quote = "Let's win the hackathon."
            }
        };
    }
}
