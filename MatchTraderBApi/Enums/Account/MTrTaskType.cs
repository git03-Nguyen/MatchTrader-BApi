using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums.Account;

public enum MTrTaskType
{
    [EnumMember(Value = "TASK")]
    Task,
    
    [EnumMember(Value = "CALL_ASSIGNMENT")]
    CallAssignment,
}