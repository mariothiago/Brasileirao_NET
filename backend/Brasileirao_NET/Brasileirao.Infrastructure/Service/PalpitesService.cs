using Brasileirao.Infrastructure.Model;
using Brasileirao.Infrastructure.Repository;
using Brasileirao.Infrastructure.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasileirao.Infrastructure.Service
{
    public class PalpitesService : IPalpitesService
    {
        private PalpitesRepository _repository { get; set; }
        public PalpitesService(IConfiguration config)
        {
            _repository = new PalpitesRepository(config);
        }

        public Task<int> DeletePalpite(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> InsertPalpite(Palpites palpites)
        {
            try
            {
                return await _repository.InsertPalpite(palpites);
            }
            catch (Exception) { throw; }
        }

        public Task<int> UpdatePalpites(Palpites palpites)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Palpites>> GetAllPalpites()
        {
            try
            {
                return await _repository.GetAllPalpites();
            }
            catch (Exception) { throw; }
        }
    }
}
