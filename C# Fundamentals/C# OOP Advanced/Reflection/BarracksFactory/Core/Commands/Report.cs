using BarracksFactory.Contracts;
using BarracksFactory.Core.Commands;
using System;

namespace BarracksFactory.Core
{
    public class Report : Command
    {
        public Report(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string output = this.Repository.Statistics;

            return output;
        }
    }
}