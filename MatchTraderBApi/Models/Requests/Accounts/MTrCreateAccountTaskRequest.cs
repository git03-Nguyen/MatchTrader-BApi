using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Accounts;

public class MTrCreateAccountTaskRequest
{
    [JsonPropertyName("accountUuid")]
    public string AccountUuid { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("startDate")]
    public DateTime StartDate { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("accountManagerUuid")]
    public string AccountManagerUuid { get; set; }

    [JsonPropertyName("comment")]
    public string Comment { get; set; }
}
