using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;

namespace Meo.Mobile.Blazor;

public static class ServiceExtension
{
    public static IServiceCollection AddBlazor(this IServiceCollection services)
    {
        services.AddMudServices();
        return services;
    }
}