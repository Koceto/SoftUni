using System;
using System.Linq;
using System.Reflection;

namespace BlackBox
{
    public class StartUp
    {
        public static void Main()
        {
            int number;
            string input;
            Type classType = typeof(BlackBoxInt);
            FieldInfo field = classType.GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic);
            ConstructorInfo constructor = classType.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null);
            BlackBoxInt classInstance = (BlackBoxInt)constructor.Invoke(null);

            while ((input = Console.ReadLine()) != "END")
            {
                string[] commandArgs = input.Split('_');
                string methodName = commandArgs.First();
                number = int.Parse(commandArgs.Last());

                MethodInfo method = classType.GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);

                method.Invoke(classInstance, new object[] { number });

                Console.WriteLine(field.GetValue(classInstance));
            }
        }
    }
}