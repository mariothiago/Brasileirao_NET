
using Brasileirao.Data.Repository.Interfaces;
using Brasileirao.Data.Repository.Scripts;
using Brasileirao.Domain.Model;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Brasileirao.Data.Repository;
public class PartidasRepository : IPartidasRepository
{
    private IConfiguration _configuration;

    public PartidasRepository(IConfiguration config)
    {
        _configuration = config;
    }

    public async Task<int> CreatePartida(Partidas partida)
    {
        try
        {
            using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.ExecuteAsync(PartidasScripts.CreatePartida, partida);
            }
        }

        catch (Exception) { throw; }
    }


    public async Task<IEnumerable<Partidas>> GetPartidasByRodada(int rodada)
    {
        try
        {
            using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.QueryAsync<Partidas>(PartidasScripts.GetByRodada, new { Rodada = rodada });
            }
        }
        catch (Exception) { throw; }
    }


    public async Task<int> UpdatePartida(Partidas partida)
    {
        try
        {
            using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.ExecuteAsync(PartidasScripts.UpdatePartida, partida);
            }
        }

        catch (Exception) { throw; }
    }
}

