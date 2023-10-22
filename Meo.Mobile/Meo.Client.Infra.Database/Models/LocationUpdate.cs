using SQLite;

namespace Meo.Client.Infra.Database.Models;

[Table("LocationUpdates")]
internal record LocationUpdate
{
    [PrimaryKey]
    [AutoIncrement]
    [Column("id")]
    public int Id { get; init; }

    [Column("latitude")]
    public double Latitude { get; init; }

    [Column("longitude")]
    public double Longitude { get; init; }

    [Column("timestamp")]
    public DateTime Timestamp { get; init; }
}