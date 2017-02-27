using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_4
{
    public class Legion
    {
        public string Name { get; set; }

        public long Activity { get; set; }

        public List<Soldier> Soldiers { get; set; }
    }
    public class Soldier
    {

        public string SName { get; set; }

        public long SCount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var legion = new List<Legion>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var indexToSplit = input.IndexOf(" -> ");
                var activityAndLegion = input
                    .Substring(0, indexToSplit)
                    .Split(new[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var soldierTypeAndCount = input
                    .Substring(indexToSplit + 4, input.Length - (indexToSplit + 4))
                    .Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currLegionName = activityAndLegion.Last();
                var currLegionActivity = activityAndLegion.First();

                var currSoldierName = soldierTypeAndCount.First();
                var currSoldierCount = soldierTypeAndCount.Last();

                if (legion.All(l => l.Name != currLegionName))
                {
                    legion.Add(new Legion
                    {
                        Activity = int.Parse(currLegionActivity),
                        Name = currLegionName,
                        Soldiers = new List<Soldier>
                        {
                            new Soldier
                            {
                                SCount = int.Parse(currSoldierCount),
                                SName = currSoldierName
                            }
                        }
                    });
                }
                else if (legion.Any(l => l.Name == currLegionName))
                {
                    if (legion.Find(l => l.Name == currLegionName).Soldiers.All(s => s.SName != currSoldierName))
                    {
                        legion.Find(l => l.Name == currLegionName).Soldiers.Add(new Soldier
                        {
                            SName = currSoldierName,
                            SCount = int.Parse(currSoldierCount)
                        });
                    }
                    else if (legion.Find(l => l.Name == currLegionName).Soldiers.Any(s => s.SName == currSoldierName))
                    {
                        legion
                            .Find(l => l.Name == currLegionName)
                            .Soldiers
                            .Find(s => s.SName == currSoldierName)
                            .SCount += int.Parse(currSoldierCount);
                    }

                    if (legion.Find(l => l.Name == currLegionName).Activity < int.Parse(currLegionActivity))
                    {
                        legion.Find(l => l.Name == currLegionName).Activity = int.Parse(currLegionActivity);
                    }
                }
            }
            var outputInfo = Console.ReadLine()
                .Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
            var toPrint = new Dictionary<string, long>();

            if (outputInfo.Length > 1)
            {
                var neededActivity = int.Parse(outputInfo.First());
                var neededSoldier = outputInfo.Last();
                
                foreach (var currLegion in legion)
                {
                    if (currLegion.Activity < neededActivity && currLegion.Soldiers.Any(s => s.SName == neededSoldier))
                    {
                        toPrint.Add(currLegion.Name, currLegion.Soldiers.Find(s => s.SName == neededSoldier).SCount);
                    }
                }
            }
            else
            {
                var neededSoldier = outputInfo.Last();

                foreach (var currLegion in legion.OrderByDescending(l => l.Activity))
                {
                    if (currLegion.Soldiers.Any(s => s.SName == neededSoldier))
                    {
                        Console.WriteLine($"{currLegion.Activity} : {currLegion.Name}");
                    }
                }
            }

            foreach (var kvp in toPrint.OrderByDescending(v => v.Value))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
