using System.Collections.Generic;
using Bash_Soft.Exceptions;

public class Course
{
    private string courseName;
    private Dictionary<string, Student> studentsByName;
    public const int NumberOfTasksOnExam = 5;
    public const int MaxScoreOnExamTask = 100;

    public Course(string name)
    {
        this.courseName = name;
        studentsByName = new Dictionary<string, Student>();
    }

    public string CourseName
    {
        get { return this.courseName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new InvalidStringException();
            }
            this.courseName = value;
        }
    }

    public IReadOnlyDictionary<string, Student> StudentsByName
    {
        get { return this.studentsByName; }
    }

    public void EnrollStudent(Student student)
    {
        if (this.studentsByName.ContainsKey(student.UserName))
        {
            throw new DuplicateEntryInStructureException(student.UserName, this.courseName);
        }

        this.studentsByName.Add(student.UserName, student);
    }
}