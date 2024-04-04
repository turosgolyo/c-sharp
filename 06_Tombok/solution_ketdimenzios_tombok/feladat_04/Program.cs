/*
Keresse ki a mátrix (n x n) dimenziójú tömb fő átló alatti elemeket. A kiíratás az alábbi minta szerint történjen:
[1,0]
[2,0]  [2,1]
[3,1] [3,2] [3,3]

 */


using CustomLibrary.ConsoleExtensions;
using CustomLibrary.MathExtensions;
using System.Numerics;



int[,] matrix = GetTwoDimensionalArray(5, 5);
PrintMatrix(matrix);
Console.WriteLine();
PrintMainDiagonalUnder(matrix);

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

void PrintMainDiagonalUnder(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}