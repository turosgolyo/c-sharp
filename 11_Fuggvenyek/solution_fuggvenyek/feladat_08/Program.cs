using IOLibrary;

double length = ExtendedConsole.ReadDouble("Adja meg a telek hosszát:");
double width = ExtendedConsole.ReadDouble("Adja meg a telek szélességét:");

double tax = GetTaxValue(length, width);

Console.WriteLine($"Az adó mennyisége {tax} HUF");

double GetTaxValue(double length, double width)
{
    double squareMeters = length * width;
    double tax = squareMeters * 1000;

    if(length < 30 && width < 20)
    {
        tax *= 0.75;
    }
    return tax;
}

