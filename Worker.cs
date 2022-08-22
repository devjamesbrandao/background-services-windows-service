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
            _logger.LogInformation("Tarefa executando em segundo plano: {time}", DateTimeOffset.Now);

            await Task.Delay(30000, stoppingToken);
        }
    }
}
