using IOLibrary;
using CustomLibrary;

char choice;
double celsius;

celsius = ExtendedConsole.ReadDouble("Adja meg a hőmérsékletet celsiusban!");

do
{
    choice = ExtendedConsole.ReadChar("\nKelvin - K \nFahrenheit - F");
} 
while (choice != 'F' && choice != 'K');

double result = choice switch
{
    'K' => MathFunctions.CelsiusToKelvin(celsius),
    'F' => MathFunctions.CelsiusToFahrenheit(celsius),
    _ => 0,
};

Console.WriteLine($"\nAz átváltott érték {result} {choice}");

Console.ReadKey();







