using Fekete_László_Backend_20240229.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fekete_László_Backend_20240229.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TantargyController : ControllerBase
    {
        private readonly OsztalynaploContext context;

        public TantargyController(OsztalynaploContext osztalynaploContext)
        {
            context = osztalynaploContext;
        }

        [HttpGet("feladat9")]
        public async Task<ActionResult> GetFeladat9()
        {
            var tantargyak = await context.Tantargyaks.ToListAsync();
            return Ok(tantargyak);
        }

        [HttpGet("feladat10")]
        public async Task<ActionResult> GetFeladat10(string tantargyNev)
        {
            var result = await context.Tantargyaks.Where(x => x.TantargyNev == tantargyNev).ToListAsync();
            return Ok(result);
        }
    }
}
