public static class FileService
{
    public static DateTime now = DateTime.Now;
    #region Load JSON

    public static List<Message> LoadJson()
    {
        string path = Path.Combine("Source", "messages.json");

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

    public static async Task WriteReportToJson(Dictionary<string, int> errorCounts, int successCount, string fileName)
    {
        Directory.CreateDirectory("reports");

        var report = new
        {
            errors = errorCounts.Select(e => new { reason = e.Key, count = e.Value }).ToList(),
            success = successCount,
            date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        };

        string path = Path.Combine("reports", $"{fileName}_{now:yyyy-MM-dd}.json");
        await File.WriteAllTextAsync(path, JsonConvert.SerializeObject(report, Formatting.Indented));
    }

    #endregion

    #region Write TXT

    public static async Task WriteResponseToTextAsync(List<MessageSendingResultResponse> responses, string fileName)
    {
        Directory.CreateDirectory("log");

        string path = Path.Combine("log", $"{fileName}_{now:yyyy-MM-dd}.txt");

        using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach (MessageSendingResultResponse r in responses)
        {
            await sw.WriteLineAsync($"{r}");
        }
    }

    #endregion

    #region Print JSON

    public static void PrintJson(List<Message> messages)
    {
        foreach (Message message in messages)
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
