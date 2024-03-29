﻿using Microsoft.AspNetCore.Mvc;
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
        public Task<IEnumerable<QuoteDTO>> GetQuotes([FromQuery]int count = 10)
            => _quoteService.GetQuotesAsync(count);

        [HttpPost("share/{id}")]
        public Task ShareQuoteAsync(Guid id)
            => _quoteService.ShareQuoteAsync(id);
    }
}
