using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REvents.DTO;
using REvents.Logic;
using REvents.Tools;
using System.Threading.Tasks;

namespace REvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserLogic userLogic;

        public AuthController(UserLogic userLogic)
        {
            this.userLogic = userLogic;
        }

        [HttpPost]
        public async Task<ActionResult<string>> Auth(AuthRequest req)
        {
            var result = await userLogic.Login(req.Login, req.Password);
            return result.IsEmpty() ? Unauthorized() : Ok(new { token = result });
        }
    }
}
