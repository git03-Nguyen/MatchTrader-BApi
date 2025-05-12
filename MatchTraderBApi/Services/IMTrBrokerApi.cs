using MatchTraderBApi.Services.Interfaces;

namespace MatchTraderBApi.Services;

public interface IMTrBrokerApi : IMTrGeneralBrokerApi, IMTrAccountApi
{
    HttpClient HttpClient { get; set; }
}