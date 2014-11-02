//•	Define two new BasicShape subclasses: Triangle and Rectangle that implement the abstract methods CalculateArea() and CalculatePerimeter().

namespace _01.Shapes
{
    using System;

    public class Triangle : BasicShape
    {
        public Triangle(double side, double height):
            base(side, height)
        {
        }

        public override double CalculateArea()
        {
            double area = (this.Width * this.Height) / 2;

            return area;
        }

        public override double CalculatePerimeter()
        {
            //I am gonan assume the triangle is right.
            double thirdSide = Math.Sqrt(this.Width * this.Width + this.Height * this.Height);
            double perimeter = this.Width + this.Height + thirdSide;

            return perimeter;
        }
    }
}
