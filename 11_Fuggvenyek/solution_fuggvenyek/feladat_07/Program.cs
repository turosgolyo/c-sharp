using IOLibrary;

double squareMeter = ExtendedConsole.ReadDouble("Adja meg a fal területét:");

double paintAmount = GetPaintAmount(squareMeter);
double paintCost = GetPaintCost(paintAmount);

Console.WriteLine($"{squareMeter} négyzetméter lefestéséhez {paintAmount} liter festék kell, ami {paintCost} Ft-ba kerül");

double GetPaintAmount(double squareMeter) => squareMeter * 0.15;
double GetPaintCost(double paintAmount) => Math.Ceiling(paintAmount) * 930;