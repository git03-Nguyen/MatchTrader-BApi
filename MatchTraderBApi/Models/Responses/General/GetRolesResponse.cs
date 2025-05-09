using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Responses.General;

public class GetRolesResponse
{
    [JsonPropertyName("roles")]
    public List<Role> Roles { get; set; }
}

public class Role
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("partnerId")]
    public long? PartnerId { get; set; }
    
    [JsonPropertyName("created")]
    public string created { get; set; }
    
    [JsonPropertyName("updated")]
    public string updated { get; set; }
}