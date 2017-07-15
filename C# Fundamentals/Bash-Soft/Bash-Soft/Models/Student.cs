using System;
using System.Collections.Generic;
using System.Linq;
using Bash_Soft;
using Bash_Soft.Exceptions;

public class Student
{
    private string userName;
    private Dictionary<string, Course> enrollerCourses;
    private Dictionary<string, double> marksByCourseName;

    public Student(string userName)
    {
        this.UserName = userName;
        this.enrollerCourses = new Dictionary<string, Course>();
        this.marksByCourseName = new Dictionary<string, double>();
    }

    public string UserName
    {
        get { return this.userName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new InvalidStringException();
            }
            this.userName = value;
        }
    }

    public IReadOnlyDictionary<string, Course> EnrolledCourses
    {
        get { return this.enrollerCourses; }
    }

    public IReadOnlyDictionary<string, double> MarksByCourseName
    {
        get { return this.marksByCourseName; }
    }

    public void EnrollInCourse(Course course)
    {
        if (this.enrollerCourses.ContainsKey(course.CourseName))
        {
            throw new DuplicateEntryInStructureException(this.userName, course.CourseName);
        }

        this.enrollerCourses.Add(course.CourseName, course);
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
        double percentageOfSolvedExam = scores.Sum() /
                                        (double)(Course.NumberOfTasksOnExam * Course.MaxScoreOnExamTask);
        double mark = percentageOfSolvedExam * 4 + 2;
        return mark;
    }
}