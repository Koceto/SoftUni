﻿using BashSoft.Attributes;
using BashSoft.Contracts;

namespace BashSoft.IO.Commands
{
    [Alias("readdb")]
    public class ReadDatabaseCommand : Command
    {
        [Inject]
        private IDatabase repository;

        public ReadDatabaseCommand(string input, string[] data)
            : base(input, data)
        {
        }

        public override void Execute()
        {
            string fileName = this.Data[1];
            this.repository.LoadData(fileName);
        }
    }
}