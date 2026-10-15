using System;

namespace EnvironmentInterface;

public class Car : DrawingObject, IMovingObject
{
    public void Move()
    {
        Console.WriteLine("Ini mobil muter-muter");
    }

    public override void Render()
    {
        Console.WriteLine("Ini mobil");
    }
}
