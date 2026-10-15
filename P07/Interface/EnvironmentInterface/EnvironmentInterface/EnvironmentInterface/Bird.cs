using System;

namespace EnvironmentInterface;

public class Bird : DrawingObject, IMovingObject
{
    public void Move()
    {
        Console.WriteLine("Ini gambar burung berterbangan...");
    }

    public override void Render()
    {
        Console.WriteLine("Ini gambar burung...");
    }
}
