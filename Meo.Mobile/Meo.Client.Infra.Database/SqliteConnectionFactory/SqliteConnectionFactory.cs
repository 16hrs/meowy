using Meo.Client.Core.Abstractions;
using Meo.Client.Infra.Database.Models;
using SQLite;

namespace Meo.Client.Infra.Database.SqliteConnectionFactory;

public class SqliteConnectionFactory : ISqliteConnectionFactory
{
    public async Task<SQLiteAsyncConnection> CreateConnection()
    {
        var connection = new SQLiteAsyncConnection(Constants.Db_Path, Constants.Flags);
        await connection.CreateTableAsync<LocationUpdate>();
        await connection.CreateTableAsync<LocationUpdateSyncQueue>();
        return connection;
    }
}