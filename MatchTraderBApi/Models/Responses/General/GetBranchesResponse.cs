using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Responses.General;

public class GetBranchesResponse
{
    [JsonPropertyName("branches")]
    public List<Branch> Branches { get; set; }
}

public class Branch
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("partnerId")]
    public string PartnerId { get; set; }

    [JsonPropertyName("created")]
    public string Created { get; set; }

    [JsonPropertyName("updated")]
    public string Updated { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("mailingConfiguration")]
    public MailingConfiguration MailingConfiguration { get; set; }

    [JsonPropertyName("tfaRequiredForClients")]
    public bool TfaRequiredForClients { get; set; }

    [JsonPropertyName("mt4RealServerName")]
    public string Mt4RealServerName { get; set; }

    [JsonPropertyName("mt4DemoServerName")]
    public string Mt4DemoServerName { get; set; }

    [JsonPropertyName("mt5RealServerName")]
    public string Mt5RealServerName { get; set; }

    [JsonPropertyName("mt5DemoServerName")]
    public string Mt5DemoServerName { get; set; }

    [JsonPropertyName("useSumSubKyc")]
    public bool UseSumSubKyc { get; set; }

    [JsonPropertyName("paymentGatewayUuids")]
    public List<string> PaymentGatewayUuids { get; set; }
}

public class MailingConfiguration
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