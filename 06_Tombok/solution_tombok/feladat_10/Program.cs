using CustomLibrary.ConsoleExtensions;

const int NUMBER_OF_STUNDENTS = 3;

Student[] students = GetStudents();

PrintStudentsToConsole(students);

int savingSum = GetSavingSum(students);
Console.WriteLine($"\nMegtakarítások: {savingSum}");


Student[] GetStudents()
{
    Student[] students = new Student[NUMBER_OF_STUNDENTS];
    for (int i = 0; i < NUMBER_OF_STUNDENTS; i++)
    {
        string name = ExtendedConsole.ReadString("Tanuló neve:");
        int saving = ExtendedConsole.ReadInteger("Megtakarítás:");

        students[i] = new Student(name, saving);
    }
    return students;
}
int GetSavingSum(Student[] students) => students.Sum(x => x.Saving);
double GetSavingAverage(Student[] students) => students.Average(x => x.Saving);
void PrintStudentsToConsole(Student[] students)
{
    foreach(Student student in students)
    {
        Console.WriteLine(student);
    }
}