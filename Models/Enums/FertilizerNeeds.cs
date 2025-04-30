using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FertilizerNeeds
    {
        None,
        Low,
        Medium,
        High,
    }
}