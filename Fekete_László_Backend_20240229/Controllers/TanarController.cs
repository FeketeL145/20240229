using Fekete_László_Backend_20240229.Models;
using Microsoft.AspNetCore.Http;
using Fekete_László_Backend_20240229.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fekete_László_Backend_20240229.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TanarController : ControllerBase
    {
        private readonly OsztalynaploContext context;

        public TanarController(OsztalynaploContext osztalynaploContext)
        {
            context = osztalynaploContext;
        }

        [HttpGet("feladat11")]
        public async Task<object> GetFeladat11()
        {
            var result = await context.Tanaroks.Include(x => x.Jegyeks).ToListAsync();
            return Ok(result);
        }

    }
}
