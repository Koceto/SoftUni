using Work_Force.Interfaces;
using Work_Force.Models;

namespace Work_Force.Entities
{
    public class PartTimeEmployee : Emploee, IEmploee
    {
        public PartTimeEmployee(string name)
            : base(name)
        {
            this.WorkHoursPerWeek = 20;
        }
    }
}