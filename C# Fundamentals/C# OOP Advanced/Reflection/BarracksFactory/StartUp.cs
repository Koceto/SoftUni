using BarracksFactory.Contracts;
using BarracksFactory.Core;
using BarracksFactory.Core.Factories;
using BarracksFactory.Data;

namespace BarracksFactory
{
    internal class StartUp
    {
        private static void Main()
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            IRunnable engine = new Engine(repository, unitFactory);
            engine.Run();
        }
    }
}