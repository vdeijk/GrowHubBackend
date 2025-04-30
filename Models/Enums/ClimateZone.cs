using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ClimateZone
    {
        Arid,
        SemiArid,
        Mediterranean,
        Temperate,
        Tropical,
        Subtropical
    }
}