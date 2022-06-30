using Brasileirao.API.DTOs.Partida;
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
    public class PartidasController : ControllerBase
    {
        private IPartidasService _service { get; set; }

        public PartidasController(IPartidasService service)
        {
            _service = service;
        }

        [HttpGet("obter-por-rodada")]
        public async Task<IActionResult> GetPartidasPorRodada([FromQuery] int rodada)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var data = await _service.GetPartidasByRodada(rodada);

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

        [HttpPost("criar-partida")]
        public async Task<IActionResult> CreatePartida(InsertPartidaDTO partida)
        {
            try
            {
                Partidas model = partida.GetModel();
                var result = await _service.CreatePartida(model);

                if (result > 0)
                    return Ok(result);
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut("resultado-partida")]
        public async Task<IActionResult> InserirResultadoPartida(InsertResultadoDTO partida)
        {
            try
            {
                Partidas model = partida.GetModel();
                var result = await _service.UpdatePartida(model);

                if (result > 0)
                    return Ok(result);
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
