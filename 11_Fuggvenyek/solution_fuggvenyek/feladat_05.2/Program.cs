using IOLibrary;

const intt BASE_WORKING_HOURS = 40;

string workerName = ExtendedConsole.ReadString("Adja meg a dolgozó nevét:");
double workerWorkingHours = ExtendedConsole.ReadDouble("Adja meg a ledolgozott órák számát:");

double regularPayment = CalculatePayment(BASE_WORKING_HOURS);
double overtimePayment = workerWorkingHours > BASE_WORKING_HOURS ?
                         CalculatePayment(workerWorkingHours - BASE_WORKING_HOURS, 1500) : 
                         0;

double payment = regularPayment + overtimePayment;

Console.WriteLine($"{workerName} heti fizetése {payment} HUF");
Console.ReadKey();

double CalculatePayment(double workingHours, int wage = 1000) => workingHours * wage;