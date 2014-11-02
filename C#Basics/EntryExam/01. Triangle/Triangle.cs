using System;

class Triangle
{
    static void Main()
    {
        double Ax = double.Parse(Console.ReadLine());
        double Ay = double.Parse(Console.ReadLine());
        double Bx = double.Parse(Console.ReadLine());
        double By = double.Parse(Console.ReadLine());
        double Cx = double.Parse(Console.ReadLine());
        double Cy = double.Parse(Console.ReadLine());

        double a = Math.Sqrt((Cx - Bx) * (Cx - Bx) + (Cy - By) * (Cy - By));
        double b = Math.Sqrt((Ax - Cx) * (Ax - Cx) + (Ay - Cy) * (Ay - Cy));
        double c = Math.Sqrt((Bx - Ax) * (Bx - Ax) + (By - Ay) * (By - Ay));

        bool canFormTriangle = a + b > c && b + c > a && a + c > b;

        double p = (a + b + c) / 2; //Half perimeter
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        if (canFormTriangle)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0:0.00}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}", c);
        }
    }
}
