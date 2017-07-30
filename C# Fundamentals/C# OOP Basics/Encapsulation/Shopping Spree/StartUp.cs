using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Spree
{
    public class StartUp
    {
        public static void Main()
        {
            string[] peopleInput = Console.ReadLine()
                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] productsInput = Console.ReadLine()
                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                foreach (var p in peopleInput)
                {
                    string[] personInfo = p.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    people.Add(new Person(personInfo[0], int.Parse(personInfo[1])));
                }

                foreach (var p in productsInput)
                {
                    string[] productInfo = p.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    products.Add(new Product(productInfo[0], int.Parse(productInfo[1])));
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] info = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Person person = people.FirstOrDefault(p => p.Name == info[0]);
                Product product = products.FirstOrDefault(p => p.Name == info[1]);

                try
                {
                    person.Buy(product);
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            PrintBags(people);
        }

        private static void PrintBags(List<Person> people)
        {
            foreach (var person in people)
            {
                if (person.Bag.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag.Select(b => b.Name))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}