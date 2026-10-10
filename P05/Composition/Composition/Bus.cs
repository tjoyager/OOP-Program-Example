namespace Composition;

public class Bus
{
    private string _brand;
    private int _speed;
    private Engine _engine;

    public Bus(string brand, int speed, Engine engine)
    {
        _brand = brand;
        _speed = speed;
        _engine = engine;
    }

    public void TurnOn()
    {
        this._engine.IgniteEngine();
    }

    public void TurnOff()
    {
        this._engine.ShutDownEngine();
    }

    public void Accelerate(int speed)
    {
        this._engine.AccelerateEngine(speed);
    }

    public void Brake()
    {
        this._engine.DeaccelerateEngine(10);
    }

}
