/*
 Keresse ki a mátrix dimenziójú tömb mellékátló alatti elemekből a legnagyobbat.
 */

using CustomLibrary.ConsoleExtensions;
using CustomLibrary.MathExtensions;


int[,] matrix = GetTwoDimensionalArray(5, 5);
PrintMatrix(matrix);
Console.WriteLine();
int max = GetMaxUnderSecondaryDiagonal(matrix);
Console.WriteLine($"A mátrix mellékátló alatti legnagyobb elem: {max}");

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
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

// Keresse ki a mátrix dimenziójú tömb mellékátló alatti elemekből a legnagyobbat.

int GetMaxUnderSecondaryDiagonal(int[,] matrix)
{
    int max = matrix[1, 0];
    for (int i = 2; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            if (matrix[i, j] > max)
            {
                max = matrix[i, j];
            }
        }
    }
    return max;
}