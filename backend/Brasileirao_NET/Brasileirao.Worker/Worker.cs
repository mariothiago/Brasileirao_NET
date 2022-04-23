using Brasileirao.Infrastructure.Model;
using Brasileirao.Infrastructure.Service.Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Brasileirao.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IPartidasService _service;

        public Worker(ILogger<Worker> logger, IPartidasService service)
        {
            _logger = logger;
            _service = service;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTime.Now);
                var partidas = await _service.GetPartidasByRodada(1);
                foreach(Partidas partida in partidas)
                {
                    _logger.LogInformation(
                        $"Rodada {partida.Rodada} do Brasileir�o, \r\n" +
                        $"{partida.TimeMandante} x {partida.TimeVisitante}\r\n" +
                        $"Data: {partida.DataJogo}\r\n" +
                        $"Est�dio {partida.Estadio}\r\n" +
                        $"Localiza��o: {partida.Localizacao}");
                }
                await StopAsync(stoppingToken);
            }
        }
    }
}
