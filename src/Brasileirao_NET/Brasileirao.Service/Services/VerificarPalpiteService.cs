using Brasileirao.Data.Repository;
using Brasileirao.Domain.Model;
using Brasileirao.Service.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Brasileirao.Service.Services;
public class VerificarPalpiteService : IVerificarPalpiteService
{
    private ILogger<VerificarPalpiteService> _logger;
    private PartidasRepository _partidasRepository;
    private PalpitesRepository _palpitesRepository;
    private PalpitePartidaRepository _palpitePartidaRepository;

    public VerificarPalpiteService(ILogger<VerificarPalpiteService> logger,
        IConfiguration config)
    {
        _logger = logger;
        _partidasRepository = new PartidasRepository(config);
        _palpitesRepository = new PalpitesRepository(config);
        _palpitePartidaRepository = new PalpitePartidaRepository(config);
    }

    public async Task VerificaPalpite()
    {
        _logger.LogInformation($"Verificando partidas...");

        var partidasAtualizadas = await _partidasRepository.GetPartidasAtualizadas();
        if (partidasAtualizadas.Any())
        {
            foreach (var partida in partidasAtualizadas)
            {
                var palpite = await _palpitesRepository.GetPalpitesPorId(partida.Id);

                PalpitePartida palpitePartida = new();

                if (palpite.PlacarMandante == partida.PlacarMandante
                && palpite.PlacarVisitante == palpite.PlacarVisitante)
                {
                    palpitePartida = new()
                    {
                        DataHoraProcessamento = DateTime.Now,
                        Motivo = "Acertou placar exato",
                        Pontuacao = 3,
                        PalpiteId = palpite.Id,
                        PartidaId = Convert.ToInt32(partida.Id)
                    };
                }

                else if (palpite.PlacarMandante == partida.PlacarMandante
                || palpite.PlacarVisitante == palpite.PlacarVisitante 
                && palpite.PlacarMandante != partida.PlacarMandante
                || palpite.PlacarVisitante != palpite.PlacarVisitante)
                {
                    palpitePartida = new()
                    {
                        DataHoraProcessamento = DateTime.Now,
                        Motivo = "Acertou placar de um dos times",
                        Pontuacao = 2,
                        PalpiteId = palpite.Id,
                        PartidaId = Convert.ToInt32(partida.Id)
                    };
                    
                }

                await _palpitePartidaRepository.InsertResultados(palpitePartida);
            }
        }
        else
        {
            _logger.LogInformation("Não há partidas para processar.");
        }

    }
}