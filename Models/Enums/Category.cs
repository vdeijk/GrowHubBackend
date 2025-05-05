using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Category
    {
        Fertilize,
        Harvest,
        Prune,
        Water,
        Sow,
        Measure,
        Other
    }
}
