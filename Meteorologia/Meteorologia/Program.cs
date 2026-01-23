using Meteorologia;
using System.Globalization;
using System.Text;

List<string> lines = File.ReadAllLines("tavirathu13.txt", Encoding.UTF7).ToList();
List<Weather> weathers = new List<Weather>();

foreach (string line in lines)
{
    List<string> data = line.Split(' ').ToList();
    weathers.Add(new Weather
    {
        City = data[0],
        Time = DateTime.ParseExact(data[1], "HHmm", CultureInfo.InvariantCulture),
        Wind = data[2],
        Temperature = int.Parse(data[3]),
    });
}

Console.WriteLine("Adjon meg egy varos kodjat: ");
string city = Console.ReadLine().ToUpper();

Weather latestMeasure = weathers.Where(x => x.City == city).OrderByDescending(x => x.Time).FirstOrDefault();
Console.WriteLine(latestMeasure.ToString());

Weather min = weathers.FirstOrDefault(x => x.Temperature == weathers.Min(x => x.Temperature));
Console.WriteLine($"{min.City} {min.Time} {min.Temperature}");
Weather max = weathers.FirstOrDefault(x => x.Temperature == weathers.Max(x => x.Temperature));
Console.WriteLine($"{max.City} {max.Time} {max.Temperature}");

