﻿using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REvents.DTO;
using REvents.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REvents.Controllers
{
    [Route("s")]
    [ApiController]
    public class ShortenerController : ControllerBase
    {
        private readonly ShortenerLogic logic;

        public ShortenerController(ShortenerLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> Get(string code)
        {
            return Redirect(await logic.RedirectTo(code));
        }

        [HttpPost]
        public async Task<IActionResult> Post(ShortLinkHeader link)
        {
            var code = await logic.Save(link);
            return Ok($"{Request.Scheme}://{Request.Host.Value}/s/{code}");
        }
    }
}