
namespace AbstractShape
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //Shape shape = new Shape(); //error. Tidak dapat membuat object dari kelas abstrak.
            //Console.WriteLine(shape.Area()); //error

            Shape c = new Circle(10);
            Shape r = new Rectangle(7, 5);
            Shape t = new Triangle(10, 4);
            Shape s = new Square(10);

            Console.WriteLine(c.Area());
            Console.WriteLine(r.Area());
            Console.WriteLine(t.Area());
            Console.WriteLine(s.Area());


        }
    }
}
