/*
 Keresse ki a mátrix (n x n) dimenziójú tömb mellékátlóinak elemét egy többmbe.
 */

using CustomLibrary.ConsoleExtensions;
using CustomLibrary.MathExtensions;


int[,] matrix = GetTwoDimensionalArray(5, 5);
PrintMatrix(matrix);

int[] secondaryDiagonal = new int[matrix.GetLength(0)];
secondaryDiagonal = GetSecondaryDiagonal(matrix);
Console.WriteLine("Secondary diagonal: ");
foreach (int number in secondaryDiagonal)
{
    Console.Write($"{number} ");
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

int[] GetSecondaryDiagonal(int[,] matrix)
{
    int[] secondaryDiagonal = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        secondaryDiagonal[i] = matrix[i, matrix.GetLength(0) - i - 1];
    }
    return secondaryDiagonal;
}

