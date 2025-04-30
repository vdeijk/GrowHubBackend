using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WaterNeeds
    {
        Low,
        Medium,
        High,
    }
}
