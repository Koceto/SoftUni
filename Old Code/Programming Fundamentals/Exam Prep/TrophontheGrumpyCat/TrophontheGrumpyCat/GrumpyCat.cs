namespace TrophontheGrumpyCat
{
    using System;
    using System.Linq;

    public class BiggerDamage
    {
        public string Side { get; set; }

        public long Damage { get; set; }
    }

    public class GrumpyCat
    {
        public static long EP { get; private set; }

        public static void Main()
        {
            var priceRatings = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            var entryPoint = long.Parse(Console.ReadLine());
            var itemsToBreak = Console.ReadLine();
            var typeOfRatings = Console.ReadLine();

            var damageDone = BreakItems(priceRatings, entryPoint, itemsToBreak, typeOfRatings);

            Console.WriteLine($"{damageDone.Side} - {damageDone.Damage}");
        }

        public static BiggerDamage BreakItems(long[] priceRatings, long entryPoint, string itemsToBreak, string typeOfRatings)
        {
            var result = new BiggerDamage();
            var leftDamage = default(long);
            var rightDamage = default(long);
            var PRatEP = priceRatings[entryPoint];

            for (int i = 0; i < priceRatings.Length; i++)
            {
                var currDamageIndex = priceRatings[i];

                if (typeOfRatings == "positive" && currDamageIndex > 0)
                {
                    if (itemsToBreak == "expensive" && currDamageIndex >= PRatEP)
                    {
                        if (i < entryPoint)
                        {
                            leftDamage += currDamageIndex;
                        }
                        else if (i > entryPoint)
                        {
                            rightDamage += currDamageIndex;
                        }
                    }
                    else if (itemsToBreak == "cheap" && currDamageIndex < PRatEP)
                    {
                        if (i < entryPoint)
                        {
                            leftDamage += currDamageIndex;
                        }
                        else if (i > entryPoint)
                        {
                            rightDamage += currDamageIndex;
                        }
                    }
                }
                else if (typeOfRatings == "negative" && currDamageIndex < 0)
                {
                    if (itemsToBreak == "expensive" && currDamageIndex >= PRatEP)
                    {
                        if (i < entryPoint)
                        {
                            leftDamage += currDamageIndex;
                        }
                        else if (i > entryPoint)
                        {
                            rightDamage += currDamageIndex;
                        }
                    }
                    else if (itemsToBreak == "cheap" && currDamageIndex < PRatEP)
                    {
                        if (i < entryPoint)
                        {
                            leftDamage += currDamageIndex;
                        }
                        else if (i > entryPoint)
                        {
                            rightDamage += currDamageIndex;
                        }
                    }
                }
                else if (typeOfRatings == "all")
                {
                    if (itemsToBreak == "expensive" && currDamageIndex >= priceRatings[entryPoint])
                    {
                        if (i < entryPoint)
                        {
                            leftDamage += currDamageIndex;
                        }
                        else if (i > entryPoint)
                        {
                            rightDamage += currDamageIndex;
                        }
                    }
                    else if (itemsToBreak == "cheap" && currDamageIndex < PRatEP)
                    {
                        if (i < entryPoint)
                        {
                            leftDamage += currDamageIndex;
                        }
                        else if (i > entryPoint)
                        {
                            rightDamage += currDamageIndex;
                        }
                    }
                }

            }

            if (leftDamage >= rightDamage)
            {
                result.Damage = leftDamage;
                result.Side = "Left";
            }
            else
            {
                result.Damage = rightDamage;
                result.Side = "Right";
            }

            return result;
        }
    }
}
