using BashSoft.Contracts;
using BashSoft.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BashSoft
{
    public class RepositorySorter : IDataSorter
    {
        public void OrderAndTake(Dictionary<string, double> studentsWithMarks, string comparison, int studentsToTake)
        {
            comparison = comparison.ToLower();

            if (comparison == "ascending")
            {
                OrderAndTake(studentsWithMarks, studentsToTake, "ascending");
            }
            else if (comparison == "descending")
            {
                OrderAndTake(studentsWithMarks, studentsToTake, "descending");
            }
            else
            {
                throw new InvalidComparisonQueryException();
            }
        }

        private void OrderAndTake(Dictionary<string, double> studentsWithMarks, int studentsToTake, string order)
        {
            if (order == "ascending")
            {
                foreach (var student in studentsWithMarks.OrderBy(s => s.Value).Take(studentsToTake).ToDictionary(x => x.Key, x => x.Value))
                {
                    OutputWriter.PrintStudent(new KeyValuePair<string, double>(student.Key, student.Value));
                }
            }
            else if (order == "descending")
            {
                foreach (var student in studentsWithMarks.OrderByDescending(s => s.Value).Take(studentsToTake).ToDictionary(x => x.Key, x => x.Value))
                {
                    OutputWriter.PrintStudent(new KeyValuePair<string, double>(student.Key, student.Value));
                }
            }
        }

        private Dictionary<string, List<int>> GetSortedStudents(Dictionary<string, List<int>> studentsWanter,
            int takeCount, Func<KeyValuePair<string, List<int>>, KeyValuePair<string, List<int>>, int> Comparison)
        {
            int valuesTaken = 0;
            var studentsSorted = new Dictionary<string, List<int>>();
            var nextInOrder = new KeyValuePair<string, List<int>>();
            bool isSorted = true;

            while (valuesTaken < takeCount)
            {
                isSorted = true;

                foreach (var studentWithScore in studentsWanter)
                {
                    if (!string.IsNullOrEmpty(nextInOrder.Key))
                    {
                        int comparisonResult = Comparison(studentWithScore, nextInOrder);

                        if (comparisonResult >= 0 && !studentsSorted.ContainsKey(studentWithScore.Key))
                        {
                            nextInOrder = studentWithScore;
                            isSorted = false;
                        }
                    }
                    else
                    {
                        if (!studentsSorted.ContainsKey(studentWithScore.Key))
                        {
                            nextInOrder = studentWithScore;
                            isSorted = false;
                        }
                    }
                }

                if (!isSorted)
                {
                    studentsSorted.Add(nextInOrder.Key, nextInOrder.Value);
                    nextInOrder = new KeyValuePair<string, List<int>>();
                }

                valuesTaken++;
            }

            return studentsSorted;
        }
    }
}