namespace CustomLibrary;

public static partial class MathFunctions
{
    public static double CelsiusToKelvin(double celsius) => celsius + 273.15;
    public static double CelsiusToFahrenheit(double celsius) => (9 / 5 * celsius) + 32;
    public static double Pythagoras(int x, int y) => Math.Sqrt(x * x + y * y);
}





