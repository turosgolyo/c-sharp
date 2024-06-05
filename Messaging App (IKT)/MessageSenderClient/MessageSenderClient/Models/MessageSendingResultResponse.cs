public class MessageSendingResultResponse
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    [JsonPropertyName("dateTime")]
    public string? DateTime { get; set; }

    public MessageSendingResultResponse(bool success, string errorMessage, string dateTime)
    {
        Success = success;
        ErrorMessage = errorMessage;
        DateTime = dateTime;
    }

    public override string ToString()
    {
        return $"{Success} - {DateTime} - {ErrorMessage}";
    }
}
