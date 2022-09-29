namespace Windows_Service;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            // Log da aplicação
            _logger.LogInformation("Tarefa executando em segundo plano: {time}", DateTimeOffset.Now);

            // Executa tarefa a cada 3 segundos
            await Task.Delay(30000, stoppingToken);
        }
    }
}
