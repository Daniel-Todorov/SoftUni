//•	Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.

namespace _02.BankOfKurtovKonare
{
    using System;

    public class Mortgage : Account, IDepositable
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentOutOfRangeException("months", "Months can't be negative number.");
            }

            if (this.Customer.Type == CustomerType.Individual)
            {
                if (months <= 6)
                {
                    return this.Balance;
                }
            }
            else if (this.Customer.Type == CustomerType.Company)
            {
                if (months <= 12)
                {
                    return this.Balance * (1 + (this.InterestRate / 2) * months);
                }
            }

            return this.Balance * (1 + this.InterestRate * months);
        }

        public void DepositMoney(decimal amountToDeposit)
        {
            if (amountToDeposit < 0)
            {
                throw new ArgumentException("amountToDeposit", "You can't deposit negative sum.");
            }

            this.Balance += amountToDeposit;
        }
    }
}
