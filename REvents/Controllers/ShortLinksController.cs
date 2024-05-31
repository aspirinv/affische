using Microsoft.AspNetCore.Mvc;
using REvents.DTO;
using REvents.Logic;
using System.Threading.Tasks;

namespace REvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
