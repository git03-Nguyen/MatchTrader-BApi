using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums;

public enum AccountType
{
    [EnumMember(Value = "ALL")]
    All,
    
    [EnumMember(Value = "CLIENT")]
    Client,
    
    [EnumMember(Value = "LEAD")]
    Lead,
}