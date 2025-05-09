using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums.Account;

public enum MTrTaskStatus
{
    [EnumMember(Value = "TODO")]
    Todo,
    
    [EnumMember(Value = "IN_PROGRESS")]
    InProgress,
    
    [EnumMember(Value = "DONE")]
    Done,
}