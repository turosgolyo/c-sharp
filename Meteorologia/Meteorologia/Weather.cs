namespace Meteorologia;

public class Weather
{
    public string City { get; set; }
    public DateTime Time { get; set; }
    public string Wind { get; set; }
    public int Temperature { get; set; }

    public override string ToString()
    {
        return $"{City} - {Time.ToString("HH:mm")}: {Wind} - {Temperature} °C";
    }
}
