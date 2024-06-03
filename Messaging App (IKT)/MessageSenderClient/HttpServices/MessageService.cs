namespace HttpServices;

public class MessageService: BaseService
{
    public static async Task SendIOSMessageAsync(MessageRequest message)
    {
            await SendPostRequestAsync<MessageRequest>("api/send/ios", message);
    }

    public static async Task<bool> SendAndroidMessageAsync(MessageRequest message)
    {
        try
        {
            await SendPostRequestAsync<MessageRequest>("api/send/android", message);

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static async Task<MessageSendingResultResponse> SendWindowsMessageAsync(MessageRequest message)
    {
        try
        {
            MessageSendingResultResponse response = await SendPostRequestAsync<MessageSendingResultResponse>("api/send/windows", message);
            
            return response;
        }
        catch (Exception)
        {
            return null;
        }
    }
}

