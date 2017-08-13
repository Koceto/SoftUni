using BarracksFactory.Contracts;

namespace BarracksFactory.Core.Commands
{
    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IUnitFactory unitFactory;

        protected Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            this.Data = data;
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }

        public IUnitFactory UnitFactory
        {
            get { return this.unitFactory; }
            set { this.unitFactory = value; }
        }

        public IRepository Repository
        {
            get { return this.repository; }
            set { this.repository = value; }
        }

        public string[] Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public abstract string Execute();
    }
}