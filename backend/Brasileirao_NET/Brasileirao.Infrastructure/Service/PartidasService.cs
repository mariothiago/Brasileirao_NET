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
    public class PartidasService : IPartidasService
    {
        private PartidasRepository _repository { get; set; }

        public PartidasService(IConfiguration config)
        {
            _repository = new PartidasRepository(config);
        }
        public async Task<int> CreatePartida(Partidas partida)
        {
            try
            {
                return await _repository.CreatePartida(partida);
            }
            catch (Exception) { throw; }
        }

        public async Task<IEnumerable<Partidas>> GetPartidasByRodada(int rodada)
        {
            try
            {
                return await _repository.GetPartidasByRodada(rodada);
            }
            catch (Exception) { throw; }
        }

        public async Task<int> UpdatePartida(Partidas partida)
        {
            try
            {
                return await _repository.UpdatePartida(partida);
            }
            catch (Exception) { throw; }
        }
    }
}
