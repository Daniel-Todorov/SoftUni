//•	Define an abstract class BasicShape implementing IShape and holding width and height. 
//  Leave the methods CalculateArea() and CalculatePerimeter() abstract.

namespace _01.Shapes
{
    public abstract class BasicShape : IShape
    {
        protected double width;
        protected double height;

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
