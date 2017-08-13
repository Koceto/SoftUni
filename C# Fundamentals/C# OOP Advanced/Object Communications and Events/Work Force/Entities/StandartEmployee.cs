using Work_Force.Interfaces;
using Work_Force.Models;

namespace Work_Force.Entities
{
    public class StandartEmployee : Emploee, IEmploee
    {
        public StandartEmployee(string name) 
            : base(name)
        {
            this.WorkHoursPerWeek = 40;
        }
    }
}