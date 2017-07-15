using System;

namespace Date_Modifier
{
    public class DateModifier
    {
        private int difference;

        public DateModifier(string firstInputLine, string secondInputLine)
        {
            DateTime first = Convert.ToDateTime(firstInputLine);
            DateTime second = Convert.ToDateTime(secondInputLine);

            this.Difference = Math.Abs((int)(first - second).TotalDays);
        }

        public int Difference
        {
            get { return difference; }
            set { this.difference = value; }
        }
    }
}