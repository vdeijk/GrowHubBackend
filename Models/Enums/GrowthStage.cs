using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GrowthStage
    {
        Germination,
        Seedling,
        Vegetative,
        Budding,
        Flowering,
        Fruiting,
        Maturity
    }
}