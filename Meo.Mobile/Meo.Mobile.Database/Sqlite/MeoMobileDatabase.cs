using Meo.Mobile.Database.Models;
using SQLite;

namespace Meo.Mobile.Database.Sqlite;

internal class MeoMobileDatabase
{
    private SQLiteAsyncConnection _connection;

    private async Task InitializeAsync()
    {
        _connection = new SQLiteAsyncConnection(Constants.Db_Path, Constants.Flags);
        await _connection.CreateTableAsync<LocationPing>();
    }

    async internal Task AddLocationAsync(LocationPing locationPing)
    {
        if (_connection is null)
            await InitializeAsync();

        await _connection.InsertAsync(locationPing);
    }
}