using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorPolymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Circle c = new Circle(10);
            Rectangle r = new Rectangle(7, 5);
            Triangle t = new Triangle(10, 4);
            Square s = new Square(10);

            //Berapa total luas dari bangun 2D c, r, dan t?
            AreaCalculator calc = new AreaCalculator();
            calc.AddShape(c);
            calc.AddShape(r);
            calc.AddShape(t);
            calc.AddShape(s);

            var totalArea = calc.TotalArea();

            Console.WriteLine($"Total Area = {totalArea}");

        }
    }
}
