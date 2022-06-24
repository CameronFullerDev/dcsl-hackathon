using OneBeyondHackathon.Logic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneBeyondHackathon.Logic.Service
{
    public class QuoteService : IQuoteService
    {
        public async Task<QuoteDto> GetQuoteAsync()
        {
            return _quotes.FirstOrDefault();
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
