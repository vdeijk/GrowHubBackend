using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SunPreference
    {
        FullSun,
        PartialShade,
        FullShade
    }
}
