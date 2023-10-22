using SQLite;

namespace Meo.Client.Infra.Database.Models;

[Table("LocationUpdateSyncQueue")]
internal record LocationUpdateSyncQueue
{
    [PrimaryKey]
    [AutoIncrement]
    [Column("id")]
    public int Id { get; init; }

    [Column("locationUpdates")]
    private ICollection<LocationUpdate> LocationUpdates { get; init; }
}