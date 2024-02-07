using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

List<Motorcycle> LoadData()
{
    FileStream fs = new FileStream("./../../../data.json", FileMode.Open, FileAccess.Read, FileShare.None);
    StreamReader sr = new StreamReader(fs, Encoding.UTF8);
    
    string jsonData = sr.ReadToEnd();
    return JsonSerializer.Deserialize<List<Motorcycle>>(jsonData);
    
}

void WriteToConsole(string text, ICollection<Motorcycle> motorcycles)
{
    Console.WriteLine(text);
    Console.WriteLine(string.Join('\n', motorcycles));
}

void WriteSingleToConsole(string text, Motorcycle motorcycle)
{
    Console.WriteLine(text);
    Console.WriteLine(motorcycle);
}


List<Motorcycle> motorcycles = LoadData();
WriteToConsole("Data", motorcycles);

// 1 - Hány motorkerékpár van az 'adatbázisban' ?
int motorcycleCount = motorcycles.Count;

// 2 - Hány 'Honda' gyártmányú motorkerékpár van az 'adatbázisban' ?
int hondaMotorcycleCount = motorcycles.Count(x => x.Brand == "Honda");


// 3 - Mekkora a legnyaobb köbcenti az 'adatbázisban' ?
int mostCubicCentimeters = motorcycles.Max(x => x.Cubic);


// 4 - Melyik a legkisebb végsebesség az 'adatbázisban' ?
int slowestSpeed = motorcycles.Min(x => x.TopSpeed);

// 5 - Van e olyan motorkerékpár az 'adatbázisban' amelyet 1960 előtt gyártottak?
bool anyMotorcyclesMadeBefore1960 = motorcycles.Any(x => x.ReleaseYear < 1960);

// 6 - Van-e 'Honda' gyártmányú motorkerképár az 'adatbázisban' melynek beceneve 'Hornet' ?
bool anyHornetMotorcycles = motorcycles.Any(x => x.Model == "Hornet");

// 7 - Keressük ki a 'Yamaha' gyártmányú motorkerékpárokat!
List < Motorcycle > yamahaMotorcycles = motorcycles.Where(x => x.Brand == "Yamaha").ToList();

// 8 -Keressük a 'Suzuki' gyártotmányú motorkerékpárokat melyek 600ccm felett vannak!
List<Motorcycle> suzukiMotorcyclesAbove600ccm = motorcycles.Where(x => x.Brand == "Suzuki")
                                                           .Where(x => x.Cubic >= 600)
                                                           .ToList();

// 9 - Keressük ki a 'Kawasaki' gyártotmányú motorkerékpárokat, melyek sebesságe nagyobb min 150km/h!
List<Motorcycle> kawasakiMotorcyclesTopSpeedAtLeast150kmh = motorcycles.Where(x => x.Brand == "Kawasaki")
                                                                       .Where(x => x.TopSpeed == 150)
                                                                       .ToList();

// 10 - Keressük ki a 'BMW' gyártotmányú motorkerékpárokat, melyeket 2010 előtt gyárottak és a motor köbcentije minimum 1000!
List<Motorcycle> bmwMotorcyclesMadeBefore2010WithCubic1000 = motorcycles.Where(x => x.Brand == "BMW")
                                                                        .Where(x => x.ReleaseYear <= 2010)
                                                                        .Where(x => x.Cubic >= 1000)
                                                                        .ToList();


// 12 - Keressül a motorkerékpárok beceneveit (nickname)!
List<string> motorcycleNicknames = motorcycles.Select(x => x.Nickname).ToList();


// 13 - Keressük azokat a motorkerékpárokat, melyek neveiben szerepel 'FZ' kifejezés!
List<Motorcycle> motorcyclesWithFZInTheName = motorcycles.Where(x => x.Model.Contains("FZ")).ToList();

// 14 - Keressük azokat a motorkerékpárokat, melyek nevei 'C' betűvel kezdődnek!
List<Motorcycle> motorcyclesStartsWithC = motorcycles.Where(x => x.Model.StartsWith("C")).ToList();

// 15 - Keressük az első motorkerékpárt az 'adatbázisunkból'!
Motorcycle firstMotorcycle = motorcycles.First();

// 16 - Keressük az utolsó motorkerékpárt az 'adatbázisunkból'!
Motorcycle lastMotorcycle = motorcycles.Last();

// 17 - Rendezzük növekvő sorrendbe gyártási év alapján az 'adatbázisban' szereplő motorkerékpárokat.
List<Motorcycle> motorcyclesOrderedByYear = motorcycles.OrderBy(x => x.ReleaseYear)
                                                       .ToList();

// 18 - Rendezzük csökkenő sorrendbe a 'Honda' által gyártott motorkerékpárokat, melyek teljesítménye legalább 25kW és 2005 után gyártották őket.
List<Motorcycle> hondaMotorcycleAtLeast25kWMadeAfter2005= motorcycles.Where(x => x.Brand == "Honda")
                                                                     .Where(x => x.ReleaseYear >= 2005)
                                                                     .Where(x => x.KW == 25)
                                                                     .OrderByDescending(x => x.Model)
                                                                     .ToList();


// 19 - Melyek azok a  motorkerékpárok, melyek nem rendelkeznek becenévvel?


// 20 - Mekkora az 'adatbázisban' szereplő motorkerékpárok sebességének az átlaga?
double averageTopSpeed = motorcycles.Average(x => x.TopSpeed);

// 21 - Melyik a legyorsabb motorkerékpár? Feltételezzük, hogy csak egy ilyen van!
int maxSpeed = motorcycles.Max(x => x.TopSpeed);
Motorcycle fastestMotorcycle = motorcycles.First(x => x.TopSpeed == maxSpeed);

// 22 - Hány kategória található meg az 'adatbázisban'?
List<Motorcycle> categoryCount = motorcycles
                                        .Distinct(x => x.Category).ToList();


// 23 - Határozza meg az 'adatbázisban' talalható motorkerékpárok átlag életkorát!
double averageAge = motorcycles.Average(x => (2024-x.ReleaseYear));

// 24 - Van-e 'Java' gyártmányú motorkerékpár az 'adatbázisban'?
bool javaMotorcycle = motorcycles.Any(x => x.Brand == "Java");

// 25 - Rendezzül növekvő sorrende az 5 betűvel rendelkező gyártók motorkerékpárjait,
//         majd csökkenő sorrendbe gyártási év alapján és az eredményben csak a nevet és
//         a gyártási évet jelenítse meg!
List<Motorcycle> sortedMotorcycles = motorcycles.Where(x => x.Model.Length == 5).SelectMany(x => x.Model, x => x.ReleaseYear);

Console.ReadLine();
