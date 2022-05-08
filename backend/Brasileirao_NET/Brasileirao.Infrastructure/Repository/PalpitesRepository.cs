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
    public class PalpitesRepository : IPalpitesRepository
    {
        private IConfiguration _configuration;

        public PalpitesRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public Task<int> DeletePalpite(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Palpites>> GetAllPalpites()
        {
            try
            {
                using (var connection = new MySqlConnection(
                    _configuration.GetConnectionString("DefaultConnection")))
                {
                    return await connection.QueryAsync<Palpites>(PalpitesScripts.GetAllPalpites);
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

        public Task<int> UpdatePalpites(Palpites palpites)
        {
            throw new NotImplementedException();
        }
    }
}
