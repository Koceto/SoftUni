using System.Collections.Generic;

namespace Company_Roster
{
    internal class Department
    {
        public Department(string name, Employee employee)
        {
            this.Name = name;
            this.Employees = new List<Employee>() { employee };
        }

        public string Name { get; set; }

        public List<Employee> Employees { get; set; }

        public double TotalSalary()
        {
            double totalSalary = default(double);

            foreach (var employee in Employees)
            {
                totalSalary += employee.Salary;
            }

            return totalSalary;
        }
    }
}