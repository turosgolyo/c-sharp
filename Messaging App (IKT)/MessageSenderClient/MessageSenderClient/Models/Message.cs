public class Message
{
    [JsonPropertyName("system")]
    public MobileOperatingSystem System { get; set; }
    
    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }
    
    [JsonPropertyName("lastName")]
    public string LastName { get; set; }

    [JsonPropertyName("mobileNumber")]
    public string MobileNumber { get; set; }

    [JsonPropertyName("message")]
    public string MessageContent { get; set; }
    
    public Message(MobileOperatingSystem system, string firstName, string lastName, string mobileNumber, string message)
    {
        System = system;
        FirstName = firstName;
        LastName = lastName;
        MobileNumber = mobileNumber;
        MessageContent = message;
    }

    public override string ToString()
    {
        return $"Feladó: {FirstName} {LastName}\nRendszer: {System}\nTelefon szám: {MobileNumber}\nÜzenet: {MessageContent}\n";
    }
}
