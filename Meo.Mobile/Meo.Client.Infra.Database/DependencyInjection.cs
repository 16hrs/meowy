using Meo.Client.Core.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Meo.Client.Infra.Database;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddSingleton<ISqliteConnectionFactory, SqliteConnectionFactory.SqliteConnectionFactory>();
        return services;
    }
}