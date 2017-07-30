using System;
using System.Linq;
using System.Text;

namespace Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10 || !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.Append("First Name: ").AppendLine(this.FirstName)
                .Append("Last Name: ").AppendLine(this.LastName)
                .Append("Faculty number: ").AppendLine(this.facultyNumber);

            return info.ToString();
        }
    }
}