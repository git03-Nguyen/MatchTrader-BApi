using MatchTraderBApi.Enums;

namespace MatchTraderBApi.Exceptions;

public class MTrRequestException : Exception
{
    public MTrRetCode MTrRetCode { get; set; }
    public string MtrContent { get; set; }
    
    public MTrRequestException(MTrRetCode mtrRetCode, string mtrContent) 
        : base($"Match Trader API request failed. MTrRetCode = {mtrRetCode}, MTrContent: {mtrContent}")
    {
        MTrRetCode = mtrRetCode;
        MtrContent = mtrContent;
    }
    
    public MTrRequestException(MTrRetCode mtrRetCode, string mtrContent, Exception innerException) 
        : base($"Match Trader API request failed. MTrRetCode = {mtrRetCode}, MTrContent: {mtrContent}", innerException)
    {
        MTrRetCode = mtrRetCode;
        MtrContent = mtrContent;
    }
}