namespace Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class DragonInfo
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }
    }

    public class NetherRealms
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var digitRegex = new Regex(@"[-|+]*[0.0-9]+");
            var charRegex = new Regex(@"[^\d\.\-\+\*\/]");
            var specialChars = new Regex(@"(\*|\/)");
            var dragons = new List<DragonInfo>();

            foreach (var demon in input)
            {
                var health = 0;
                var damage = 0.0;
                var chars = charRegex.Matches(demon);
                var digits = digitRegex.Matches(demon);
                var specials = specialChars.Matches(demon);
                var currDragon = new DragonInfo
                {
                    Name = demon,
                    Health = health,
                    Damage = damage
                };

                foreach (var item in chars)
                {
                    var temp = item.ToString();
                    currDragon.Health += temp[0];
                }
                foreach (var item in digits)
                {
                    currDragon.Damage += double.Parse(item.ToString());
                }
                foreach (var item in specials)
                {
                    var temp = item.ToString();

                    if (temp[0] == '*')
                    {
                        currDragon.Damage *= 2;
                    }
                    else
                    {
                        currDragon.Damage /= 2;
                    }
                }
                dragons.Add(currDragon);
            }
            foreach (var dragon in dragons.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{dragon.Name} - {dragon.Health} health, {dragon.Damage:f2} damage ");
            }
        }
    }
}
