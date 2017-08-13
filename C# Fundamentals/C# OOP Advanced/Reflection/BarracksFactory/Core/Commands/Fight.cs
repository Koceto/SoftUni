﻿using BarracksFactory.Contracts;
using BarracksFactory.Core.Commands;
using System;

namespace BarracksFactory.Core
{
    public class Fight : Command
    {
        public Fight(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return String.Empty;
        }
    }
}