using System.Security.Cryptography.X509Certificates;

List<Student> students = new List<Student>
{
    new Student("Hétfő Henrik", 10, 154),
    new Student("Kedd Kinga", 14, 250),
    new Student("Szerda Szilárd", 9, 98),
    new Student("Csütörtök Csongor", 11, 198),
    new Student("Péntek Petra", 13, 245),
    new Student("Szombat Szimonetta", 10, 152),
    new Student("Vasárnap Virág", 13, 221)
};

// legnagyobb pontszam
int maxPoints = students.Max(x => x.Points);

// legjobban teljesito diak
Student bestStudent = students.MaxBy(x => x.Points);

// legkisebb pontszam
int minPoints = students.Min(x => x.Points);

// legrosszabban teljesito diak
Student worstStudent = students.MinBy(x => x.Points);

// diakok nevei?😎🤔
List<string> studentNames = students.Select(x => x.Name)
                                    .ToList();
// 200 feletti diakok nevei
List<string> studendtsNameAtLeast200Points = students.Where(x => x.Points > 200)
                                                     .Select(x => x.Name)
                                                     .ToList();

// diaki??? nevek abc sorrendbe
List<string> orderedStudentNames = students.OrderBy(x => x.Name)
                                           .Select(x => x.Name)
                                           .ToList();

// majd pontok alapjan csokkeno sorrendbe
List<string> orderedStudentNamesWithPoints = students.OrderBy(x => x.Name)
                                                     .ThenByDescending(x => x.Points)  
                                                     .Select(x => x.Name)
                                                     .ToList();

// osztalyok alapjan csokkeno soorendbe
// pontok alapjan csokkeno sorrendbe a diakok neveit
List<string> orderedStudentsByGradeAndPoints = students.OrderByDescending(x => x.Grade)
                                                       .ThenByDescending(x => x.Points)
                                                       .Select(x => x.Name)
                                                       .ToList();

//evfolyamonkent elert pontszamok, evfolyam szerint csokkeno sorrendben🤗🤗🤗🤗🤗
List<GradeWithPoints> gradeWithPoints = students.GroupBy(x => x.Grade)
                                                .Select(x => new GradeWithPoints
                                                {
                                                    Grade = x.Key,
                                                    Points = x.Sum(x => x.Points)
                                                })
                                                .OrderByDescending(x => x.Grade)
                                                .ToList();

//milyen pontszamokat kaptak egyes evfolyamok
//milyen pontszam csak egyszer fordulhat elo az eredmenyben
List<int> distinctedPoints = students.Select(x => x.Points)
                                     .Distinct()
                                     .ToList();

distinctedPoints = students.DistinctBy(x => x.Points)
                           .Select(x => x.Points)
                           .ToList();