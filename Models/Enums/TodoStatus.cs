using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TodoStatus
    {
        NotStarted,
        InProgress,
        Completed,
        OnHold,
        Cancelled,
    }
}
