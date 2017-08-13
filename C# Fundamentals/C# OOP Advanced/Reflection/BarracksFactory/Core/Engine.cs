using BarracksFactory.Contracts;
using BarracksFactory.Core.Commands;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace BarracksFactory.Core
{
    public class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;
        private Assembly assembly;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
            this.assembly = Assembly.GetExecutingAssembly();
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private string InterpredCommand(string[] data, string commandName)
        {
            Type classType = assembly.GetTypes().FirstOrDefault(t => t.Name.StartsWith(commandName, true, CultureInfo.InvariantCulture));

            if (classType == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }

            Command classInstance = (Command)Activator.CreateInstance(classType, data, this.repository, this.unitFactory);

            return classInstance.Execute();
        }
    }
}