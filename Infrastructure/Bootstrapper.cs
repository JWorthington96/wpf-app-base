using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DrinkingBuddy.Infrastructure;

/// <summary>
///     Responsible for creating the application builder, and registering all of the dependencies used in dependency injection and configuration.
/// </summary>
public class Bootstrapper
{
    /// <summary>
    ///     Builds and runs the host for dependency injection and configuration.
    /// </summary>
    public void Start()
    {
        var host = Host.CreateDefaultBuilder()
            .ConfigureServices((hostContext, services) => RegisterServices(services))
            .Build();
        host.RunAsync();
    }

    private void RegisterServices(IServiceCollection services)
    {

    }
}

