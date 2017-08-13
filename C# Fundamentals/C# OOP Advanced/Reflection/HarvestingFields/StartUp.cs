using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HarestingFields
{
    public class StartUp
    {
        public static void Main()
        {
            string input;
            Type classType = typeof(RichSoilLand);
            List<string> fieldsToPrint = new List<string>();
            FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static |
                                                        BindingFlags.NonPublic | BindingFlags.Public);

            while ((input = Console.ReadLine()) != "HARVEST")
            {
                switch (input)
                {
                    case "private":
                        fieldsToPrint.AddRange(fields.Where(f => f.IsPrivate).Select(f => $"{GetAccesModifier(f)} {f.FieldType.Name} {f.Name}"));
                        break;

                    case "public":
                        fieldsToPrint.AddRange(fields.Where(f => f.IsPublic).Select(f => $"{GetAccesModifier(f)} {f.FieldType.Name} {f.Name}"));
                        break;

                    case "protected":
                        fieldsToPrint.AddRange(fields.Where(f => f.IsFamily).Select(f => $"{GetAccesModifier(f)} {f.FieldType.Name} {f.Name}"));
                        break;

                    case "all":
                        fieldsToPrint.AddRange(fields.Select(f => $"{GetAccesModifier(f)} {f.FieldType.Name} {f.Name}"));
                        break;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, fieldsToPrint));
        }

        private static string GetAccesModifier(FieldInfo field)
        {
            if (field.IsFamily)
            {
                return "protected";
            }

            return field.Attributes.ToString().ToLower();
        }
    }
}