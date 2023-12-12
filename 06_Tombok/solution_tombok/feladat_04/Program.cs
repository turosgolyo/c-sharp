using CustomLibrary.ConsoleExtensions;
using System.Xml.Serialization;

const int NUMBER_OF_WORKERS = 5;

Worker[] workers = GetWorkers();

Console.WriteLine("Dolgozók:");
PrintWorkersOnConsole(workers);

Console.WriteLine("Hozzajárulások:");
PrintToConsoleContribution(workers);


Console.ReadKey();

Worker[] GetWorkers()
{
    Worker[] workers = new Worker[NUMBER_OF_WORKERS];
    Worker worker = null;

    for(int i = 0; i < NUMBER_OF_WORKERS; i++)
    {
        string name = ExtendedConsole.ReadString("Adja meg a dolgozó nevét!");

        workers[i] = new Worker(name);
    }

    return workers;
}

void PrintWorkersOnConsole(Worker[] workers)
{
    Console.WriteLine("\t JAN\t FEB\t MAR\t APR\t MAJ\t JUN\t JUL\t AUG\t SZE\t OKT\t NOV\t DEC");
    foreach (Worker worker in workers)
    {
        Console.WriteLine(worker);
    }
}
void PrintToConsoleContribution(Worker[] workers)
{
    Console.WriteLine($"\t\tSZJA\t\tTB\t\tNYHJ");
    foreach (Worker worker in workers)
    {
        Console.WriteLine ($"{worker.Name.PadLeft(8)}\t{worker.SZJA:F2}\t{worker.TB:F2}\t{worker.NYHJ:F2}");
    }
}