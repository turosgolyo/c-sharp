using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace MessagingApp;

public static class FileService
{
    #region Load JSON

    public static List<Message> LoadJson()
    {
        string path = Path.Combine("source", "messages.json");

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
        using (StreamReader sr = new StreamReader(fs))
        {
            string json = sr.ReadToEnd();
            List<Message> messages = JsonConvert.DeserializeObject<List<Message>>(json);
            return messages;
        }
    }

    #endregion

    #region Write JSON

    public static async Task WriteJsonToFile(MessageSendingResultResponse response)
    {
        string path = Path.Combine("log", "result.txt");
        string json = JsonConvert.SerializeObject(response);
        await System.IO.File.WriteAllTextAsync(path, json);
    }

    #endregion

    #region Print JSON

    public static void PrintJson(List<Message> messages)
    {
        foreach(Message message in messages)
        {
            Console.WriteLine(message);
        }
    }
    public static void PrintJson(List<MessageRequest> messages)
    {
        foreach (MessageRequest message in messages)
        {
            Console.WriteLine(message);
        }
    }

    #endregion
}
