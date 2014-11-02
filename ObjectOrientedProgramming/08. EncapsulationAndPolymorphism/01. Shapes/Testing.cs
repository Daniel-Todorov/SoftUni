//Problem 1. Shapes
//•	Define an interface IShape with two abstract methods: CalculateArea() and CalculatePerimeter().
//•	Define an abstract class BasicShape implementing IShape and holding width and height. 
//  Leave the methods CalculateArea() and CalculatePerimeter() abstract.
//•	Define two new BasicShape subclasses: Triangle and Rectangle that implement the abstract methods CalculateArea() and CalculatePerimeter().
//•	Define a class Circle with a suitable constructor and IShape.
//•	Create an array of different shapes (Circle, Rectangle, Triangle) and test the behavior of the CalculateSurface() and CalculatePerimeter() methods.

namespace _01.Shapes
{
    using System;

    public class Testing
    {
        public static void Main()
        {
            IShape[] shapes = new IShape[3];
            shapes[0] = new Circle(10);
            shapes[1] = new Rectangle(5, 6);
            shapes[2] = new Triangle(3, 4);

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0} => Area: {1}, Perimeter: {2}", shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}
