using IOLibrary;

double points = ExtendedConsole.ReadDouble("Adja meg a dolgozat pontszámát!");
int grade = GetGrade(points);

Console.WriteLine($"Ön {points} pontot szerzett, így az osztályzat : {grade}");

int GetGrade(double points)
{
    int grade = 0;
    switch(points)
    {
        case < 50:
            grade = 1;
            break;
        case < 60:
            grade = 2;
            break;
        case < 70:
            grade = 3;
            break;
        case < 85:
            grade = 4;
            break;
        case >= 85:
            grade = 5;
            break;
    }
    return grade;
}
