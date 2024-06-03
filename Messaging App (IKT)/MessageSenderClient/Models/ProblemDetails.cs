namespace Models;

public class ProblemDetails
{
    [JsonPropertyName("type")]
    string? Type { get; set; }
    
    [JsonPropertyName("title")]
    string? Title { get; set; }

    [JsonPropertyName("status")]
    int? Status { get; set; }

    [JsonPropertyName("detail")]
    string? Detail { get; set; }

    [JsonPropertyName("instance")]
    string? Instance { get; set; }

    public ProblemDetails(string? type, string? title, int? status, string? detail, string? instance)
    {
        Type = type;
        Title = title;
        Status = status;
        Detail = detail;
        Instance = instance;
    }
}
