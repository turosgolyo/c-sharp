﻿/*
 Számítsuk ki egy négyzetes mátrix mellekátlóján levő
elemeinek összegét
 */

using CustomLibrary.ConsoleExtensions;
using CustomLibrary.MathExtensions;


int[,] matrix = GetTwoDimensionalArray(5, 5);
PrintMatrix(matrix);

int sum = GetOtherDiagonalSum(matrix);

Console.WriteLine($"A mátrix masik atlojanak osszege: {sum}");

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
int GetOtherDiagonalSum(int[,] matrix) // GetDiagonalSum -> GetOtherDiagonalSum
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = sum + matrix[i, matrix.GetLength(0) - i - 1];
    }
    return sum;
}