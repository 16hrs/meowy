using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;

namespace Meo.Client.Blazor;

public static class DependencyInjection
{
    public static IServiceCollection AddBlazor(this IServiceCollection services)
    {
        services.AddMudServices();
        return services;
    }
}