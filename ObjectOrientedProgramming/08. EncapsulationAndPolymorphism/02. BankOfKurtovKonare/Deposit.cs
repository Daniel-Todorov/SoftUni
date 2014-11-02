//•	Deposit accounts have no interest if their balance is positive and less than 1000.

namespace _02.BankOfKurtovKonare
{
    using System;

    public class Deposit : Account, IDepositable, IWithdrawable
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentOutOfRangeException("months", "Months can't be negative number.");
            }

            if (this.Balance >= 0 && this.Balance < 1000)
            {
                return this.Balance;
            }

            decimal interest = this.Balance * (1 + this.InterestRate * months);

            return interest;
        }

        public void DepositMoney(decimal amountToDeposit)
        {
            if (amountToDeposit < 0)
            {
                throw new ArgumentOutOfRangeException("amountToDeposit", "You can't deposit negative sum.");
            }

            this.Balance += amountToDeposit;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw < 0)
            {
                throw new ArgumentOutOfRangeException("amountToWithdraw", "You can't withdraw negative sum.");
            }

            if (amountToWithdraw > this.Balance)
            {
                throw new ArgumentException("amountToWithdraw", "You can't withdraw more money than you have.");
            }

            this.Balance -= amountToWithdraw;
        }
    }
}
