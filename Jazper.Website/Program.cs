using Jazper.Website.Components;
using Jazper.Website.Extensions;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host
    .UseDefaultServiceProvider()
    .UseSerilog((context, config) => config.ReadFrom.Configuration(context.Configuration));

builder.Services.AddHostDependencies();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.UseHealthChecks("/health");

app.UseForwardedHeaders();

app.UseStaticFiles();

app.Run();