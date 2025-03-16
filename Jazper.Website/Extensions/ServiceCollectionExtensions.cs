using Jazper.Website.Options;
using Jazper.Website.Providers;
using Microsoft.AspNetCore.HttpOverrides;
using MudBlazor.Services;

namespace Jazper.Website.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddHostDependencies(this IServiceCollection serviceCollection)
    {
        serviceCollection.Configure<ForwardedHeadersOptions>(options =>
        {
            options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
        });
        
        serviceCollection.AddMudServices();
        serviceCollection.AddRazorComponents()
            .AddInteractiveServerComponents();

        serviceCollection.AddOptionsWithValidateOnStart<ProjectsOptions>()
            .BindConfiguration(ProjectsOptions.Projects)
            .ValidateDataAnnotations();

        serviceCollection.AddOptionsWithValidateOnStart<ExperienceOptions>()
            .BindConfiguration(ExperienceOptions.Experience)
            .ValidateDataAnnotations();

        serviceCollection.AddHealthChecks();

        serviceCollection.AddSingleton<IconProvider>();
        
        return serviceCollection;
    }
}