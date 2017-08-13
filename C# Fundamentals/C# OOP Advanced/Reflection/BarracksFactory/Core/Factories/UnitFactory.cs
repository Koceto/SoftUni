using BarracksFactory.Contracts;
using BarracksFactory.Models.Units;
using System;
using System.Linq;
using System.Reflection;

namespace BarracksFactory.Core.Factories
{
    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type classType = assembly.GetTypes().First(t => t.Name.StartsWith(unitType));

            return (IUnit)Activator.CreateInstance(classType);
        }
    }
}