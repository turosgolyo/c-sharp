namespace Models;

public class MessageRequest
{
    [JsonPropertyName("content")]
    public string? Message { get; set; }

    [JsonPropertyName("system")]
    public int System { get; set; }
   

    public MessageRequest(int system, string? message)
    {
        System = system;
        Message = message;
    }

    public override string ToString()
    {
        return $"{System} - {Message}";
    }
}
