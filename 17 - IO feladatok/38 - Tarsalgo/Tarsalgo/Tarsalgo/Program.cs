using Tarsalgo;

List<DoorEvent> events = new List<DoorEvent>();

foreach (string line in File.ReadAllLines("ajto.txt"))
{
    string[] parts = line.Split();
    events.Add(new DoorEvent
    {
        Time = new TimeSpan(
            int.Parse(parts[0]),
            int.Parse(parts[1]),
            int.Parse(parts[2])),
        PersonId = int.Parse(parts[2]),
        IsEntry = parts[3] == "be"
    });
}

int firstEntryId = events.First(e => e.IsEntry).PersonId;
int lastExitId = events.Last(e => !e.IsEntry).PersonId;

Console.WriteLine($"First person to enter: {firstEntryId}");
Console.WriteLine($"Last person to leave: {lastExitId}");

Dictionary<int, int> crossings = new Dictionary<int, int>();

foreach (var e in events)
{
    if (!crossings.ContainsKey(e.PersonId))
    {
        crossings[e.PersonId] = 0;
    }
    crossings[e.PersonId]++;
}

using (StreamWriter writer = new StreamWriter("athaladas.txt"))
{
    foreach (var pair in crossings.OrderBy(p => p.Key))
    {
        writer.WriteLine($"{pair.Key} {pair.Value}");
    }
}

HashSet<int> inside = new HashSet<int>();

foreach (var e in events)
{
    if (e.IsEntry)
    {
        inside.Add(e.PersonId);
    }
    else
    {
        inside.Remove(e.PersonId);
    }
}

Console.WriteLine("People inside at the end:");
Console.WriteLine(string.Join(" ", inside.OrderBy(x => x)));

int currentCount = 0;
int maxCount = 0;
TimeSpan maxTime = TimeSpan.Zero;

foreach (var e in events)
{
    currentCount += e.IsEntry ? 1 : -1;

    if (currentCount > maxCount)
    {
        maxCount = currentCount;
        maxTime = e.Time;
    }
}

Console.WriteLine($"At {maxTime.Hours}:{maxTime.Minutes} there were {maxCount} people inside.");
Console.WriteLine("Enter a person number: ");
int selectedId = int.Parse(Console.ReadLine());


TimeSpan? entryTime = null;
List<(TimeSpan start, TimeSpan? end)> intervals = new List<(TimeSpan, TimeSpan?)>();

foreach (var e in events.Where(e => e.PersonId == selectedId))
{
    if (e.IsEntry)
    {
        entryTime = e.Time;
    }
    else if (entryTime != null)
    {
        intervals.Add((entryTime.Value, e.Time));
        entryTime = null;
    }
}

if (entryTime != null)
{
    intervals.Add((entryTime.Value, null));
}

foreach (var interval in intervals)
{
    if (interval.end.HasValue)
    {
        Console.WriteLine($"{interval.start.Hours}:{interval.start.Minutes}-" + $"{interval.end.Value.Hours}:{interval.end.Value.Minutes}");
    }
    else
    {
        Console.WriteLine($"{interval.start.Hours}:{interval.start.Minutes}-");
    }
}

int totalMinutes = 0;

foreach (var interval in intervals)
{
    TimeSpan end = interval.end ?? new TimeSpan(15, 0, 0);

    totalMinutes += (int)(end - interval.start).TotalMinutes;
}

Console.WriteLine($"Person {selectedId} spent {totalMinutes} minutes inside, " + $"{(intervals.Last().end == null ? "was" : "was not")} inside at the end.");