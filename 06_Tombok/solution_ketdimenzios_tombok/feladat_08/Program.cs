/*
 Keressük ki egy négyzetes mátrix főátlója alatti
elemeinek a minimumát
*/

using CustomLibrary.ConsoleExtensions;
using CustomLibrary.MathExtensions;


int[,] matrix = GetTwoDimensionalArray(5, 5);
PrintMatrix(matrix);

int min = GetDiagonalUnderMinimum(matrix);

Console.WriteLine($"A mátrix atlo alatti minimuma: {min}");

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
int GetDiagonalUnderMinimum(int[,] matrix)
{
    int min = matrix[1, 0];
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
            }
        }
    }
    return min;
}