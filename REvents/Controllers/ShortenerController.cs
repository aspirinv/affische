using Google.Cloud.Firestore;
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
    [Route("sl")]
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
            var ip = Request.HttpContext.Connection.RemoteIpAddress?.ToString();
            return Redirect(await logic.RedirectTo(code, new VisiterData
            {
                IP = ip,
                UserAgent = Request.Headers.UserAgent
            }));
        }

    }
}
