using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition;

public class Engine
{
    private int _engineCapacity;
    private int _enginePower;

    public Engine(int engineCapacity, int enginePower)
    {
        _engineCapacity = engineCapacity;
        _enginePower = enginePower;
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
}
