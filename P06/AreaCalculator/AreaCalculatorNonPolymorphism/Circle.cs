namespace AreaCalculatorNonPolymorphism
{
    public class Circle
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return 3.14 * Radius * Radius;
        }

    }
}
