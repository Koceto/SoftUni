using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_Joined_to_Specialties
{
    public static class StartUp
    {
        public static void Main()
        {
            List<StudentSpecialty> specs = new List<StudentSpecialty>();
            List<Student> students = new List<Student>();
            string input;

            while ((input = Console.ReadLine()) != "Students:")
            {
                var data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                StudentSpecialty currentSpec = new StudentSpecialty();

                currentSpec.FacultyNumber = data.Last();
                currentSpec.Name = $"{data[0]} {data[1]}";
                specs.Add(currentSpec);
            }

            while ((input = Console.ReadLine()) != "END")
            {
                var data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Student currentStudent = new Student();

                currentStudent.FacultyNumber = data.First();
                currentStudent.Name = $"{data[1]} {data[2]}";
                students.Add(currentStudent);
            }

            foreach (var student in students.OrderBy(s => s.Name))
            {
                foreach (var studentSpecs in specs.Where(s => s.FacultyNumber == student.FacultyNumber))
                {
                    Console.WriteLine($"{student.Name} {student.FacultyNumber} {studentSpecs.Name}");
                }
            }
        }
    }
}