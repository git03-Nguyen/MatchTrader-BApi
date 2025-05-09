using System.Text.Json.Serialization;
using MatchTraderBApi.Enums.Account;

namespace MatchTraderBApi.Models.Requests.Accounts;

public class MTrAddAccountTaskRequest
{
    [JsonPropertyName("accountUuid")]
    public string AccountUuid { get; set; }

    [JsonPropertyName("type")]
    public MTrTaskType Type { get; set; }

    [JsonPropertyName("startDate")]
    public DateTime StartDate { get; set; }

    [JsonPropertyName("status")]
    public MTrTaskStatus Status { get; set; }

    [JsonPropertyName("accountManagerUuid")]
    public string AccountManagerUuid { get; set; }

    [JsonPropertyName("comment")]
    public string Comment { get; set; }
}
