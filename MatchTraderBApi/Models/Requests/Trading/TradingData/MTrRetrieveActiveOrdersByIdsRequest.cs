using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading.TradingData;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct MTrRetrieveActiveOrdersByIdsRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("ids")]
    public IEnumerable<string> OrderIds { get; set; }
}