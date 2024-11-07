

public abstract class ElectricClass : Car
{
    public abstract void Start();
    public abstract void Stop();
    public abstract void Drive();
    public void Charge()
    {
        Console.WriteLine("Charging...");
    }
}

