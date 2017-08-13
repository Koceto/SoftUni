using BashSoft.Contracts;
using BashSoft.Exceptions;
using System.Collections.Generic;
using System.Linq;

public class Student : IStudent
{
    private string name;
    private Dictionary<string, ICourse> enrollerCourses;
    private Dictionary<string, double> marksByCourseName;

    public Student(string name)
    {
        this.Name = name;
        this.enrollerCourses = new Dictionary<string, ICourse>();
        this.marksByCourseName = new Dictionary<string, double>();
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

    public IReadOnlyDictionary<string, ICourse> EnrolledCourses
    {
        get { return this.enrollerCourses; }
    }

    public IReadOnlyDictionary<string, double> MarksByCourseName
    {
        get { return this.marksByCourseName; }
    }

    public void EnrollInCourse(ICourse course)
    {
        if (this.enrollerCourses.ContainsKey(course.Name))
        {
            throw new DuplicateEntryInStructureException(this.name, course.Name);
        }

        this.enrollerCourses.Add(course.Name, course);
    }

    public void SetMarksInCourse(string courseName, params int[] scores)
    {
        if (!this.enrollerCourses.ContainsKey(courseName))
        {
            throw new NotEnrolledInCourseException();
        }

        if (scores.Length > Course.NumberOfTasksOnExam)
        {
            throw new InvalidNumberOfScoresException();
        }

        this.marksByCourseName.Add(courseName, Calculatemark(scores));
    }

    private double Calculatemark(int[] scores)
    {
        double percentageOfSolvedExam = scores.Sum() / (double)(Course.NumberOfTasksOnExam * Course.MaxScoreOnExamTask);
        double mark = percentageOfSolvedExam * 4 + 2;
        return mark;
    }

    public int CompareTo(IStudent other)
    {
        return this.Name.CompareTo(other.Name);
    }

    public override string ToString()
    {
        return this.Name;
    }
}