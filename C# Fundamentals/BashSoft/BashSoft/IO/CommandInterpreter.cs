using BashSoft.Attributes;
using BashSoft.Contracts;
using BashSoft.IO.Commands;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace BashSoft
{
    public class CommandInterpreter : IInterpreter
    {
        private IContentComparer judge;
        private IDatabase repository;
        private IDirectoryManager inputOutputManager;

        public CommandInterpreter(IContentComparer judge, IDatabase repository, IDirectoryManager inputOutputManager)
        {
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManager;
        }

        public void InterpredCommand(string input)

        {
            string[] data = input.Split(' ');
            string cmd = data[0].ToLower();

            try
            {
                IExecutable command = this.ParseCommand(input, cmd, data);
                command.Execute();
            }
            catch (DirectoryNotFoundException dnfe)
            {
                OutputWriter.DisplayException(dnfe.Message);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                OutputWriter.DisplayException(aoore.Message);
            }
            catch (ArgumentException ae)
            {
                OutputWriter.DisplayException(ae.Message);
            }
            catch (Exception e)
            {
                OutputWriter.DisplayException(e.Message);
            }
        }

        private IExecutable ParseCommand(string input, string command, string[] data)
        {
            object[] parametersForConstruction = new object[]
            {
                input,
                data
            };

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type commandClassType = assembly
                .GetTypes()
                .First(t => t.GetCustomAttributes(typeof(AliasAttribute))
                .Where(a => a.Equals(command))
                .ToArray()
                .Length > 0);
            Type interpreterClassType = typeof(CommandInterpreter);
            Command executableCommand = Activator.CreateInstance(commandClassType, parametersForConstruction) as Command;
            FieldInfo[] fieldsOfCommand = commandClassType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo[] fieldsOfInterpreter = interpreterClassType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo fieldOfCommand in fieldsOfCommand)
            {
                Attribute attribute = fieldOfCommand.GetCustomAttribute(typeof(InjectAttribute));

                if (attribute != null)
                {
                    if (fieldsOfInterpreter.Any(x => x.FieldType == fieldOfCommand.FieldType))
                    {
                        fieldOfCommand.SetValue(executableCommand, fieldsOfInterpreter.First(x => x.FieldType == fieldOfCommand.FieldType).GetValue(this));
                    }
                }
            }

            return executableCommand;
        }
    }
}