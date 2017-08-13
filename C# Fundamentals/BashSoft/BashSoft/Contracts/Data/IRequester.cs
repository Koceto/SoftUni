using System.Collections.Generic;

namespace BashSoft.Contracts
{
    public interface IRequester
    {
        IReadOnlyDictionary<string, ICourse> Courses { get; }

        void GetAllStudentsFromCourse(string courseName);

        void GetStudentScoresFromCourse(string courseName, string userName);

        ISimpleOrderedBag<ICourse> GetAllCoursesSorted(IComparer<ICourse> comparer);

        ISimpleOrderedBag<IStudent> GetAllStudentsSorted(IComparer<IStudent> comparer);
    }
}