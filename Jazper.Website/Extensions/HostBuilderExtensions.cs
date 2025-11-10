using Serilog;

namespace Jazper.Website.Extensions;

public static class HostBuilderExtensions
{
    public static IHostBuilder UseDefaultServiceProvider(this IHostBuilder hostBuilder)
    {
        hostBuilder.UseDefaultServiceProvider(options =>
        {
            options.ValidateScopes = true;
            options.ValidateOnBuild = true;
        });
        
        return hostBuilder;
    }
}