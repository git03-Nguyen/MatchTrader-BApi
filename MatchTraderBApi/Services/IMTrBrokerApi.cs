using MatchTraderBApi.Options;
using MatchTraderBApi.Services.Interfaces;

namespace MatchTraderBApi.Services;

public interface IMTrBrokerApi : 
    IMTrGeneralBrokerApi,
    IMTrAccountBrokerApi,
    IMTrTradingAccountApi,
    IMTrTradingBrokerApi,
    IDisposable
{
    HttpClient HttpClient { get; set; }
    IMTrSettingsOptions Settings { get; set; }
}