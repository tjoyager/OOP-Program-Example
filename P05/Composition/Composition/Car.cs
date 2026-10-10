namespace Composition;

public class Car
{
    private string _brand;
    private int _speed;
    private Engine _engine;

    public Car(string brand, int speed, Engine engine)
    {
        _brand = brand;
        _speed = speed;
        _engine = engine;
    }

    public void TurnOn()
    {
        this._engine.IgniteEngine();
        //doing other things
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
