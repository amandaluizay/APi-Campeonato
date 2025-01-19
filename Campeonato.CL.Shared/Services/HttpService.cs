using Campeonato.CL.Shared.Helpers;
using Campeonato.CL.Shared.Interfaces;
using System.Web;

namespace Campeonato.CL.Shared.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;
        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            //_httpClient.BaseAddress = new Uri("https://api.api-futebol.com.br/v1/");
        }

        public async Task<T?> GetAsync<T>(string url, string? apiKey, List<string>? parameters = null)
        {
            var response = await ExecuteAsync(url, apiKey, parameters, null, HttpMethod.Get);

            return await HttpHelper.FromJsonAsync<T>(response);
        }

        private async Task<HttpResponseMessage> ExecuteAsync (string url, string? apiKey, List<string>? parameters, object? body, HttpMethod httpMethod)
        {
            var httpRequestMessage = new HttpRequestMessage(httpMethod, url);

            if (body != null)
            {
                httpRequestMessage.Content = HttpHelper.ToJson(body);
            }

            if(apiKey != null)
            {
                httpRequestMessage.Headers.Add("Authorization", $"Bearer {apiKey}");
            }

            if (parameters != null)
            {
                var query = HttpUtility.ParseQueryString(string.Empty);
                foreach (var parameter in parameters)
                {
                    query[parameter] = parameters[parameters.IndexOf(parameter)];
                }
                
                httpRequestMessage.RequestUri = new Uri($"{url}?{query}");
            }

            return await _httpClient.SendAsync(httpRequestMessage);
        }
    }
}
