using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MAUI;

public class APIHostedService : IHostedService
{
    private IWebHost _webHost;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        var builder = WebApplication.CreateBuilder();

        _webHost = WebHost.CreateDefaultBuilder()
            .UseStartup<PrintSettingsAPI.Startup>()
            .UseUrls("https://localhost:5256")
            .Build();

        return _webHost.StartAsync(cancellationToken);
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return _webHost?.StopAsync(cancellationToken) ?? Task.CompletedTask;
    }
}
