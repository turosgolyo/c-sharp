using CustomLibrary.ConsoleExtensions;
using static System.Reflection.Metadata.BlobBuilder;

List<Student> students = await FileService.ReadFromFileAsync("szeptember.csv");
ExtendedSystem.WriteCollectionToConsole(students);

List<AbsentHoursByYear> absentHoursByYear = new List<AbsentHoursByYear>();

int totalAbsentHours = students.Sum(x => x.AbsentHours);

Console.WriteLine($"Összes mulasztott órák: {totalAbsentHours}");

string studentName = ExtendedConsole.ReadString("Adjon meg egy nevet:");
int studentDay = ExtendedConsole.ReadInteger("Adja meg a napok számát:");

Student student = students.First(x => x.Name == studentName);
string isAbsent = (student.AbsentHours > 0) ? "A tanuló hiányzott szeptemberben" : "A tanuló nem hiányzott szeptemberben";
Console.WriteLine(isAbsent);

List<Student> absentStudents = students.Where(x => x.LastDay >= studentDay && x.FirstDay <= studentDay).ToList();
Console.WriteLine($"Ezek a tanulok hianyoztak {studentDay}-én");
foreach (Student item in absentStudents)
{
    Console.WriteLine($"{item.Name} ({item.Year})");
}
List<AbsentHoursByYear> allAbsentHoursByYear = students.GroupBy(x => x.Year)
                            .Select(x => new AbsentHoursByYear
                            {
                                Year = x.Key,
                                AbsentHours = x.Sum(x => x.AbsentHours)
                            }).ToList();
await FileService.WriteToFileAsync("osszesites.csv", allAbsentHoursByYear);
