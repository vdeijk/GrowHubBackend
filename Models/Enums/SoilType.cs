using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SoilType
    {
        Loam,
        Sand,
        Clay,
        Silt,
        Peat,
        Chalk
    }
}
