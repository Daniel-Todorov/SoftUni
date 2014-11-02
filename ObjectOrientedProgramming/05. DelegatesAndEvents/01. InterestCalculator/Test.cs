//Create a delegate CalculateInterest (or use Func<…>) with parameters 
//sum of money, interest and years that calculates the interest according to the method it points to. 
//The result should be rounded to 4 places after the double point.
//•	Create a method GetSimpleInterest(sum, interest, years). 
//The interest should be calculated by the formula A = sum * (1 + interest * years).
//•	Create a method GetCompoundInterest(sum, interest, years). 
//The interest should be calculated by the formula A = sum * (1 + interest / n)year * n, 
//where n is the number of times per year the interest is compounded. 
//Assume n is always 12.

//Create a class InterestCalculator that takes in its constructor money, interest, years and interest calculation delegate.
//Using this class calculate the interest for the following input parameters:

namespace _01.InterestCalculator
{
    using System;

    public class Test
    {
        private const double NumberOfTimesPerYearTheInterestIsCompounded = 12;

        public static void Main()
        {
            CalculateInterestDelegate compoundInterestDelegate = GetCompoundInterest;
            var compoundCalculator = new InterestCalculator(500, 0.056, 10, compoundInterestDelegate);
            Console.WriteLine("Compound interest: {0:0.0000}", compoundCalculator.CalculateInterest());

            CalculateInterestDelegate simpleInterestDelegate = GetSimpleInterest;
            var simpleCalculator = new InterestCalculator(2500, 0.072, 15, simpleInterestDelegate);
            Console.WriteLine("Simple interest: {0:0.0000}", simpleCalculator.CalculateInterest());
        }

        public static double GetSimpleInterest(double sum, double interest, double years){
            var A = sum * (1 + interest * years);

            return A;
        }

        public static double GetCompoundInterest(double sum, double interest, double years)
        {
            double power = years * NumberOfTimesPerYearTheInterestIsCompounded;
            double A = sum * Math.Pow((1 + interest / NumberOfTimesPerYearTheInterestIsCompounded), power);

            return A;
        }
    }
}
