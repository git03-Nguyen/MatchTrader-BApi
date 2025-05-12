using MatchTraderBApi.Options;
using MatchTraderBApi.Services.Interfaces;

namespace MatchTraderBApi.Services;

public interface IMTrBrokerApi : 
    IMTrGeneralBrokerApi,
    IMTrAccountBrokerApi,
    IMTrTradingBrokerApi,
    IDisposable
{
    HttpClient HttpClient { get; set; }
    MTrSettingsOptions Settings { get; set; }
}