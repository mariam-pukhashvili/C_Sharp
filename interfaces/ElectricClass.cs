

public abstract class ElectricClass : Car
{
    public string color { get; set; }
    public string model { get; set; }
    public double battery{ get;set; }
    public abstract void Start();
    public abstract void Stop();
    public abstract void Drive();
    
    public abstract void Charge();

}
