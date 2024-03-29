﻿using Microsoft.AspNetCore.Mvc;
using OneBeyondHackathon.Logic.Dto;
using OneBeyondHackathon.Logic.Service;

namespace OneBeyondHackathon.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpPost("share/{id}")]
        public Task Share(Guid id)
            => _imageService.ShareImageAsync(id);

        [HttpGet]
        public Task<ImageDTO?> GetRandomImageAsync()
            => _imageService.GetRandomImageAsync();
    }
}