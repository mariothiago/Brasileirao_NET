using Brasileirao.Data.Repository;
using Brasileirao.Domain.Model;
using Brasileirao.Service.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Brasileirao.Services.Service;
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
