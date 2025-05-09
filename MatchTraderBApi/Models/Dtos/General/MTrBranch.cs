using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.General;

public class MTrBranch
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("partnerId")]
    public string PartnerId { get; set; }

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    [JsonPropertyName("updated")]
    public DateTime Updated { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("mailingConfiguration")]
    public MTrMailingConfiguration MTrMailingConfiguration { get; set; }

    [JsonPropertyName("tfaRequiredForClients")]
    public bool IsTfaRequiredForClients { get; set; }

    [JsonPropertyName("mt4RealServerName")]
    public string Mt4RealServerName { get; set; }

    [JsonPropertyName("mt4DemoServerName")]
    public string Mt4DemoServerName { get; set; }

    [JsonPropertyName("mt5RealServerName")]
    public string Mt5RealServerName { get; set; }

    [JsonPropertyName("mt5DemoServerName")]
    public string Mt5DemoServerName { get; set; }

    [JsonPropertyName("useSumSubKyc")]
    public bool IsUseSumSubKyc { get; set; }

    [JsonPropertyName("paymentGatewayUuids")]
    public List<string> PaymentGatewayUuids { get; set; }
}