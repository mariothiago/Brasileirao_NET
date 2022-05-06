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
    public class CartolaRepository : ICartolaRepository
    {
        private IConfiguration _configuration;

        public CartolaRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<IEnumerable<Cartola>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cartola>> GetByTime(int idTime)
        {
            try
            {
                using (var connection = new MySqlConnection(
                    _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.QueryAsync<Cartola>(CartolaScripts.GetByTeam, new { IdTime = idTime});
                }
            }
            catch (Exception) { throw; }
        }

        public async Task<int> Insert(Cartola cartola)
        {
            try
            {
                using (var connection = new MySqlConnection(
                    _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.ExecuteAsync(CartolaScripts.Insert, cartola);
                }
            }
            catch (Exception) { throw; }
        }
    }
}
