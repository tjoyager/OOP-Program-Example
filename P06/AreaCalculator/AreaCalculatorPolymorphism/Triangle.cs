namespace AreaCalculatorPolymorphism
{
    public class Triangle : Shape
    {
        public int Base { get; set; }
        public int Height { get; set; }

        public Triangle(int baseValue, int height)
        {
            Base = baseValue;
            Height = height;
        }

        public override double Area()
        {
            return 0.5 * Base * Height;
        }
    }
}
