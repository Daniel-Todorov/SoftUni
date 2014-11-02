//•	All accounts have customer, balance and interest rate (monthly based). 
//•	Deposit accounts are allowed to deposit and withdraw money. Loan and mortgage accounts can only deposit money.
//•	All accounts can calculate their interest for a given period (in months) using the formula
//A = money * (1 + interest rate * months) 

namespace _02.BankOfKurtovKonare
{
    public abstract class Account
    {
        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public abstract decimal CalculateInterest(int months);
    }
}
