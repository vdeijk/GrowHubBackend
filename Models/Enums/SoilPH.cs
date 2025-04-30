using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SoilPH
    {
        Acidic,
        Neutral,
        Alkaline
    }
}