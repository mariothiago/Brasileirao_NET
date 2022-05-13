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
        private readonly IPalpitesService _service;

        public Worker(ILogger<Worker> logger, IPalpitesService service)
        {
            _logger = logger;
            _service = service;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTime.Now);
                var palpites = await _service.GetPalpitesPorRodada(6);
                foreach(Palpites palpite in palpites)
                {
                    _logger.LogInformation(
                        $"RODADA 6 \r\n" + 
                        $"Seu palpite no jogo {palpite.TimeMandante} x {palpite.TimeVisitante} foi: \r\n" +
                        $"{palpite.TimeMandante} {palpite.PlacarMandante } x {palpite.PlacarVisitante} {palpite.TimeVisitante}\r\n"
                    );
                }

                await StopAsync(stoppingToken);
                _logger.LogInformation("Worker finished at: {time}", DateTime.Now);
            }
        }
    }
}
