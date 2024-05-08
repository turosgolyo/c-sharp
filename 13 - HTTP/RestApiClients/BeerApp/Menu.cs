namespace BeerApp;

public static class Menu
{
    public static async void Main()
    {
        int id = ExtendedConsole.ReadInteger("Adj meg a diak azonositojjat");

        Beer beer = await BeerService.GetByIdAsync(id);

        beer.WriteToConsole();
    }
}
