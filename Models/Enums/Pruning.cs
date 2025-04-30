using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Pruning
    {
        Light,
        Moderate,
        Heavy,
    }
}