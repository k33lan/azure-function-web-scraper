using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace azure_function_web_scraper
{
    public class Program
    {
        public static Task Main(string[] args)
        {
            var host = new HostBuilder()
                 .ConfigureAppConfiguration(configurationBuilder =>
                {
                    configurationBuilder.AddCommandLine(args);
                })
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureServices(services =>
                {
                	services.AddLogging();
                    services.AddHttpClient();
                })
                .Build();

            return host.RunAsync();
        }
    }
}