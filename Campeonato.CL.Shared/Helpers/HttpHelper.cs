using System.Text;
using System.Text.Json;

namespace Campeonato.CL.Shared.Helpers
{
    public class HttpHelper
    {
        public static StringContent ToJson(object body)
        {
            return new StringContent(JsonSerializer.Serialize(body),
                                        Encoding.UTF8,
                                        "application/json"
                                     );
        }

        public static async Task<T?> FromJsonAsync<T>(HttpResponseMessage responseMessage)
        {
            JsonSerializerOptions options = new()
            {
                PropertyNameCaseInsensitive = true
            };

            var content = await responseMessage.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(content, options);
        }

    }
}
