﻿using Newtonsoft.Json;
using System.Net;
using System.Net.Mime;
using System.Text;

namespace OneBeyondHackathon.Logic.Service
{
    public sealed class LogicAppService : ILogicAppService
    {
        private readonly HttpClient _httpClient;

        public LogicAppService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task PostToSlack(string content)
        {
            var body = new { content, url = "uuu" };
            var response = await _httpClient.PostAsync(
            "",
            new StringContent(
                JsonConvert.SerializeObject(body),
                Encoding.UTF8,
                MediaTypeNames.Application.Json));
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception($"Failed to post slack message.");
            }
        }
    }
}