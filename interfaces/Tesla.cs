

public class Tesla : ElectricClass
{
    public override void Start()
    {
        Console.WriteLine("Starting the Tesla");
    }
    public override void Stop()
    {
        Console.WriteLine("Stopping the Tesla");
    }
    public override void Drive()
    {
        Console.WriteLine("Driving the Tesla ");
    }
     public override void Charge()
    {
        Console.WriteLine("Charging my Tesla...");
    }
}
