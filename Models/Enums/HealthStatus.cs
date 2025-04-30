using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HealthStatus
    {
        Poor,
        Fair,
        Good,
        VeryGood,
        Excellent
    }
}