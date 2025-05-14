using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using MatchTraderBApi.Enums;
using MatchTraderBApi.Extensions;
using MatchTraderBApi.Models.Responses;
using MatchTraderBApi.Options;

namespace MatchTraderBApi.Helpers;

internal static class HttpClientHelper
{
    private static readonly JsonSerializerOptions JsonSerializerOptions = new() { Converters = { new JsonStringEnumConverter() } };
    private static readonly MediaTypeHeaderValue MediaTypeHeaderValue = new MediaTypeHeaderValue("application/json");
    private static readonly ProductInfoHeaderValue UserAgentHeaderValue = new ProductInfoHeaderValue("MatchTraderBApi", "1.0");
    
    internal static Task<MTrResponse<TResponse>> SendAuthorizedAsync<TResponse>
    (
        HttpClient httpClient,
        IMTrSettingsOptions settings,
        HttpMethod method,
        string path,
        CancellationToken cancellationToken
    )
    {
        return SendAuthorizedAsync<object?, TResponse>(
            httpClient,
            settings,
            method,
            path,
            null,
            cancellationToken);
    }
    
    internal static async Task<MTrResponse<TResponse>> SendAuthorizedAsync<TReqBody, TResponse>
    (
        HttpClient httpClient,
        IMTrSettingsOptions settings,
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
        
        var response = new MTrResponse<TResponse> { RetCode = MTrRetCode.MTrRet500InternalError };
        try
        {
            var request = new HttpRequestMessage(method, path);

            // Append request body
            var requestBody = new StringContent(JsonSerializer.Serialize(content, JsonSerializerOptions));
            requestBody.Headers.ContentType = MediaTypeHeaderValue;
            request.Content = requestBody;

            // Set headers
            request.Headers.Host = settings.RestHost;
            request.Headers.UserAgent.Add(UserAgentHeaderValue);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", settings.ApiKey);

            var httpResponse = await httpClient.SendAsync(request, cancellationToken);
            var httpResponseContent = await httpResponse.Content.ReadAsStringAsync(cancellationToken);

            if (!httpResponse.IsSuccessStatusCode)
            {
                response.RetCode = httpResponse.StatusCode.ToMTrRetCode();
                response.RetMessage = httpResponseContent;
                return response;
            }

            var responseData = JsonSerializer.Deserialize<TResponse>(httpResponseContent, JsonSerializerOptions);
            if (responseData is null)
            {
                response.RetCode = MTrRetCode.MTrRet500InternalError;
                response.RetMessage = "Response cannot be deserialized";
                return response;
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            throw;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
            response.RetMessage = ex.Message;
        }

        return response;
    }
}