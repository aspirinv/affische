using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using REvents.DTO;
using REvents.Tools;
using System.Threading.Tasks;

namespace REvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SettingsController : ControllerBase
    {
        private readonly AppSettings options;

        public SettingsController(IOptions<AppSettings> options)
        {
            this.options = options.Value;
        }
        [HttpGet]
        public ActionResult<Settings> Get()
        {
            return Ok(new Settings(options.FunctionsPath));
        }
    }
}
