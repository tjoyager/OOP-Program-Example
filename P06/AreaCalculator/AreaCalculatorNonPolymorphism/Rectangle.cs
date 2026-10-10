namespace AreaCalculatorNonPolymorphism
{
    public class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public double Area()
        {
            return Length * Width;
        }
    }
}
