using BarracksFactory.Contracts;

namespace BarracksFactory.Core.Commands
{
    public class Add : Command
    {
        public Add(string[] data, IRepository repository, IUnitFactory unitFactory) :
            base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);

            this.Repository.AddUnit(unitToAdd);

            return $"{unitType} added!";
        }
    }
}