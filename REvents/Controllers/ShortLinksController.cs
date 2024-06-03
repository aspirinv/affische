﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using REvents.DTO;
using REvents.Entities;
using REvents.Logic;
using System.Threading.Tasks;

namespace REvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ShortLinksController : ControllerBase
    {
        private readonly ShortenerLogic logic;

        public ShortLinksController(ShortenerLogic logic)
        {
            this.logic = logic;
        }

        [HttpPost]
        public async Task<ActionResult> Post(ShortLinkHeader link)
        {
            var code = await logic.Save(link);
            return Ok($"{Request.Scheme}://{Request.Host.Value}/s/{code}");
        }

        [HttpGet]
        public async Task<ActionResult<ShortLink[]>> List()
        {
            return Ok(await logic.List());
        }
    }
}
