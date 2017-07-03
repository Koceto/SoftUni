using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Roster
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Department> departments = new List<Department>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                double salary = double.Parse(input[1]);
                string position = input[2];
                string department = input[3];
                int age = -1;
                string email = "n/a";

                if (input.Length >= 5)
                {
                    email = input[4];
                }

                if (input.Length >= 6)
                {
                    age = int.Parse(input[5]);
                }

                Employee newCompanyRoster = new Employee(name, salary, position, department, email, age);

                Department currentDepartment = departments.FirstOrDefault(d => d.Name == newCompanyRoster.Department);

                if (currentDepartment == null)
                {
                    departments.Add(new Department(newCompanyRoster.Department, newCompanyRoster));
                }
                else
                {
                    currentDepartment.Employees.Add(newCompanyRoster);
                }
            }

            Department biggest = departments.OrderByDescending(d => d.TotalSalary()).First();
            Console.WriteLine($"Highest Average Salary: {biggest.Name}");

            foreach (var employee in biggest.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary} {employee.Email} {employee.Age}");
            }
        }
    }
}