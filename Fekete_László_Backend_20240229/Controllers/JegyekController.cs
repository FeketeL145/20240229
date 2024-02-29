using Fekete_László_Backend_20240229.Models;
using Fekete_László_Backend_20240229.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fekete_László_Backend_20240229.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JegyekController : ControllerBase
    {
        private readonly OsztalynaploContext context;

        public JegyekController(OsztalynaploContext osztalynaploContext)
        {
            context = osztalynaploContext;
        }

        [HttpGet("feladat12")]
        public async Task<object> GetFeladat11()
        {
            var result = context.Jegyeks.Count();
            return Ok($"Az összes jegy száma: {result}");
        }
    }
}
