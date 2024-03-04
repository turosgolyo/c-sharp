/*
 Számítsuk ki egy négyzetes mátrix mellék átlója
feletti elemeinek a maximumát
 */


using CustomLibrary.ConsoleExtensions;
using CustomLibrary.MathExtensions;
using System.Numerics;


int[,] matrix = GetTwoDimensionalArray(5, 5);
PrintMatrix(matrix);

int max = GetOtherDiagonalAboveMaximum(matrix);

Console.WriteLine($"A mátrix masik atlo feletti maximuma: {max}");

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
int GetOtherDiagonalAboveMaximum(int[,] matrix)
{
    int max = matrix[0, matrix.GetLength(0) - 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
        {
            if (matrix[i, j] > max)
            {
                max = matrix[i, j];
            }
        }
    }
    return max;
}