//•	Define two new BasicShape subclasses: Triangle and Rectangle that implement the abstract methods CalculateArea() and CalculatePerimeter().

namespace _01.Shapes
{
    using System;

    public class Rectangle : BasicShape
    {
        public Rectangle(double fisrtSide, double secondSide)
            :base(fisrtSide, secondSide)
        {
        }

        public override double CalculateArea()
        {
            double area = this.Width * this.Height;

            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }
    }
}
