List<Student> students = await FileService.ReadFromFileV2Async("adatok.txt");

Console.ReadKey();

students.WriteCollectionToConsole();

Console.WriteLine($"az osztalyban {students.Count} diák jár");


double average = students.Average(x => x.Average);
Console.WriteLine($"az osztaly átlaga {average:F2}");

Student bestStudent = students.MaxBy(x => x.Average);
Console.WriteLine($"A legjobb tanuló {bestStudent}");
Console.WriteLine();

List<Student> studentsAboveAverage = students.Where(x => x.Average > average)
											 .ToList();

await FileService.WriteToFileV1Async("atlagfelett", studentsAboveAverage);

bool hasExcellentStudent = students.Any(x => x.Average == 5);
Console.WriteLine($"{(hasExcellentStudent ? "Van" : "Nincs")}");

Dictionary<Grade, int> gradesCount1 = new Dictionary<Grade, int>()
{
	[Grade.Elegtelen] = students.Count(x => x.Grade == Grade.Elegtelen),
    [Grade.Elegseges] = students.Count(x => x.Grade == Grade.Elegseges),
    [Grade.Jo] = students.Count(x => x.Grade == Grade.Jo),
    [Grade.Jeles] = students.Count(x => x.Grade == Grade.Jeles),
    [Grade.Kituno] = students.Count(x => x.Grade == Grade.Kituno)
};

Dictionary<Grade, int> gradesCount2 = new Dictionary<Grade, int>();

foreach(Grade grade in Enum.GetValues<Grade>())
{
	gradesCount2[grade] = students.Count(x => x.Grade == grade);
}

foreach(KeyValuePair<Grade, int> grade in gradesCount2)
{
    Console.WriteLine($"{grade.Key} : {grade.Value} db");
}


/*
Feladatunk, hogy
1 - Írjuk ki minden diák adatát a képernyőre!
2 - Hány diák jár az osztályba?
3 - Mennyi az osztály átlaga?
4 - Keressük a legtöbb pontot elért érettségizőt és írjuk ki az adatait a képernyőre.
5 - atlagfelett.txt allományba keressük ki azon tanulókat kiknek pontjai meghaladják az átlagot!
6 - Van e kitünő tanulónk?
7 - Hány elégtelen, elégséges, jó, jeles és kitünő tanuló van az osztályban?
    Értékhatárok:
	- elégtelen, ha: 0.00 - 1.99
	- elégséges, ha: 2.00 - 2.99
	- jó, ha: 3.00 - 3.99
	- jeles, ha: 4.00 - 4.99
	- kitünő, ha: 5.00
*/