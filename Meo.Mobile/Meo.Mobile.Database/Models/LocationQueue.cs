using SQLite;

namespace Meo.Mobile.Database.Models;

[Table("LocationPings")]
internal record LocationPing
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