using HttpServices;

List<Message> messages = new List<Message>();

messages = MessagingApp.FileService.LoadJson();


List<MessageRequest> messageBodies = new List<MessageRequest>();

foreach(Message message in messages)
{
    MessageRequest messageBody = new MessageRequest(((int)message.System), message.MessageContent);
    messageBodies.Add(messageBody);
}

MessageRequest firstMessage = messageBodies[0];



MessageSendingResultResponse responseData = await MessageService.SendWindowsMessageAsync(firstMessage);

Console.WriteLine(responseData.Success);
Console.WriteLine(responseData.ErrorMessage);
Console.WriteLine(responseData.DateTime);

