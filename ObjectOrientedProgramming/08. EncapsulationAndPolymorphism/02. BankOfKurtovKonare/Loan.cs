//•	Loan accounts have no interest for the first 3 months if held by individuals and for the first 2 months if held by a company.

namespace _02.BankOfKurtovKonare
{
    using System;

    public class Loan : Account, IDepositable
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentOutOfRangeException("months", "Months can't be negative number.");
            }

            int modifiedMonths = months;

            if (this.Customer.Type == CustomerType.Individual)
            {
                modifiedMonths = months - 3;
            }
            else if (this.Customer.Type == CustomerType.Company)
            {
                modifiedMonths = months - 2;
            }

            if (modifiedMonths < 0)
            {
                return this.Balance;
            }

            decimal interest = this.Balance * (1 + this.InterestRate * modifiedMonths);

            return interest;
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
