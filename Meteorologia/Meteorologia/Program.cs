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

List<Weather> noWind = weathers.Where(x => x.Wind == "00000").ToList();
if (noWind is null)
{
    Console.WriteLine("Nem volt szélcsend a mérések idején.");
} else
{
    foreach (Weather weather in noWind){    
        Console.WriteLine($"{weather.City} {weather.Time.ToString("HH:mm")}");
    }
}

List<WeatherByGroup> weathersByGroup;
var groups = weathers.GroupBy(x => x.City);

foreach (var group in groups)
{
    List<int> temps = group.Where(x => x.Time.Hour == 1 || x.Time.Hour == 7 || x.Time.Hour == 13 || x.Time.Hour == 19).Select(x => x.Temperature).ToList();
    int tempChange = group.Max(x => x.Temperature) - group.Min(x => x.Temperature);
    Console.WriteLine($"{group.Key} {(temps.Count() != 4 ? $"Középhőmérséklet: {temps.Average()}" : "NA")}; Hőmérséklet ingadozás: {tempChange}");
}

