/*
    A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
    All accounts have customer, balance and interest rate (monthly based).
        Deposit accounts are allowed to deposit and with draw money.
        Loan and mortgage accounts can only deposit money.
    All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
    Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
    Deposit accounts have no interest if their balance is positive and less than 1000.
    Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
    Your task is to write a program to model the bank system by classes and interfaces.
    You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
*/

namespace BankAccounts
{
    using System;

    public class BankSystemMain
    {
        public static void Main()
        {
           
            Console.WriteLine("Deposit Account: ");

            var depositAcc = new DepositAccount(new Individual("Katya Ivanova", 213, new DateTime(1996, 5, 21), Gender.Female), 200000, 4);
            Console.WriteLine(depositAcc.ToString());
            depositAcc.AddMoney(20000);
            depositAcc.WithdrawMoney(213);

            Console.WriteLine("{0} Interest amount: {1}%", depositAcc.GetType().Name, depositAcc.InterestAmount(8)); // interest amount method

            Console.WriteLine(new string('-',50));

            var companyDeposit = new DepositAccount(new Company("Apple", 12345, "Steve Jobs"), 52342343, 234);
            Console.WriteLine(companyDeposit.ToString());

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Loan Deposit: ");
            var loanDeposit = new LoanAccount(new Individual("Dimitur Topchev", 213, new DateTime(1992, 12, 14), Gender.Male), 2000, 2);
            Console.WriteLine(loanDeposit.ToString());
            Console.WriteLine("Interest amount {0}%",loanDeposit.InterestAmount(12));
            loanDeposit.AddMoney(23456);

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Mortgage Deposit");
            var mortgageAcc = new MortgageAccount(new Company("BFFS", 12383128, "Golemata Hazna"), 2500000, 0.1m);
            Console.WriteLine(mortgageAcc.ToString());
            Console.WriteLine("Interest amount {0}%", mortgageAcc.InterestAmount(12));
            
        }
    }
}
