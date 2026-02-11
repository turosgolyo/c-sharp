namespace Hivasok;

public class Call
{
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public string PhoneNumber { get; set; }

    public int GetBilledMinutes()
    {
        int durationInSeconds = (int)(EndTime - StartTime).TotalSeconds;
        return (int)Math.Ceiling(durationInSeconds / 60.0);
    }

    public bool IsMobile()
    {
        string prefix = PhoneNumber.Substring(0, 2);
        return prefix == "39" || prefix == "41" || prefix == "71";
    }

    public bool IsPeakTime()
    {
        return StartTime >= new TimeSpan(7, 0, 0) &&
               StartTime < new TimeSpan(18, 0, 0);
    }
}