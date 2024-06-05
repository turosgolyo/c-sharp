public class BaseService
{
    private static HttpClient httpClient;
    private static JsonSerializerOptions options;
    private const string baseURL = "https://localhost:7112";

    static BaseService()
    {
        httpClient = new HttpClient();
        SetHeaders();

        options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };
    }

    public static async Task<TResponse> SendPostRequestAsync<TResponse>(string route, object body)
    {
        try
        {
            var request = BuildRequestMessage(HttpMethod.Post, route, body);

            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var responseContent = await SerializeResponseAsync<TResponse>(response.Content);
            return responseContent;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return (TResponse)default;
        }
    }

    private static void SetHeaders()
    {
        httpClient.BaseAddress ??= new Uri(baseURL);

        if (!httpClient.DefaultRequestHeaders.Any())
        {
            httpClient.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
            httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("plain/text"));
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }

    private static HttpRequestMessage BuildRequestMessage(HttpMethod httpMethod, string route, object body)
    {
        return new HttpRequestMessage
        {
            Method = httpMethod,
            RequestUri = BuildUri(route),
            Content = body is not null ?
                      new StringContent(System.Text.Json.JsonSerializer.Serialize(body), Encoding.UTF8, MediaTypeNames.Application.Json) :
                      null
        };
    }

    private static Uri BuildUri(string route) => new Uri($"{baseURL}/{route}");

    private static Uri BuildUri(string route, object routParam) => new Uri($"{baseURL}/{route}/{routParam}");

    public static async Task<T> SerializeResponseAsync<T>(HttpContent content)
    {
        var encoding = content.Headers.ContentEncoding.FirstOrDefault();
        var responseStream = await content.ReadAsStreamAsync();
        var stream = encoding switch
        {
            "gzip" => new GZipStream(responseStream, CompressionMode.Decompress),
            "deflate" => new DeflateStream(responseStream, CompressionMode.Decompress),
            "br" => new BrotliStream(responseStream, CompressionMode.Decompress),
            _ => responseStream

        };

        var result = System.Text.Json.JsonSerializer.Deserialize<T>(stream, options);
        return result;
    }
}
