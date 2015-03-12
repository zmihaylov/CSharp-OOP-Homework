namespace AbstractHuman
{
    using System;

    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workDaysPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workDaysPerDay;
        }

        public decimal WorkHoursPerDay { get; private set; }

        public decimal WeekSalary { get; private set; }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay * 5;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.MoneyPerHour();
        }
    }
}
