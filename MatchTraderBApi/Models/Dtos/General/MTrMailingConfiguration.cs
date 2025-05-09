using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.General;

public class MTrMailingConfiguration
{
    [JsonPropertyName("emailUser")]
    public string EmailUser { get; set; }

    [JsonPropertyName("emailPassword")]
    public string EmailPassword { get; set; }

    [JsonPropertyName("emailHost")]
    public string EmailHost { get; set; }

    [JsonPropertyName("emailPort")]
    public int? EmailPort { get; set; } // Nullable int for emailPort

    [JsonPropertyName("emailTls")]
    public bool EmailTls { get; set; }

    [JsonPropertyName("emailSsl")]
    public bool EmailSsl { get; set; }
}