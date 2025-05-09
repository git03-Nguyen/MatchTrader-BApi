using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class GetMTrLedgerResponse
{
    [JsonPropertyName("operations")]
    public List<MTrLedger> Operrations { get; set; }
}