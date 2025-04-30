using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Priority
    {
        High,
        Medium,
        Low,
    }
}