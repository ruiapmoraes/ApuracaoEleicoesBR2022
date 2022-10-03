using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Services;
using CleanArchitecture.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using CleanArchitecture.Core.Settings;

namespace CleanArchitecture.Worker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            // seed some queue messages
            var queueSender = (IQueueSender)host.Services.GetRequiredService(typeof(IQueueSender));
            for (int i = 0; i < 10; i++)
            {
                //queueSender.SendMessageToQueue("https://google.com", "urlcheck");
                queueSender.SendMessageToQueue("https://resultados.tse.jus.br/oficial/ele2022/544/dados-simplificados/br/br-c0001-e000544-r.json", "urlcheck");
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));
                    services.AddSingleton<IEntryPointService, EntryPointService>();
                    services.AddSingleton<IServiceLocator, ServiceScopeFactoryLocator>();

                    // Infrastructure.ContainerSetup
                    services.AddMessageQueues();
                    services.AddDbContext(hostContext.Configuration);
                    services.AddRepositories();
                    services.AddUrlCheckingServices();
                    services.AddApuracaoService();

                    var workerSettings = new WorkerSettings();
                    hostContext.Configuration.Bind(nameof(WorkerSettings), workerSettings);
                    services.AddSingleton(workerSettings);

                    var entryPointSettings = new EntryPointSettings();
                    hostContext.Configuration.Bind(nameof(EntryPointSettings), entryPointSettings);
                    services.AddSingleton(entryPointSettings);

                    services.AddHostedService<Worker>();
                });
    }
}
