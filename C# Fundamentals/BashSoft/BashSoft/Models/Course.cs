using BashSoft.Contracts;
using BashSoft.Exceptions;
using System.Collections.Generic;

public class Course : ICourse
{
    public const int NumberOfTasksOnExam = 5;
    public const int MaxScoreOnExamTask = 100;

    private string name;
    private Dictionary<string, IStudent> studentsByName;

    public Course(string name)
    {
        this.name = name;
        studentsByName = new Dictionary<string, IStudent>();
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new InvalidStringException();
            }
            this.name = value;
        }
    }

    public IReadOnlyDictionary<string, IStudent> StudentsByName
    {
        get { return this.studentsByName; }
    }

    public void EnrollStudent(IStudent student)
    {
        if (this.studentsByName.ContainsKey(student.Name))
        {
            throw new DuplicateEntryInStructureException(student.Name, this.name);
        }

        this.studentsByName.Add(student.Name, student);
    }

    public int CompareTo(ICourse other)
    {
        return this.Name.CompareTo(other.Name);
    }

    public override string ToString()
    {
        return this.Name;
    }
}