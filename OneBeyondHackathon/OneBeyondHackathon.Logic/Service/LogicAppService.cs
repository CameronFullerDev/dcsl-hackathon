﻿using Newtonsoft.Json;
using System.Net;
using System.Net.Mime;
using System.Text;

namespace OneBeyondHackathon.Logic.Service
{
    public sealed class LogicAppService : ILogicAppService
    {
        private readonly HttpClient _httpClient;

        private const string _webUrl = "https://keep-dev-calm-cfylkxhyq-ardguezsoc.vercel.app/";

        public LogicAppService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task PostToSlack(string content)
        {
            var body = new { content, url = _webUrl };
            var response = await _httpClient.PostAsync(
            string.Empty,
            new StringContent(
                JsonConvert.SerializeObject(body),
                Encoding.UTF8,
                MediaTypeNames.Application.Json));
        }
    }
}
