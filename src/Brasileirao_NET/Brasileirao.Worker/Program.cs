using Brasileirao.Service.Services;
using Brasileirao.Service.Services.Interfaces;
using Brasileirao.Worker;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddTransient<IVerificarPalpiteService, VerificarPalpiteService>();
    })
    .Build();

host.Run();
