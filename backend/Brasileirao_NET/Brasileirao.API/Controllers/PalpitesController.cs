using Brasileirao.API.DTOs.Palpite;
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
    public class PalpitesController : Controller
    {
        private IPalpitesService _service { get; set; }

        public PalpitesController(IPalpitesService service)
        {
            _service = service;
        }

        [HttpGet("obter-palpites")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var data = await _service.GetAllPalpites();
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

        [HttpPost("inserir-palpite")]
        public async Task<IActionResult> Insert([FromBody] InsertPalpitesDTO palpites)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                Palpites model = palpites.GetModel();
                var data = await _service.InsertPalpite(model);

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
