using System.Runtime.Serialization;

namespace MatchTraderBApi.Enums;

public enum MTrLedgerType
{
    [EnumMember(Value = "DEPOSIT")]
    Deposit,
    
    [EnumMember(Value = "WITHDRAWAL")]
    Withdrawal,
    
    [EnumMember(Value = "CREDIT_IN")]
    CreditIn,
    
    [EnumMember(Value = "CREDIT_OUT")]
    CreditOut,
    
    [EnumMember(Value = "AGENT_COMMISSION")]
    AgentCommission,
    
    [EnumMember(Value = "COMMISSIONS")]
    Commissions,
    
    [EnumMember(Value = "SWAPS")]
    Swaps,
    
    [EnumMember(Value = "CLOSED_POSITION")]
    ClosedPosition,
}