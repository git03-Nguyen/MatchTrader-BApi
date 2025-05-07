using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums.SortingFields;

public enum TradingAccountSortingField
{
    [EnumMember(Value = "created")]
    Created,
    
    [EnumMember(Value = "updated")]
    Updated,
    
    [EnumMember(Value = "accountConfiguration.partnerId")]
    PartnerId,
    
    [EnumMember(Value = "contactDetails.email")]
    Email,
}