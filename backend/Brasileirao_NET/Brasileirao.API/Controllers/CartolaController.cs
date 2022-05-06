using Brasileirao.Infrastructure.Model;
using Brasileirao.Infrastructure.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Brasileirao.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartolaController : Controller
    {
        private ICartolaService _service { get; set; }

        public CartolaController(ICartolaService service)
        {
            _service = service;
        }

        [HttpGet("obter-pelo-time")]
        public async Task<IActionResult> GetByTime([FromQuery] int idTime)
        {
            try
            {
                var data = await _service.GetByTime(idTime);

                if (data.Count() > 0)
                    return Ok(data);
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost("inserir-atleta")]
        public async Task<IActionResult> Insert([FromBody] Cartola cartola)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var data = await _service.Insert(cartola);

                if (data > 0)
                    return Ok(data);
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
