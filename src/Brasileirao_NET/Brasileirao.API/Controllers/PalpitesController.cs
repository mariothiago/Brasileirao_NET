﻿using Brasileirao.Domain.DTOs.Palpite;
using Brasileirao.Domain.Model;
using Brasileirao.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Brasileirao.API.Controllers;
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
    public async Task<IActionResult> GetPalpitesPorRodada([FromQuery] int rodada)
    {
        try
        {
            var data = await _service.GetPalpitesPorRodada(rodada);
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

    [HttpPut("alterar-palpite")]
    public async Task<IActionResult> Update([FromBody] UpdatePalpitesDTO palpite)
    {
        try
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Palpites model = palpite.GetModel();
            var data = await _service.UpdatePalpites(model);

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

    [HttpDelete("excluir")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            var data = await _service.DeletePalpite(id);

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
