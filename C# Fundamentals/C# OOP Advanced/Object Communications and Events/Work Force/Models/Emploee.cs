namespace Work_Force.Models
{
    public abstract class Emploee
    {
        public Emploee(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public int WorkHoursPerWeek { get; protected set; }
    }
}