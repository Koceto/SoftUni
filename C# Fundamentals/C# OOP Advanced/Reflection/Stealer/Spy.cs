using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string name, params string[] names)
    {
        StringBuilder info = new StringBuilder();
        Type classType = Type.GetType(name);
        Object classInstance = Activator.CreateInstance(classType);
        FieldInfo[] fields = classType.
            GetFields(
                BindingFlags.NonPublic |
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.Static
            );

        info.AppendLine($"Class under investigation: {name}");

        foreach (var field in fields.Where(f => names.Any(n => f.Name == n)))
        {
            info.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return info.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        StringBuilder misstakes = new StringBuilder();
        Type classType = Type.GetType(className);

        MethodInfo[] methods = classType.GetMethods(
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance |
            BindingFlags.Static);

        FieldInfo[] fields = classType.GetFields(
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance |
            BindingFlags.Static
        );

        foreach (FieldInfo field in fields)
        {
            if (field.IsPublic)
            {
                misstakes.AppendLine($"{field.Name} must be private!");
            }
        }

        foreach (MethodInfo method in methods)
        {
            if (method.Name.StartsWith("set") && method.IsPublic)
            {
                misstakes.AppendLine($"{method.Name} have to be private!");
            }

            if (method.Name.StartsWith("get") && !method.IsPublic)
            {
                misstakes.AppendLine($"{method.Name} have to be public!");
            }
        }

        return misstakes.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        StringBuilder information = new StringBuilder();
        Type classType = Type.GetType(className);
        MethodInfo[] methods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

        information.AppendLine($"All Private Methods of Class: {className}")
                   .AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (MethodInfo method in methods)
        {
            information.AppendLine(method.Name);
        }

        return information.ToString().Trim();
    }

    public string CollectGettersAndSetters(string className)
    {
        StringBuilder information = new StringBuilder();
        Type classType = Type.GetType(className);
        MethodInfo[] methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

        foreach (MethodInfo method in methods.Where(m => m.Name.StartsWith("get")))
        {
            information.AppendLine($"{method.Name} will return {method.ReturnType}");
        }

        foreach (MethodInfo method in methods.Where(m => m.Name.StartsWith("set")))
        {
            information.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return information.ToString().Trim();
    }
}