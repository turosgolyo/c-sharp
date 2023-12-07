namespace CustomLibrary.MathExtensions;


public static partial class MathFunctions
{
    private static Random rnd = null;

    static MathFunctions()
    { 
        rnd = new Random();
    }

    public static double CelsiusToKelvin(double celsius) => celsius + 273.15;
    public static double CelsiusToFahrenheit(double celsius) => (9 / 5 * celsius) + 32;
    public static double Pythagoras(int x, int y) => Math.Sqrt(x * x + y * y);
    public static int GenerateRandom(int start, int end) => rnd.Next(start, end + 1);
    public static double BmiIndex(double height, double weight) => weight / (height * height);
}





