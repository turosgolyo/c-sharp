namespace CustomLibrary.ConsoleExtensions;

public static class ExtendedConsole
{
    public static int ReadInteger(string prompt)
    {
        bool isNumber = false;
        int number = 0;

        do
        {        
            Console.WriteLine(prompt);

            string text = Console.ReadLine();
            isNumber = int.TryParse(text, out number);
        }
        while (!isNumber);

        return number;
        
    }
    public static int ReadInteger(string prompt, int max)
    {
        bool isNumber = false;
        int number = 0;

        do
        {
            Console.WriteLine(prompt);

            string text = Console.ReadLine();
            isNumber = int.TryParse(text, out number);

            if(number > max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A szám nem lehet nagyobb mint {max} 😂");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"A folytatashoz nyomjon meg bármely gombot 🤯");

                Console.ReadKey();
                Console.ResetColor();
            }
        }
        while (!isNumber || number > max);

        return number;

    }

    public static double ReadDouble(string prompt)
    {
        bool isNumber = false;
        double number = 0;

        do
        {
            Console.WriteLine(prompt);

            string text = Console.ReadLine();
            isNumber = double.TryParse(text, new CultureInfo("en-EN"), out number);
        }
        while (!isNumber);

        return number;

    }

    public static string ReadString(string prompt)
    {
        string text = string.Empty;

        do
        {
            Console.WriteLine(prompt);

            text = Console.ReadLine().Trim();
        }
        while (string.IsNullOrWhiteSpace(text));

        return text;

    }

    public static char ReadChar(string prompt)
    {
        char character;

        do
        {
            Console.WriteLine(prompt);
            character = char.ToUpper(Console.ReadKey().KeyChar);
        }
        while (char.IsWhiteSpace(character));

        return character;
    }
}