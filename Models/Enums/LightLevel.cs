using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LightLevel
    {
        VeryLow,
        Low,
        Moderate,
        Light,
        VeryLight,
    }
}
