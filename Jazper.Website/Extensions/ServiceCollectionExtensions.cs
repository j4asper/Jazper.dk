using Jazper.Website.Options;
using Jazper.Website.Providers;
using Microsoft.AspNetCore.HttpOverrides;

namespace Jazper.Website.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddHostDependencies(this IServiceCollection serviceCollection)
    {
        serviceCollection.Configure<ForwardedHeadersOptions>(options =>
        {
            options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
        });

        serviceCollection.AddRazorComponents()
            .AddInteractiveServerComponents();

        serviceCollection.AddOptionsWithValidateOnStart<ProjectsOptions>()
            .BindConfiguration(ProjectsOptions.Projects)
            .ValidateDataAnnotations();

        serviceCollection.AddOptionsWithValidateOnStart<TechStackOptions>()
            .BindConfiguration(TechStackOptions.Stack)
            .ValidateDataAnnotations();

        serviceCollection.AddOptionsWithValidateOnStart<HeroOptions>()
            .BindConfiguration(HeroOptions.Hero)
            .ValidateDataAnnotations();

        serviceCollection.AddOptionsWithValidateOnStart<FlagshipOptions>()
            .BindConfiguration(FlagshipOptions.Flagship)
            .ValidateDataAnnotations();

        serviceCollection.AddOptionsWithValidateOnStart<SecurityOptions>()
            .BindConfiguration(SecurityOptions.Security)
            .ValidateDataAnnotations();

        serviceCollection.AddOptionsWithValidateOnStart<CertificationsOptions>()
            .BindConfiguration(CertificationsOptions.Certifications)
            .ValidateDataAnnotations();

        serviceCollection.AddOptionsWithValidateOnStart<ThemeOptions>()
            .BindConfiguration(ThemeOptions.Theme)
            .ValidateDataAnnotations();

        serviceCollection.AddHealthChecks();

        serviceCollection.AddSingleton<IconProvider>();

        return serviceCollection;
    }
}
