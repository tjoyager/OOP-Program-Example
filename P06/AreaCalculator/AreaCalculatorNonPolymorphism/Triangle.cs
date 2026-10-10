namespace AreaCalculatorNonPolymorphism
{
    public class Triangle
    {
        public int Base { get; set; }
        public int Height { get; set; }

        public Triangle(int baseValue, int height)
        {
            Base = baseValue;
            Height = height;
        }

        public double Area()
        {
            return 0.5 * Base * Height;
        }
    }
}
