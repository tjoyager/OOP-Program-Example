using System.Collections;

namespace AreaCalculatorPolymorphism
{
    public class AreaCalculator
    {
        private List<Shape> Shapes { get; set; }

        public AreaCalculator() //method constructor io
        {
            this.Shapes = new List<Shape>();
        }

        public void AddShape(Shape s)
        {
            this.Shapes.Add(s);
        }

        public double TotalArea()
        {
            double totalArea = 0.0;

            foreach (Shape s in this.Shapes)
            {
                totalArea += s.Area();
            }

            return totalArea;
        }
    }
}
