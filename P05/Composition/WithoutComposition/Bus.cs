namespace WithoutComposition;

public class Bus
{
    private string _brand;
    private int _engineCapacity;
    private int _enginePower;
    private int _speed;

    public Bus(string brand, int engineCapacity, int enginePower, int speed)
    {
        _brand = brand;
        _engineCapacity = engineCapacity;
        _enginePower = enginePower;
        _speed = speed;
    }

    public void IgniteEngine()
    {
        this._enginePower = 10;
    }

    public void ShutDownEngine()
    {
        this._enginePower = 10;
    }

    public void AccelerateEngine(int amount)
    {
        this._enginePower += amount;
    }

    public void DeaccelerateEngine(int amount)
    {
        this._enginePower -= amount;
    }

    public void TurnOn()
    {
        this.IgniteEngine();
    }

    public void TurnOff()
    {
        this.ShutDownEngine();
    }

    public void Accelerate(int speed)
    {
        this.AccelerateEngine(speed);
    }

    public void Brake()
    {
        this.DeaccelerateEngine(10);
    }

}
