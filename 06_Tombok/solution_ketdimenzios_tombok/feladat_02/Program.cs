using CustomLibrary.ConsoleExtensions;
using CustomLibrary.MathExtensions;

int x = ExtendedConsole.ReadInteger("Adja meg a oszlopok szamat.");
int y = ExtendedConsole.ReadInteger("Adja meg a sorok szamat.");

int[,] matrix = GetTwoDimensionalArray(x, y);
PrintMatrix(matrix);

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