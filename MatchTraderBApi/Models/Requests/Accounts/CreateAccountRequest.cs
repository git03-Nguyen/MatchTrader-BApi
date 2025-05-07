using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Accounts;

public class CreateAccountRequest
{
    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("password")]
    public string Password { get; set; }

    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }

    [JsonPropertyName("lastName")]
    public string LastName { get; set; }

    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("address")]
    public string Address { get; set; }

    [JsonPropertyName("postCode")]
    public string PostCode { get; set; }

    [JsonPropertyName("branchUuid")]
    public string BranchUuid { get; set; }

    [JsonPropertyName("offerUuid")]
    public string OfferUuid { get; set; }
}