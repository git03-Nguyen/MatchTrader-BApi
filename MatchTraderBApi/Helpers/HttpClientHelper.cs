using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using MatchTraderBApi.Enums;
using MatchTraderBApi.Exceptions;
using MatchTraderBApi.Options;

namespace MatchTraderBApi.Helpers;

internal static class HttpClientHelper
{
    private static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        Converters = { new JsonStringEnumConverter() }
    };
    
    private static readonly MediaTypeHeaderValue MediaTypeHeaderValue = new MediaTypeHeaderValue("application/json");
    private static readonly ProductInfoHeaderValue UserAgentHeaderValue = new ProductInfoHeaderValue("MatchTraderBApi", "1.0");
    
    internal static async Task<TResponse> SendAuthorizedAsync<TReqBody, TResponse>
    (
        HttpClient httpClient,
        MTrSettingsOptions settings,
        HttpMethod method,
        string path,
        TReqBody? content,
        CancellationToken cancellationToken
    )
    {
        if (string.IsNullOrWhiteSpace(settings.ApiKey))
        {
            throw new InvalidOperationException($"API key is not set.");
        }
        
        var request = new HttpRequestMessage(method, path);
        
        // Append request body
        var requestBody = new StringContent(JsonSerializer.Serialize(content, JsonSerializerOptions));
        requestBody.Headers.ContentType = MediaTypeHeaderValue;
        request.Content = requestBody;

        // Set headers
        request.Headers.Host = settings.RestHost;
        request.Headers.UserAgent.Add(UserAgentHeaderValue);
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", settings.ApiKey);

        var response = await httpClient.SendAsync(request, cancellationToken);
        var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);
        
        if (!response.IsSuccessStatusCode)
        {
            throw new MTrRequestException((MTrRetCode)response.StatusCode, responseContent);
        }
        
        var responseData = JsonSerializer.Deserialize<TResponse>(responseContent, JsonSerializerOptions);
        if (responseData is null)
        {
            throw new InvalidOperationException($"Failed to deserialize response data: {responseContent}");
        }
        
        return responseData;
    }
}