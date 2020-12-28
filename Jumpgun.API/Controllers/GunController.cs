using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Jumpgun.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GunController : ControllerBase
    {
        // GET
        [HttpGet]
        [Route("v1/assets")]
        public async Task<IActionResult> Index()
        {
            return Ok(new List<string>(){"Grimm", "X-Files", "X-Men", "Maximos"});
        }

        public async Task<IActionResult> Dummy()
        {
            return Ok("Dummy text");
        }
    }
}