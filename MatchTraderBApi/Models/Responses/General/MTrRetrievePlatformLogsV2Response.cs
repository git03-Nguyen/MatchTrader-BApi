using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos.Trading;

namespace MatchTraderBApi.Models.Responses.General;

public class MTrRetrievePlatformLogsV2Response
{
    [JsonPropertyName("operations")]
    public List<MTrLedger> Operations { get; set; }
}
