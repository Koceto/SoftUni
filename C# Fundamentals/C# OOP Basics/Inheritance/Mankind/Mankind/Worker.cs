using System;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal salary;
        private decimal workingHours;

        public Worker(string firstName, string lastName, decimal salary, decimal hours) : base(firstName, lastName)
        {
            this.Salary = salary;
            this.WorkingHours = hours;
        }

        public decimal WorkingHours
        {
            get { return this.workingHours; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workingHours = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.salary = value;
            }
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.Append("First Name: ").AppendLine(this.FirstName)
                .Append("Last Name: ").AppendLine(this.LastName)
                .Append("Week Salary: ").AppendLine($"{this.Salary:f2}")
                .Append("Hours per day: ").AppendLine($"{this.WorkingHours:f2}")
                .Append("Salary per hour: ").AppendLine($"{this.Salary / 5 / this.WorkingHours:f2}");

            return info.ToString();
        }
    }
}