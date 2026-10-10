namespace AreaCalculatorPolymorphism
{
    public class Square : Shape
    {
        public int Side { get; set; }

        public Square(int side)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }
}
