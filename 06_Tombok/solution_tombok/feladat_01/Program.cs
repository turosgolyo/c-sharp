Random rnd = new Random();

int[] array = await GetIntArrayAsync(10);

Console.WriteLine("Generated array: ");
PrintArrayToConsole(array);

int sum = GetArraySum(array);
Console.WriteLine($"\nSum of the array: {sum}");

double average = (double)sum / array.Length;
Console.WriteLine($"\nAverage of the array: {average:F2}");

int[] evenNumbersArray = GetEvenNumbersFromArray(array);
Console.WriteLine("\nEven elements of the array: ");
PrintArrayToConsole(evenNumbersArray);

int numberOfTwoDigitNumbers = GetTwoDigitNumbers(array);
Console.WriteLine($"\nNumber of two digit numbers: {numberOfTwoDigitNumbers}");

Console.WriteLine($"\nSingle digit elements of the array: ");
int[] singleElementsOfTheArray = array.Where(x => x < 10).ToArray();
PrintArrayToConsole(singleElementsOfTheArray);

int sumOfOddNumbers = CalculateOddNumbersSumOfArray(array);
Console.WriteLine($"\nThe sum of odd numbers of the array: {sumOfOddNumbers}");

int zeroEndingNumbersCount = array.Count(x => x % 10 == 0);
Console.WriteLine($"\nThe number of numbers ending with zero in the array: {zeroEndingNumbersCount}");

Console.WriteLine("\nArray in ascending order: ");
OrderArrayAscending(array);
ReversePrintArrayToConsole(array);


Console.ReadKey();

/*
async - aszinkron fuggveny (a fuggveny lefutasas bevarhato, mivel nem fejezodik be rogton)
Tasnk<int> - az aszinkron fuggveny eredmenye egy feladat (Task) amelynek az eredmenye egy int tipusu tomb lesz amikor befejezodik
*/

async Task<int[]> GetIntArrayAsync(int arraySize)
{
    int[] array = new int[arraySize];

    for (int i = 0; i < arraySize; i++)
    {
        array[i] = rnd.Next(0, 100);
        await Task.Delay(100);
    }

    return array;
}
void PrintArrayToConsole(int[] arrayToPrint)
{
    for(int i = arrayToPrint.Length - 1; i >= 0; i--)
    {
        Console.WriteLine($"[{i+1}] = {arrayToPrint[i]}");
    }
}
void ReversePrintArrayToConsole(int[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.WriteLine($"[{i + 1}] = {arrayToPrint[i]}");
    }
}
int GetArraySum(int[] array)
{
    int sum = 0;

    foreach(int item in array)
    {
        sum += item;
    }

    return sum;
}
int[] GetEvenNumbersFromArray(int[] array)
{
    int[] evenNumbers = array.Where(x => x % 2 == 0)
                             .ToArray();

    return evenNumbers;
}
int GetTwoDigitNumbers(int[] array)
{
    int counter = 0;

    foreach(int number in array)
    {
        if(number > 9)
        {
            counter++;
        }
    }

    return counter;
}
int CalculateOddNumbersSumOfArray(int[] array)
{
    int sum = 0;
    
    foreach(int number in array)
    {
        if(number % 2 == 1)
        {
            sum += number;
        }
    }
    
    return sum;
}
void OrderArrayAscending(int[] array)
{
    int temp = 0;

    for(int i = 0; i < array.Length; i++)
    {
        for(int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[i])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}