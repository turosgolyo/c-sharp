public class MessageService: BaseService
{
    public static async Task<MessageSendingResultResponse> SendIosMessageAsync(MessageRequest message) => await SendPostRequestAsync<MessageSendingResultResponse>("api/send/ios", message);

    public static async Task<MessageSendingResultResponse> SendAndroidMessageAsync(MessageRequest message) => await SendPostRequestAsync<MessageSendingResultResponse>("api/send/android", message);

    public static async Task<MessageSendingResultResponse> SendWindowsMessageAsync(MessageRequest message) => await SendPostRequestAsync<MessageSendingResultResponse>("api/send/windows", message);
}

