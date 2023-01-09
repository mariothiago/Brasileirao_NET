using Brasileirao.Service.Services.Interfaces;

namespace Brasileirao.Worker;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private IVerificarPalpiteService _service;
    public Worker(ILogger<Worker> logger, IVerificarPalpiteService service)
    {
        _logger = logger;
        _service = service;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            await _service.VerificaPalpite();
            _logger.LogInformation("Worker finished at: {time}", DateTimeOffset.Now);
            await Task.Delay(TimeSpan.FromHours(1), stoppingToken);
        }
    }
}
