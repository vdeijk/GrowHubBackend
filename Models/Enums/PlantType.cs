using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PlantType
    {
        Tree,
        Shrub,
        Flower,
        Vine,
        Herb,
        Grass,
    }
}