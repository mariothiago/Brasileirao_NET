using Brasileirao.Data.Repository.Interfaces;
using Brasileirao.Data.Repository.Scripts;
using Brasileirao.Domain.Model;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Brasileirao.Data.Repository;
public class PalpitePartidaRepository : IPalpitePartidaRepository
{
    private IConfiguration _configuration;

    public PalpitePartidaRepository(IConfiguration config)
    {
        _configuration = config;
    }

    public async Task<int> InsertResultados(PalpitePartida palpite)
    {
        try
        {
            using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.ExecuteAsync(PalpitePartidaScripts.InserResult, palpite);
            }
        }
        catch (Exception) { throw; }
    }
}
