//Problem 2.	Bank of Kurtovo Konare
//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
//•	Customers could be individuals or companies.
//•	All accounts have customer, balance and interest rate (monthly based). 
//•	Deposit accounts are allowed to deposit and withdraw money. Loan and mortgage accounts can only deposit money.
//•	All accounts can calculate their interest for a given period (in months) using the formula
//A = money * (1 + interest rate * months) 
//•	Loan accounts have no interest for the first 3 months if held by individuals and for the first 2 months if held by a company.
//•	Deposit accounts have no interest if their balance is positive and less than 1000.
//•	Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Write a program to model the bank system with classes and interfaces. 
//You should identify the classes, interfaces, base classes and abstract actions 
//and implement the calculation of the interest functionality through overridden methods. 
//Write a program to demonstrate that your classes work correctly.

namespace _02.BankOfKurtovKonare
{
    using System;
    using System.Collections.Generic;

    public class Testing
    {
        public static void Main()
        {
            var individual = new Customer("Ivan", "1234567890", CustomerType.Individual);
            var company = new Customer("MicroIntelect", "0000000000", CustomerType.Company);

            List<Account> accounts = new List<Account>();
            accounts.Add(new Deposit(individual, 900, 0.05M));
            accounts.Add(new Deposit(company, 2000, 0.1M));
            accounts.Add(new Loan(individual, 1000, 0.1M));
            accounts.Add(new Loan(company, 1000, 0.1M));
            accounts.Add(new Mortgage(individual, 1000, 0.1M));
            accounts.Add(new Mortgage(company, 1000, 0.1M));

            int months = 6;

            foreach (var account in accounts)
            {
                Console.WriteLine("Account type: {0}, Customer type: {1}, Balance: {2}, Interest: {3} for {4} months.", 
                    account.GetType().Name, account.Customer.Type.ToString(), account.Balance, account.CalculateInterest(months), months);
                Console.WriteLine();
            }
        }
    }
}
