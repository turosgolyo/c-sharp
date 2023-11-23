using IOLibrary;

const double USD = 0.8;
const double JPY = 0.75;
const double CHF = 0.55;

int huf = ExtendedConsole.ReadInteger("Mennyi pénzt szeretne átváltani (Forintban)?", int.MaxValue, 0);
double eur = (double)huf / 400;
Currency currency = GetCurrency();

double convertedValue = currency.switch
{
    Currency.USD => eur / USD,
    Currency.CHF => eur / CHF,
    Currency.JPY => eur / JPY,
};

Console.WriteLine($"{huf} HUF = {eur} EUR");
Console.WriteLine($"{huf} HUF = {convertedValue} {currency}");

Currency GetCurrency()
{
    bool isCurrency = false;
    Currency currency;

    do
    {
        string input = ExtendedConsole.ReadString("Kérem adja meg a cél valutát (USD, JPY, CHF)!");
        isCurrency = Enum.TryParse<Currency>(input, true, out currency);
    }
    while (!isCurrency);

    return currency;
}
