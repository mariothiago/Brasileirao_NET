using Brasileirao.Domain.Model;

namespace Brasileirao.Data.Repository.Interfaces;
public interface IPartidasRepository
{
    public Task<IEnumerable<Partidas>> GetPartidasByRodada(int rodada);
    public Task<int> CreatePartida(Partidas partida);
    public Task<int> UpdatePartida(Partidas partida);
}

