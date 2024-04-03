/*
Keresse ki a mátrix (n x n) dimenziójú tömb mellékátló feletti elemekből a legkisebet.
 */
using CustomLibrary.ConsoleExtensions;
using CustomLibrary.MathExtensions;

int[,] matrix = GetTwoDimensionalArray(5, 5);
PrintMatrix(matrix);
Console.WriteLine();
int min = GetMinAboveSecondaryDiagonal(matrix);
Console.WriteLine($"A mátrix mellékátló feletti legkisebb elem: {min}");

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
int GetMinAboveSecondaryDiagonal(int[,] matrix)
{
    int min = matrix[0, 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
            }
        }
    }
    return min;
}