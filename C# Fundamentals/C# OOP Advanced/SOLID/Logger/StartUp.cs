using Logger.Interfaces;
using Logger.Interfaces.IO;
using Logger.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Logger
{
    public class StartUp
    {
        public static void Main()
        {
            List<LogWriter> loggers = new List<LogWriter>();
            bool recordAll = false;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input.Length < 3)
                {
                    recordAll = true;
                }

                Assembly assembly = Assembly.GetExecutingAssembly();
                Type appenderType = assembly.GetTypes().First(t => t.Name == input[0]);
                Type layoutType = assembly.GetTypes().First(t => t.Name == input[1]);

                ILayout layout = Activator.CreateInstance(layoutType) as ILayout;
                IWriter writer = Activator.CreateInstance(appenderType, layout) as IWriter;

                LogWriter logger = new LogWriter(writer);

                loggers.Add(logger);
            }

            string message = String.Empty;

            while ((message = Console.ReadLine()) != "END")
            {
                string[] messageArgs = message.Split('|');

                foreach (LogWriter logWriter in loggers)
                {
                    logWriter.Write(messageArgs[1], messageArgs[0], messageArgs[2]);
                }
            }
        }
    }
}