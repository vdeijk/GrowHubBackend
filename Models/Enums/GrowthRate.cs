using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GrowthRate
    {
        Slow,
        Medium,
        Fast,
    }
}