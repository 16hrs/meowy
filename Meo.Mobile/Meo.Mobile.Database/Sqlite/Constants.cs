using SQLite;

namespace Meo.Mobile.Database.Sqlite;

static internal class Constants
{
    private const string Db_Filename = "MeoMobile.db3";

    internal const SQLiteOpenFlags Flags =
        // Open the database in read/write mode.
        SQLiteOpenFlags.ReadWrite |
        // Automatically create the database if it doesn't exist.
        SQLiteOpenFlags.Create |
        // File is encrypted and inaccessible when the device is locked.
        SQLiteOpenFlags.ProtectionComplete;

    static internal string Db_Path
        // TODO: Multi-targeting
        => Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        Db_Filename
        );
}