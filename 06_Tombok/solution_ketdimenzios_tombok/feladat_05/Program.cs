/*
 A felhasználótól kérjük be a mátrix dimenzióit (sor és
oszlop), majd ezt a mátrixot töltsük fel adatokkal
(random), majd írjuk ki. Adjuk össze az egyes sorok
elemeit majd a sorok összegéből alkossunk egy új
tömböt.
 */

using CustomLibrary.ConsoleExtensions;
using CustomLibrary.MathExtensions;

int x = ExtendedConsole.ReadInteger("Adja meg a oszlopok szamat.");
int y = ExtendedConsole.ReadInteger("Adja meg a sorok szamat.");

int[,] matrix = GetTwoDimensionalArray(x, y);
PrintMatrix(matrix);

int[] sum = GetValueSum(matrix);

Console.WriteLine("A mátrix sorainak elemeinek osszege:");
for (int i = 0; i < sum.Length; i++)
{
    Console.Write($"{sum[i]} ");
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
int[] GetValueSum(int[,] matrix)
{
    int[] valueSum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        valueSum[i] = sum;
    }
    return valueSum;
}