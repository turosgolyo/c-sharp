using System.Globalization;

int number = 0;
bool isNumber = false;

do
{
    Console.Write("Adjon meg egy számot 0-9 között: ");
    string input = Console.ReadLine();
       
    /*
        - az input valtozo ertekeit (string) megprobalja a TryParse számmá alakitani. Ha sikerul az isNumber erteke true lesz es a number valtozoban eltarolodik a beirt szam (string) szam ertekkent.
        - ha nem sikerult az isNumber erteke false lesz es a number valtozi erteke nem valtozik, megmarad a deklaralaskor adott ertekeben (0).
        - new CultureInfo("en-US") jelentese az, hogy amerikai angol kornyezetben szeretnenk hasznalni az atalakitast, azaz, ha tizedes szamot (double, float) szeretnenk atalakitani (majd), akkor a tizedes jeleket megadott pontot a vesszo helyett is tudja majd kezelni (angol nylevi kornyezetben a tizedes jele a pont, magyar nyelvi kornyezetben a tizedes jele vesszo, mivel a Windows magyar nyelvu ezert elvarna tolunk, hogy a tizedes szamot vesszovel irjuk be. Ezt a tulajdonsagot orvosolja a newCultureInfo)
    */

    isNumber = int.TryParse(input, new CultureInfo("en-US"), out number);
    if (!isNumber)
    {
        Console.WriteLine("Nem számot adott meg.");
    }
    else if(number < 0 || number > 9)
    {
        Console.WriteLine("A megadott ertek nincs a tartomanyban.");
    }
}
while(!isNumber || number < 0 || number > 9);

Console.WriteLine($"A beolvasott szám {number}");

Console.ReadKey();