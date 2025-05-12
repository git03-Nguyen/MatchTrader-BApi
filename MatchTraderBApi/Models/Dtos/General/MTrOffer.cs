using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.General;

public class MTrOffer
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("partnerId")]
    public long? PartnerId { get; set; }

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    [JsonPropertyName("updated")]
    public DateTime Updated { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("demo")]
    public bool IsDemo { get; set; }

    [JsonPropertyName("hidden")]
    public bool IsHidden { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("moneyManager")]
    public string? MoneyManager { get; set; }

    [JsonPropertyName("initialDeposit")]
    public decimal InitialDeposit { get; set; }

    [JsonPropertyName("leverage")]
    public int Leverage { get; set; }

    [JsonPropertyName("verificationRequired")]
    public bool IsVerificationRequired { get; set; }

    [JsonPropertyName("tradingAccountAutoCreation")]
    public bool IsTradingAccountAutoCreation { get; set; }

    [JsonPropertyName("groupName")]
    public string GroupName { get; set; }

    [JsonPropertyName("branch")]
    public MTrOfferBranch Branch { get; set; }

    [JsonPropertyName("system")]
    public MTrOfferSystem System { get; set; }

    [JsonPropertyName("operation")]
    public MTrOfferOperation Operation { get; set; }
}