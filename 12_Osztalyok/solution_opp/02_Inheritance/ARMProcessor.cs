
public class ARMProcessor : Processor
{
    public int NumberOfPowerCores { get; set; }
    public int NumberOfEfficiencyCores { get; set; }
    public ARMProcessor() : base()
    {
    }
    public ARMProcessor(int numberOfPowerCores, int numberOfEfficiencyCores) : base()
    {
        NumberOfPowerCores = numberOfPowerCores;
        NumberOfEfficiencyCores = numberOfEfficiencyCores;
    }
    public ARMProcessor(
        int numberOfPowerCores, 
        int numberOfEfficiencyCores,
        int numberOfCores,     
        double frequency) : base(numberOfCores, frequency)
    {
        NumberOfPowerCores = numberOfPowerCores;
        NumberOfEfficiencyCores = numberOfEfficiencyCores;
    }
}

