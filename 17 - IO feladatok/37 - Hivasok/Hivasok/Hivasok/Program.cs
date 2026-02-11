using Hivasok;

Console.Write("Enter phone number:");
string inputNumber = Console.ReadLine();

Console.WriteLine(IsMobileNumber(inputNumber)
    ? "Mobile phone number"
    : "Landline phone number");

Console.Write("Enter start time (hour minute second): ");
string[] startInput = Console.ReadLine().Split();

Console.Write("Enter end time (hour minute second): ");
string[] endInput = Console.ReadLine().Split();

TimeSpan startTime = new TimeSpan(
    int.Parse(startInput[0]),
    int.Parse(startInput[1]),
    int.Parse(startInput[2]));

TimeSpan endTime = new TimeSpan(
    int.Parse(endInput[0]),
    int.Parse(endInput[1]),
    int.Parse(endInput[2]));

int billedMinutes =
    (int)Math.Ceiling((endTime - startTime).TotalSeconds / 60.0);

Console.WriteLine($"Billed duration: {billedMinutes} minutes");


List<Call> calls = new List<Call>();
string[] lines = File.ReadAllLines("hivasok.txt");

for (int i = 0; i < lines.Length; i += 2)
{
    string[] data = lines[i].Split();

    Call call = new Call
    {
        StartTime = new TimeSpan(
            int.Parse(data[0]),
            int.Parse(data[1]),
            int.Parse(data[2])),
        EndTime = new TimeSpan(
            int.Parse(data[3]),
            int.Parse(data[4]),
            int.Parse(data[5])),
        PhoneNumber = lines[i + 1]
    };

    calls.Add(call);
}


using (StreamWriter writer = new StreamWriter("percek.txt"))
{
    foreach (Call call in calls)
    {
        writer.WriteLine(
            $"{call.GetBilledMinutes()} {call.PhoneNumber}");
    }
}

int peakCalls = 0;
int offPeakCalls = 0;

foreach (Call call in calls)
{
    if (call.IsPeakTime())
        peakCalls++;
    else
        offPeakCalls++;
}

Console.WriteLine($"Peak time calls: {peakCalls}");
Console.WriteLine($"Off-peak calls: {offPeakCalls}");


int mobileMinutes = 0;
int landlineMinutes = 0;

foreach (Call call in calls)
{
    if (call.IsMobile())
        mobileMinutes += call.GetBilledMinutes();
    else
        landlineMinutes += call.GetBilledMinutes();
}

Console.WriteLine($"Mobile minutes: {mobileMinutes}");
Console.WriteLine($"Landline minutes: {landlineMinutes}");


double totalPeakCost = 0;

foreach (Call call in calls)
{
    if (!call.IsPeakTime())
        continue;

    if (call.IsMobile())
    {
        totalPeakCost += call.GetBilledMinutes() * 69.175;
    }
    else
    {
        totalPeakCost += call.GetBilledMinutes() * 30;
    }
        
}

Console.WriteLine($"Total peak time cost: {totalPeakCost:F2} HUF");
        

static bool IsMobileNumber(string phoneNumber)
{
    string prefix = phoneNumber.Substring(0, 2);
    return prefix == "39" || prefix == "41" || prefix == "71";
}