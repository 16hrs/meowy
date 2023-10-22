using Meo.Client.Core.Abstractions;
using Meo.Client.Infra.Database.Sqlite;
using Microsoft.Extensions.DependencyInjection;

namespace Meo.Client.Infra.Database;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddSingleton<ISqliteConnectionFactory, SqliteConnectionFactory>();
        return services;
    }
}