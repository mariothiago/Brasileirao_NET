﻿using Brasileirao.Data.Repository.Interfaces;
using Brasileirao.Data.Repository.Scripts;
using Brasileirao.Domain.Model;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Brasileirao.Data.Repository;

public class PalpitesRepository : IPalpitesRepository
{
    private IConfiguration _configuration;

    public PalpitesRepository(IConfiguration config)
    {
        _configuration = config;
    }

    public async Task<int> DeletePalpite(int id)
    {
        try
        {
            using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.ExecuteAsync(PalpitesScripts.DeletePalpites, new { Id = id });
            }
        }
        catch (Exception) { throw; }
    }

    public async Task<Palpites> GetPalpitesPorId(long id)
    {
        try
        {
            using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.QueryFirstAsync<Palpites>(PalpitesScripts.GetPalpitesPorId, new { Id = id });
            }
        }
        catch (Exception) { throw; }
    }

    public async Task<IEnumerable<Palpites>> GetPalpitesPorRodada(int rodada)
    {
        try
        {
            using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.QueryAsync<Palpites>(PalpitesScripts.GetPalpitesPorRodada, new { Rodada = rodada });
            }
        }
        catch (Exception) { throw; }
    }

    public async Task<int> InsertPalpite(Palpites palpites)
    {
        try
        {
            using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.ExecuteAsync(PalpitesScripts.InsertPalpite, palpites);
            }
        }
        catch (Exception) { throw; }
    }

    public async Task<int> UpdatePalpites(Palpites palpites)
    {
        try
        {
            using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.ExecuteAsync(PalpitesScripts.UpdatePalpites, palpites);
            }
        }
        catch (Exception) { throw; }
    }
}

