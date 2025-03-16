using Serilog;

namespace Jazper.Website.Extensions;

public static class HostBuilderExtensions
{
    public static IHostBuilder UseSerilog(this IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureLogging((hostContext, logging) =>
        {
            logging.ClearProviders();
            
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(hostContext.Configuration)
                .CreateLogger();
            
            logging.AddSerilog();
        });
        
        return hostBuilder;
    }
}