using System;

namespace Pizza_Calories
{
    public class StartUp
    {
        public static void Main()
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] info = input.Split(' ');

                try
                {
                    switch (info[0])
                    {
                        case "Dough":
                            Dough dough = new Dough(info[1], info[2], double.Parse(info[3]));

                            Console.WriteLine($"{dough.Calories():f2}");
                            break;

                        case "Topping":
                            Topping topping = new Topping(info[1], double.Parse(info[2]));

                            Console.WriteLine($"{topping.Calories():f2}");
                            break;

                        case "Pizza":
                            PizzaTime(info);
                            break;
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }

        public static void PizzaTime(string[] info)
        {
            int numberToppings = int.Parse(info[2]);
            Pizza pizza = new Pizza(info[1], numberToppings);
            string[] doughInfo = Console.ReadLine().Split(' ');
            Dough dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));

            pizza.Dough = dough;

            for (var i = 0; i < numberToppings; i++)
            {
                var toppingInfo = Console.ReadLine().Split(' ');
                var topping = new Topping(toppingInfo[1], double.Parse(toppingInfo[2]));

                pizza.AddTopping(topping);
            }

            Console.WriteLine(pizza);
        }
    }
}