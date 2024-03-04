/*
 A felhasználótól kérjük be a mátrix dimenzióit (sor és
oszlop), majd ezt a mátrixot töltsük fel adatokkal
(random), majd írjuk ki. Keressük ki minden sorban a
legnagyobb számot és ezekből a számokból alkossunk
egy tömböt.
 */

using CustomLibrary.ConsoleExtensions;
using CustomLibrary.MathExtensions;

int x = ExtendedConsole.ReadInteger("Adja meg a oszlopok szamat.");
int y = ExtendedConsole.ReadInteger("Adja meg a sorok szamat.");

int[,] matrix = GetTwoDimensionalArray(x, y);
PrintMatrix(matrix);

int[] maxValues = GetMaxValues(matrix);

Console.WriteLine("A mátrix sorainak legnagyobb elemei:");
for (int i = 0; i < maxValues.Length; i++)
{
    Console.Write($"{maxValues[i]} ");
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
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
int[] GetMaxValues(int[,] matrix)
{
    int[] maxValues = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int max = matrix[i, 0];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max)
            {
                max = matrix[i, j];
            }
        }
        maxValues[i] = max;
    }
    return maxValues;
}