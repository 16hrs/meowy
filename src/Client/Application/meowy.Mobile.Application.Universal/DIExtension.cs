using meowy.Mobile.Application.Universal.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace meowy.Mobile.Application.Universal;

public static class DIExtension
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ILocationService, ILocationService>();
        return serviceCollection;
    }
}