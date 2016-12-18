namespace BankAccounts
{
    using System;

    public class Company: Customer
    {
        private string companyManager;

        // Constructors

        public Company(string name, long iDNumber,string companyManager)
            :base(name,iDNumber)
        {
            this.CompanyManager = companyManager;
        }

        // Properties
        public string CompanyManager
        {
            get { return this.companyManager; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("There cannot be company account without the company's manager name");
                }
                else
                {
                    this.companyManager = value;
                }
            }
        }

        // Methods

        public override string ToString()
        {
            return base.ToString() + "\n\rCompany manager: " + this.CompanyManager;
        }
    }
}
