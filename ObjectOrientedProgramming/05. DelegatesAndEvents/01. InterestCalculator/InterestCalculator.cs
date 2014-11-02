namespace _01.InterestCalculator
{
    public class InterestCalculator
    {
        public InterestCalculator(double money, double interest, double years, CalculateInterestDelegate interestCalculateMethod)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.Calculator = interestCalculateMethod;
        }

        public double Money { get; set; }

        public double Interest { get; set; }

        public double Years { get; set; }

        public CalculateInterestDelegate Calculator { get; set; }

        public double CalculateInterest()
        {
             return this.Calculator(this.Money, this.Interest, this.Years);
        }
    }
}
