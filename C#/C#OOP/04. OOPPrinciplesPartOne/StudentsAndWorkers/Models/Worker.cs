namespace StudentsAndWorkers.Models
{
    using AbstractModels;
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string first,
            string last,
            decimal weekSalary,
            decimal hoursDay)
            : base(first, last)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = hoursDay;
        }

        
        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (!(value < 0))
                {
                    throw new Exception("Value cannot be negative");
                }
                else
                {
                    this.weekSalary = value;
                }
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (!(0 <= value && value <= 24))
                {
                    throw new Exception("Unable to work more than 24h/ day");
                }
                this.workHoursPerDay = value;
            }
        }
        

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay;
        }

        public override string ToString()
        {
            return base.FullName + $", Wage: {this.MoneyPerHour().ToString("F2")}/ hour";
        }
    }
}
