using SQLite;

namespace Meo.Client.Core.Abstractions;

public interface ISqliteConnectionFactory
{
    Task<SQLiteAsyncConnection> CreateConnection();
}