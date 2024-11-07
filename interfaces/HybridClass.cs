
public abstract class HybridClass : Car
{
    public abstract void Start();
    public abstract void Stop();
    public abstract void Drive();
    public void SwitchToElectricMode()
    {
        Console.WriteLine("Switching to electric mode...");
    }
}
