using MatchTraderBApi.Options;

namespace MatchTraderBApi.HttpClientFactory;

internal interface IHttpClientFactoryCustom
{
    Task<TResponse> SendAuthorizedAsync<TReqBody, TResponse>
    (
        HttpClient httpClient,
        MTrSettingsOptions settings,
        HttpMethod method,
        string path,
        TReqBody? content,
        CancellationToken cancellationToken
    );
}