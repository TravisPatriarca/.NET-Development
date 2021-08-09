abstract class Motorcycle
{
    public void StartEngine() 
    { /* implementation here */ }

    protected void AddGas(int gallons) 
    { /* implementation here */ }

    public virtual int Drive(int miles, int speed) 
    { /* implementation here */ return 1; }

    public abstract double getTopSpeed();
}

class TestMotorcycle : Motorcycle
{
    public override double GetTopSpeed()
    {
        return 108.4;
    }

    static void Main()
    {
        TestMotorcycle moto = new TestMotorcycle();
        moto.StartEngine();
        moto.AddGas(15);
        moto.Drive(5, 20);
        double speed = moto.GetTopSpeed();
        Console.WriteLine("My top speed is {0}", speed);
    }
} 