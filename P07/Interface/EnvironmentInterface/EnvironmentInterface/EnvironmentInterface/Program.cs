namespace EnvironmentInterface;

internal class Program
{
    static void Main(string[] args)
    {
        Environment pict = new Environment();

        pict.AddDrawingObject(new Mountain());
        pict.AddDrawingObject(new Mountain());
        pict.AddDrawingObject(new Car());
        pict.AddDrawingObject(new Bird());

        pict.DrawPicture();
        pict.AnimatePicture();

    }
}
