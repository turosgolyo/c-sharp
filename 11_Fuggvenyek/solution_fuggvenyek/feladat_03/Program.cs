using System.Drawing;
using IOLibrary;
using CustomLibrary;

Point a = GetPoint();

Point b = GetPoint();

double distance = GetPointDistance(a, b);

Console.WriteLine($"A két pont között kalkulált távolság: {distance}");


Point GetPoint() => new Point
{
    X = ExtendedConsole.ReadInteger("Adja meg az X értékét!"),
    Y = ExtendedConsole.ReadInteger("Adja meg az Y értékét!")
};

double GetPointDistance(Point a, Point b)
{
    int y = Math.Abs(a.Y - b.Y);
    int x = Math.Abs(a.X - b.Y);

    double d = MathFunctions.Pythagoras(x, y);

    return d;
}
