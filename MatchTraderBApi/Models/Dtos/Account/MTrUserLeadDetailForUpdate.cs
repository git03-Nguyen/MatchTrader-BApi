using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrUserLeadDetailForUpdate
{
    [JsonPropertyName("leadStatusUuid")]
    public string LeadStatusUuid { get; set; }
    
    public MTrUserLeadDetailForUpdate()
    {
    }
    
    public MTrUserLeadDetailForUpdate(string leadStatusUuid)
    {
        LeadStatusUuid = leadStatusUuid;
    }
}