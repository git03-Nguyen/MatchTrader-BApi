using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums;

public enum SortingOrder
{
    [EnumMember(Value = "asc")]
    Asc,
    
    [EnumMember(Value = "desc")]
    Desc
}