namespace Methods
{
    using System;

    public static class MathUtils
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("All sides must have positive length.");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Lines with such length cannot for a triangle.");
            }

            double semiperimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));

            return area;
        }

        public static string DigitToWord(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("The passed argument is not a digit (integer number N => 0 <= N <= 9)", "digit");
            }
        }

        public static int FindMaxInteger(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("elements", "Cannot find max number in null array.");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("Cannot find max number in empty array.", "elements");
            }

            int maxNumber = int.MinValue;

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxNumber)
                {
                    maxNumber = elements[i];
                }
            }

            return maxNumber;
        }

        /// <summary>
        /// Formats a number according to a predefined format.
        /// </summary>
        /// <param name="number">A double value number to be formated.</param>
        /// <param name="format">String "f" for 2 digits after the ., "%" to get the number is procentage and "indent" to have the numberindented with 8 positions.</param>
        public static string FormatNumber(double number, string format)
        {
            switch (format)
            {
                case "f":
                    return string.Format("{0:f2}", number);
                case "%":
                    return string.Format("{0:p0}", number);
                case "indent":
                    return string.Format("{0,8}", number);
                default:
                    throw new ArgumentException("Unsupported format.", "format");
            }
        }


        public static double CalcDistanceBetween2DPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            return distance;
        }

        public static bool IsLineVertical(double x1, double x2)
        {
            if (x1 == x2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsLineHorizontal(double y1, double y2)
        {
            if (y1 == y2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
