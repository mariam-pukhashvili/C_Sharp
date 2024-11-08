
interface Car
{
    string model { get; set; }
    string color { get; set; }
    double battery{ get;set; }
    void Start();
    void Stop();
    void Drive();
    void Charge();
}
