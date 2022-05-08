using Brasileirao.Infrastructure.Model;
using Brasileirao.Infrastructure.Repository.Interfaces;
using Brasileirao.Infrastructure.Repository.Scripts;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasileirao.Infrastructure.Repository
{
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
}
