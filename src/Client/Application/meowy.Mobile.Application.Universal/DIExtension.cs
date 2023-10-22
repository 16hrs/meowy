using meowy.Client.Application.Shared.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace meowy.Client.Application;

public static class DIExtension
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ILocationService, ILocationService>();
        return serviceCollection;
    }
}