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
        partida.Flag = "P"; // pendente por default.
        return await _repository.CreatePartida(partida);
    }

    public async Task<IEnumerable<Partidas>> GetPartidasByRodada(int rodada)
    {
        return await _repository.GetPartidasByRodada(rodada);
    }

    public async Task<int> UpdatePartida(Partidas partida)
    {
        if(!string.IsNullOrEmpty(partida.PlacarMandante.ToString()) && !string.IsNullOrEmpty(partida.PlacarVisitante.ToString()))
            partida.Flag = "C"; // flag aprovado.

        return await _repository.UpdatePartida(partida);
    }
}
