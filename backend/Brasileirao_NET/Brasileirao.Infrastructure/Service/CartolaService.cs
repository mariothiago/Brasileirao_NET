using Brasileirao.Infrastructure.Model;
using Brasileirao.Infrastructure.Repository;
using Brasileirao.Infrastructure.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Brasileirao.Infrastructure.Service
{
    public class CartolaService : ICartolaService
    {
        private CartolaRepository _repository { get; set; }
        public CartolaService(IConfiguration config)
        {
            _repository = new CartolaRepository(config);
        }

        public Task<IEnumerable<Cartola>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cartola>> GetByTime(int idTime)
        {
            try
            {
                return await _repository.GetByTime(idTime);
            }
            catch (Exception) { throw; }
        }

        public async Task<int> Insert(IEnumerable<Cartola> cartola)
        {
            try
            {
                return await _repository.Insert(cartola);
            }
            catch (Exception) { throw; }
        }
    }
}
