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
        private readonly IVerificaPalpiteService _service;

        public Worker(ILogger<Worker> logger, IVerificaPalpiteService service)
        {
            _logger = logger;
            _service = service;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTime.Now);
                var palpites = await _service.VerificarPalpites(14);

                _logger.LogInformation(palpites);

                await StopAsync(stoppingToken);
                _logger.LogInformation("Worker finished at: {time}", DateTime.Now);
            }
        }
    }
}
