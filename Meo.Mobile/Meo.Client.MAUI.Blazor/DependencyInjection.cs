using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;

namespace Meo.Client.MAUI.Blazor;

public static class DependencyInjection
{
    public static IServiceCollection AddBlazor(this IServiceCollection services)
    {
        services.AddMudServices();
        return services;
    }
}