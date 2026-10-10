using System.Collections;

namespace AreaCalculatorNonPolymorphism
{
    public class AreaCalculator
    {
        private List<Circle> Circles { get; set; }
        private List<Triangle> Triangles { get; set; }
        private List<Rectangle> Rectangles { get; set; }

        public AreaCalculator() //method constructor
        {
            this.Circles = new List<Circle>();
            this.Triangles = new List<Triangle>();
            this.Rectangles = new List<Rectangle>();
        }

        public void AddCircle(Circle c)
        {
            this.Circles.Add(c);
        }

        public void AddTriangle(Triangle t)
        {
            this.Triangles.Add(t);
        }

        public void AddRectangle(Rectangle r)
        {
            this.Rectangles.Add(r);
        }

        public double TotalArea()
        {
            double totalArea = 0.0;

            foreach (Circle c in this.Circles)
            {
                totalArea += c.Area();
            }

            foreach (Triangle t in this.Triangles)
            {
                totalArea += t.Area();
            }

            foreach (Rectangle r in this.Rectangles)
            {
                totalArea += r.Area();
            }

            return totalArea;
        }
    }
}
