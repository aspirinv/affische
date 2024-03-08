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
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly BackstageLogic backstageLogic;

        public EventsController(BackstageLogic backstageLogic)
        {
            this.backstageLogic = backstageLogic;
        }

        [HttpGet("backstage")]
        public async Task<ActionResult<EventsResponse>> GetBackstageEvents()
        {
            return Ok(await backstageLogic.GetEvents());
        }
    }
}
