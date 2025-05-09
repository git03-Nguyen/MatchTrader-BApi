using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums.Account;

public enum MTrClientType
{
    [EnumMember(Value = "RETAIL")]
    Retail,
    
    [EnumMember(Value = "PROFESSIONAL")]
    Professional,
    
    [EnumMember(Value = "EXPERIENCED")]
    Experienced,
}