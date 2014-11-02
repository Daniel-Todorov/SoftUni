namespace _02.FractionCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("The denominator cannot be zero.");
            }

            this.numerator = numerator;
            this.denominator = denominator;

            if (this.denominator < 0)
            {
                this.numerator = -numerator;
                this.denominator = -denominator;
            }
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("The denominator cannot be zero.");
                }

                this.Denominator = denominator;
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long num = f1.numerator * f2.denominator +
                f2.numerator * f1.denominator;
            long denom = f1.denominator * f2.denominator;

            return new Fraction(num, denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long num = f1.numerator * f2.denominator -
                f2.numerator * f1.denominator;
            long denom = f1.denominator * f2.denominator;

            return new Fraction(num, denom);
        }

        public override string ToString()
        {
            return ((decimal)this.Numerator / this.Denominator).ToString();
        }
    }
}
