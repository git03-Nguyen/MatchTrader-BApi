using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Responses.Account;

public class MTrCreateAccountTaskResponse
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("accountUuid")]
    public string AccountUuid { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("startDate")]
    public string StartDate { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("accountManagerUuid")]
    public string AccountManagerUuid { get; set; }

    [JsonPropertyName("comment")]
    public string Comment { get; set; }
}
