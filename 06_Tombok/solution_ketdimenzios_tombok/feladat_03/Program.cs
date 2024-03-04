/*
 A felhasználótól kérjük be a mátrix dimenzióit (sor
és oszlop), majd ezt a mátrixot töltsük fel
adatokkal (random), írjuk ki és keressük meg a min
és max értékeket.
*/

using CustomLibrary.ConsoleExtensions;
using CustomLibrary.MathExtensions;

int x = ExtendedConsole.ReadInteger("Adja meg a oszlopok szamat.");
int y = ExtendedConsole.ReadInteger("Adja meg a sorok szamat.");

int[,] matrix = GetTwoDimensionalArray(x, y);
PrintMatrix(matrix);

int minValue = GetMinValue(matrix);
int maxValue = GetMaxValue(matrix);

Console.WriteLine($"A mátrix legkisebb eleme: {minValue}");
Console.WriteLine($"A mátrix legnagyobb eleme: {maxValue}");

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

int GetMinValue(int[,] matrix)
{
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
            }
        }
    }
    return min;
}

int GetMaxValue(int[,] matrix)
{
    int max = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max)
            {
                max = matrix[i, j];
            }
        }
    }
    return max;
}