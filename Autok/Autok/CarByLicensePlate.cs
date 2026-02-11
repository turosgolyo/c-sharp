namespace Autok;

public class CarByLicensePlate
{
    public string LicensePlate { get; set; }
    public int KmCount { get; set; }

    public override string ToString()
    {
        return $"{LicensePlate} {KmCount} km";
    }
}
