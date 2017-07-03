using System;
using System.Collections.Generic;
using System.Linq;

namespace Family_Tree
{
    internal class StartUp
    {
        private static void Main()
        {
            string personInfo = Console.ReadLine().Trim();
            List<Person> family = new List<Person>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                Person parent;
                Person child;

                if (data.Length < 2) // Single person information
                {
                    data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string name = string.Join(" ", data.Take(2));
                    string date = data[2];

                    Person personByName = family.FirstOrDefault(p => p.Name == name);
                    Person personByBirthDate = family.FirstOrDefault(p => p.BirthDate == date);

                    Person newPerson = new Person()
                    {
                        Name = name,
                        BirthDate = date
                    };

                    if (personByName != null)
                    {
                        newPerson.Concat(personByName);
                        family.Remove(personByName);
                    }

                    if (personByBirthDate != null)
                    {
                        newPerson.Concat(personByBirthDate);
                        family.Remove(personByBirthDate);
                    }

                    family.Add(newPerson);
                }
                else // Parent - Child information
                {
                    string parentInfo = data[0].Trim();
                    string childInfo = data[1].Trim();

                    if (Char.IsDigit(parentInfo[0]) && Char.IsDigit(childInfo[0])) // Date - Date information
                    {
                        parent = family.FirstOrDefault(p => p.BirthDate == parentInfo);
                        child = family.FirstOrDefault(p => p.BirthDate == childInfo);

                        if (parent == null)
                        {
                            parent = new Person() { BirthDate = parentInfo };
                            family.Add(parent);
                        }

                        if (child == null)
                        {
                            child = new Person() { BirthDate = childInfo };
                            family.Add(child);
                        }

                        parent.Children.Add(child);
                        child.Parents.Add(parent);
                    }
                    else if (Char.IsDigit(parentInfo[0]) && !Char.IsDigit(childInfo[0])) // Date - Name information
                    {
                        parent = family.FirstOrDefault(p => p.BirthDate == parentInfo);
                        child = family.FirstOrDefault(p => p.Name == childInfo);

                        if (parent == null)
                        {
                            parent = new Person() { BirthDate = parentInfo };
                            family.Add(parent);
                        }

                        if (child == null)
                        {
                            child = new Person() { Name = childInfo };
                            family.Add(child);
                        }

                        parent.Children.Add(child);
                        child.Parents.Add(parent);
                    }
                    else if (!Char.IsDigit(parentInfo[0]) && Char.IsDigit(childInfo[0])) // Name - Date information
                    {
                        parent = family.FirstOrDefault(p => p.Name == parentInfo);
                        child = family.FirstOrDefault(p => p.BirthDate == childInfo);

                        if (parent == null)
                        {
                            parent = new Person() { Name = parentInfo };
                            family.Add(parent);
                        }

                        if (child == null)
                        {
                            child = new Person() { BirthDate = childInfo };
                            family.Add(child);
                        }

                        parent.Children.Add(child);
                        child.Parents.Add(parent);
                    }
                    else // name - Name information
                    {
                        parent = family.FirstOrDefault(p => p.Name == parentInfo);
                        child = family.FirstOrDefault(p => p.Name == childInfo);

                        if (parent == null)
                        {
                            parent = new Person() { Name = parentInfo };
                            family.Add(parent);
                        }

                        if (child == null)
                        {
                            child = new Person() { Name = childInfo };
                            family.Add(child);
                        }

                        parent.Children.Add(child);
                        child.Parents.Add(parent);
                    }
                }
            }

            Console.WriteLine(family.First(p => p.Name == personInfo || p.BirthDate == personInfo));
        }
    }
}