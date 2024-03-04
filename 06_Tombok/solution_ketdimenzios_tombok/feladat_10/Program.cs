/*
 A felhasználótól kérjük be a mátrix dimenzióit (sor
és oszlop), majd ezt a mátrixot töltsük fel
adatokkal (random), majd írjuk ki. Rakjuk sorba a
mátrix elemeit növekvő sorrendbe.
 */
using CustomLibrary.ConsoleExtensions;
using CustomLibrary.MathExtensions;

int x = ExtendedConsole.ReadInteger("Adja meg a oszlopok szamat.");
int y = ExtendedConsole.ReadInteger("Adja meg a sorok szamat.");

int[,] matrix = GetTwoDimensionalArray(x, y);
int[] sortedArray = GetSortedArray(matrix);
foreach(int number in sortedArray)
{
    Console.Write($"{number} ");
}

int[,] GetTwoDimensionalArray(int x, int y)
{
    int[,] matrix = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = MathFunctions.GenerateRandom(1, 100);
        }
    }
    return matrix;
}
int[] GetSortedArray(int[,] matrix)
{
    int[] sortedArray = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sortedArray[k] = matrix[i, j];
            k++;
        }
    }
    Array.Sort(sortedArray);
    return sortedArray;
}