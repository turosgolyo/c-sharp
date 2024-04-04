/*
 Indiában monszun időszak kezdődik. A mezőgazdasági
minisztérium kutatást végzett, a leesett eső mennyiségéről,
ezért mérőhengereket helyeztek el, amit minden nap reggel 6,
délután 14 és este 22 órakor ellenőriztek és az esett
mennyiséget feljegyezték egy táblázatba (a leolvasott értékek 0
– 5 l/𝑚2 közt mozogtak, és nem voltak egész értékek). Majd a
következő adatokra voltak kíváncsiak:
• A leesett napi átlag csapadékot növekvő sorrendje
• Melyik nap esett a legkevesebb és legtöbb csapadék
• Melyik nap reggelére esett a legtöbb csapadék
• Melyik nap esett a legtöbb csapadék reggel 6 és este 22 óra
közt
 */

using CustomLibrary.ConsoleExtensions;
using CustomLibrary.MathExtensions;


double[,] matrix = GetTwoDimensionalArray(7, 3);
PrintMatrix(matrix);

double[] averages = GetSortedDailyAverages(matrix);
Console.WriteLine("\n\nA leesett napi átlag csapadék növekvő sorrendje:");
for (int i = 0; i < averages.Length; i++)
{
    Console.Write($"{averages[i]} ");
}

double[] dailySums = GetDailySums(matrix);

int minIndex = Array.IndexOf(dailySums, dailySums.Min());
string minDay = GetDayByIndex(minIndex);
Console.WriteLine($"\n\nEzen a napon esett a legkevesebbet: {minDay}");

int maxIndex = Array.IndexOf(dailySums, dailySums.Max());
string maxDay = GetDayByIndex(maxIndex);
Console.WriteLine($"\n\nEzen a napon esett a legtöbbet: {maxDay}");

double[] morningSums = GetMorningSums(matrix);
int morningMaxIndex = Array.IndexOf(morningSums, morningSums.Max());
string morningMaxDay = GetDayByIndex(morningMaxIndex);
Console.WriteLine($"\n\nEzen a napon reggelére esett a legtöbb csapadék: {morningMaxDay}");

double[,] GetTwoDimensionalArray(int x, int y)
{
    double[,] matrix = new double[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = Math.Round(MathFunctions.GenerateRandomDouble(0, 5), 2);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{i+1}. {matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
double[] GetSortedDailyAverages(double[,] matrix)
{
    double[] averages = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        averages[i] = Math.Round(sum / matrix.GetLength(1), 2);
    }
    Array.Sort(averages);
    return averages;
}

double[] GetDailySums(double[,] matrix)
{
    double[] sums = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        sums[i] = sum;
    }
    return sums;
}

string GetDayByIndex(int index)
{
    string day = index switch
    {
        0 => "Hétfő",
        1 => "Kedd",
        2 => "Szerda",
        3 => "Csütörtök",
        4 => "Péntek",
        5 => "Szombat",
        6 => "Vasárnap",
        _ => "Nem létező nap"
    };
    return day;
}

double[] GetMorningSums(double[,]matrix)
{
    double[] sums = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = matrix[i, 0];
        sums[i] = sum;
    }
    return sums;
}