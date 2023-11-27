using CustomLibrary;
using IOLibrary;

string name = ExtendedConsole.ReadString("Adja meg a nevét!");

int workHour = ExtendedConsole.ReadInteger("Adja meg a ledolgozott órák számát!");

int salary = CalculateSalary(workHour);

Console.WriteLine($"{name} Ön {workHour} órát dolgozott, fizetése: {salary} HUF.");


int CalculateSalary(int workHour) {
    int salary = 0;
    int overtime= 0;
    
    if(workHour > 40)
    {
        overtime = workHour - 40;
    }
    
    salary = (workHour - overtime) * 1000 + (overtime * 1500); 
    
    return salary;
};