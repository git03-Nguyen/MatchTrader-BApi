using MatchTraderBApi.Services.Interfaces;

namespace MatchTraderBApi.Services;

public interface IMTrBrokerApi : IMTrGeneralBrokerApi
{
    HttpClient HttpClient { get; set; }
}