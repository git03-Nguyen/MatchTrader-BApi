using MatchTraderBApi.Options;
using MatchTraderBApi.Services.Interfaces;

namespace MatchTraderBApi.Services;

public interface IMTrBrokerApi : IMTrGeneralBrokerApi, IMTrAccountApi, IDisposable
{
    HttpClient HttpClient { get; set; }
    MTrSettingsOptions Settings { get; set; }
}