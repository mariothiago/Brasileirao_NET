using Brasileirao.Domain.Model;

namespace Brasileirao.Service.Services.Interfaces;
public interface IPartidasService
{
    public Task<IEnumerable<Partidas>> GetPartidasByRodada(int rodada);
    public Task<int> CreatePartida(Partidas partida);
    public Task<int> UpdatePartida(Partidas partida);
}
