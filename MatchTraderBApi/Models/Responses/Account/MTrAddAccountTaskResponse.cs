using System.Text.Json.Serialization;
using MatchTraderBApi.Enums.Account;

namespace MatchTraderBApi.Models.Responses.Account;

public class MTrAddAccountTaskResponse
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("accountUuid")]
    public string AccountUuid { get; set; }

    [JsonPropertyName("type")]
    public MTrTaskType Type { get; set; }

    [JsonPropertyName("startDate")]
    public string StartDate { get; set; }

    [JsonPropertyName("status")]
    public MTrTaskStatus Status { get; set; }

    [JsonPropertyName("accountManagerUuid")]
    public string AccountManagerUuid { get; set; }

    [JsonPropertyName("comment")]
    public string Comment { get; set; }
}
