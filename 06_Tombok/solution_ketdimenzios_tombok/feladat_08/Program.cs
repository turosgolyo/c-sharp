/*
Keresse ki a mátrix (n x n) dimenziójú tömb fő átló feletti elemeket. A kiíratás az alábbi minta szerint történjen:
    [0,1]  [0,2]  [0,3]
           [0,2]  [0,3]
                  [0,3]

*/
using CustomLibrary.ConsoleExtensions;
using CustomLibrary.MathExtensions;


int[,] matrix = GetTwoDimensionalArray(5, 5);
PrintMatrix(matrix);
Console.WriteLine();
PrintMainDiagonalAbove(matrix);

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

void PrintMainDiagonalAbove(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}