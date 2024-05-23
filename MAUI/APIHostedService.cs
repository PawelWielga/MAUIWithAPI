using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MAUI;

public class APIHostedService : IHostedService
{
    private IWebHost _webHost;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _webHost = WebHost.CreateDefaultBuilder()
            .UseStartup<PrintSettingsAPI.Startup>()
            .UseUrls("http://localhost:5256")
            .Build();

        return _webHost.StartAsync(cancellationToken);
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return _webHost?.StopAsync(cancellationToken) ?? Task.CompletedTask;
    }
}
