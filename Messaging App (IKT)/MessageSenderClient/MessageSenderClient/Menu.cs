

namespace MessageSenderClient;

public static class Menu
{
    public static async Task MainMenu()
    {
        int choice = 0;
        MessageSendingResultResponse responseData;

        List<Message> messages = new List<Message>();
        messages = FileService.LoadJson();

        List<MessageSendingResultResponse> deliveredMessages = new List<MessageSendingResultResponse>();
        List<MessageSendingResultResponse> notDeliveredMessages = new List<MessageSendingResultResponse>();

        int successCount = 0;
        Dictionary<string, int> errorCounts = new Dictionary<string, int>();
        errorCounts.Add("Sikertelen uzenet kuldes", 0);
        errorCounts.Add("Nem a mefelelo a megadott rendszer", 0);
        errorCounts.Add("Az uzenet nem megfelelo formatumu", 0);

        while (choice < 1 || choice > 2)
        {
            choice = ExtendedConsole.ReadInteger("\nVálasszon az alábbiak közül!\n\n\t1 - Üzenetek küldése\n\t2 - Kilépés\n");
        }

        switch (choice)
        {
            case 1:
                foreach (Message message in messages)
                {
                    switch (message.System)
                    {
                        case MobileOperatingSystem.iOS:
                            responseData = await MessageService.SendIosMessageAsync(CreateIosMessage(message));
                            if (responseData.Success)
                            {
                                deliveredMessages.Add(responseData);
                                successCount++;
                            }
                            else
                            {
                                notDeliveredMessages.Add(responseData);
                                errorCounts[responseData.ErrorMessage]++;
                            }
                            break;
                        case MobileOperatingSystem.Android:
                            responseData = await MessageService.SendAndroidMessageAsync(CreateAndroidMessage(message));
                            if (responseData.Success)
                            {
                                deliveredMessages.Add(responseData);
                                successCount++;
                            }
                            else
                            {
                                notDeliveredMessages.Add(responseData);
                                errorCounts[responseData.ErrorMessage]++;
                            }
                            break;
                        case MobileOperatingSystem.Windows:
                            responseData = await MessageService.SendWindowsMessageAsync(CreateWindowsMessage(message));
                            if (responseData.Success)
                            {
                                deliveredMessages.Add(responseData);
                                successCount++;
                            }
                            else
                            {
                                notDeliveredMessages.Add(responseData);
                                errorCounts[responseData.ErrorMessage]++;
                            }
                            break;
                        default:
                            break;
                    }
                }

                await FileService.WriteResponseToTextAsync(deliveredMessages, "delivered");
                await FileService.WriteResponseToTextAsync(notDeliveredMessages, "not-delivered");

                char c = ExtendedConsole.YesOrNo("\nSzeretne jelentést készíteni? [y/n]\n", 'y', 'n');

                if(c == 'y') {
                    await FileService.WriteReportToJson(errorCounts, successCount, "report");
                    
                    Console.WriteLine("\nA jelentés elkészült!");
                    
                    await Task.Delay(3000);
                    await MainMenu();
                    break;
                }
                else 
                {
                    await Task.Delay(3000);
                    await MainMenu();
                    break;
                }              
            default :
                return;
        }  
    }

    public static MessageRequest CreateIosMessage(Message message)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(message.System + "|" + message.FirstName + "|" + message.LastName + "|" + message.MobileNumber + "|" + message.MessageContent);

        MessageRequest iosMessage = new MessageRequest(0, sb.ToString());

        return iosMessage;
    }
    public static MessageRequest CreateAndroidMessage(Message message)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(message.System + "#" + message.FirstName + "#" + message.LastName + "#" + message.MobileNumber + "#" + message.MessageContent);

        MessageRequest androidMessage = new MessageRequest(1, sb.ToString());

        return androidMessage;
    }
    public static MessageRequest CreateWindowsMessage(Message message)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(message.System + "*" + message.FirstName + "*" + message.LastName + "*" + message.MobileNumber + "*" + message.MessageContent);

        MessageRequest windowsMessage = new MessageRequest(2, sb.ToString());

        return windowsMessage;
    }
}
