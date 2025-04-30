using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Category
    {
        Work,
        Personal,
        Other,
    }
}
