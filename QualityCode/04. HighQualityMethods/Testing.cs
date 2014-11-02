namespace Methods
{
    using System;

    public class Testing
    {
        public static void Main()
        {
            Console.WriteLine(MathUtils.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(MathUtils.DigitToWord(5));

            Console.WriteLine(MathUtils.FindMaxInteger(5, -1, 3, 2, 14, 2, 3));

            Console.WriteLine(MathUtils.FormatNumber(1.3, "f"));
            Console.WriteLine(MathUtils.FormatNumber(0.75, "%"));
            Console.WriteLine(MathUtils.FormatNumber(2.30, "indent"));

            Console.WriteLine(MathUtils.CalcDistanceBetween2DPoints(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + MathUtils.IsLineHorizontal(-1, 2.5));
            Console.WriteLine("Vertical? " + MathUtils.IsLineVertical(3, 3));

            Student peter = new Student()
            {
                FirstName = "Peter",
                LastName = "Ivanov",
                BirthPlace = "Sofia",
                Birthday = DateTime.Parse("17.03.1992")
            };

            Student stella = new Student()
            {
                FirstName = "Stella",
                LastName = "Markova",
                BirthPlace = "Vidin",
                Occupation = "gamer",
                Notes = "high results",
                Birthday = DateTime.Parse("03.11.1993")
            };

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
