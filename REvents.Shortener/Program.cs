using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using REvents.Data;
using REvents.Data.DataSource;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml.Linq;

//[assembly: FunctionsStartup(typeof(REvents.Shortener.Program))]

namespace REvents.Shortener
{
    class Program// : FunctionsStartup
    {
        static async Task Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureServices((c, s) =>
                {
                    s.AddSingleton<IShortenerData, FirebaseShortenerData>();
                    s.Configure<FirebaseOptions>(options => c.Configuration.GetSection(nameof(FirebaseOptions)).Bind(options));
                    s.Configure<ShortenerOptions>(options => c.Configuration.GetSection(nameof(ShortenerOptions)).Bind(options));
                })
                .Build();

            await host.RunAsync();
        }

    }
}
