using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BackLab3.Services;
using BackLab3.Services.Hosted;

await Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        // сервисы
        services.AddSingleton<IMessageService, ConsoleMessageService>();
        services.AddSingleton<IDateTimeProvider, SystemDateTimeProvider>();

        // hosted-служба
        services.AddHostedService<AppHostedService>();
    })
    .RunConsoleAsync();


