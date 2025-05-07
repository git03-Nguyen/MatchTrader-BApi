using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums.SortingFields;

public enum BasicSortingField
{
    [EnumMember(Value = "created")]
    Created,
    
    [EnumMember(Value = "updated")]
    Updated,
}