using Brasileirao.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasileirao.Infrastructure.Service.Interfaces
{
    public interface IPartidasService
    {
        public Task<IEnumerable<Partidas>> GetPartidasByRodada(int rodada);
        public Task<int> CreatePartida(Partidas partida);
        public Task<int> UpdatePartida(Partidas partida);
    }
}
