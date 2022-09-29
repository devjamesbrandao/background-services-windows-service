using Windows_Service;

IHost host = Host.CreateDefaultBuilder(args)
    // Configuração para aplicação executar como windows service
    .UseWindowsService(options =>
    {
        // Nome do serviço do windows que executará a aplicação
        options.ServiceName = "Estudos-Service";
    })
    .ConfigureServices(services =>
    {
        // Adicionando worker para executar como um serviço hostedService
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
