using Microsoft.Extensions.Hosting;

namespace BackLab3.Services.Hosted;

public class AppHostedService : IHostedService
{
    private readonly IMessageService _msg;
    private readonly IDateTimeProvider _dt;

    public AppHostedService(IMessageService msg, IDateTimeProvider dt)
    {
        _msg = msg;
        _dt = dt;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _msg.Send("Приложение запущено в " + _dt.Now);
        // тут ваша основная логика
        _msg.Send("Приложение завершило работу в " + _dt.Now);
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _msg.Send("Приложение остановлено.");
        return Task.CompletedTask;
    }
}
