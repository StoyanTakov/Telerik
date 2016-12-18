namespace BankAccounts
{
    using System;

    public class LoanAccount : Account, IDepositable
    {

        // Constructors

        public LoanAccount(Customer customer, decimal bankBalance, decimal interestRate)
            : base(customer, bankBalance, interestRate)
        {

        }

        // Methods

        public override decimal InterestAmount(int months)
        {
            decimal interestAmount = 0.00M;

            if (this.Customer is Individual && months >= 2)
            {
                interestAmount = this.InterestRate/100 * (months - 2);
            }
            else if (this.Customer is Company && months >= 3)
            {
                interestAmount = this.InterestRate/100 * (months - 2);
            }
            return interestAmount;
        }

       
        public void AddMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You must deposit something that is not a negative sum !!");
            }
            if (this.BankBalance < amount)
            {
                Console.WriteLine("Congrats! The money that you have put back are apreaciated !!");
                this.BankBalance = 0;
            }
            else
            {
                this.BankBalance -= amount;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
