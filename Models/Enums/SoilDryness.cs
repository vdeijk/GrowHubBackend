using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SoilDryness
    {
        VeryWet, 
        Wet,
        Moist,
        Dry,
        VeryDry,
    }
}
