using King_s_Gambit.Interfaces;
using King_s_Gambit.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace King_s_Gambit
{
    public class StartUp
    {
        public static King king;
        public static List<IEntity> entities;

        public static void Main()
        {
            string kingName = Console.ReadLine();
            string[] royalGuardsNames = Console.ReadLine()
                .Split(' ');
            string[] footmenNames = Console.ReadLine()
                .Split(' ');

            king = new King(kingName);
            entities = new List<IEntity>();

            foreach (string royalGuardName in royalGuardsNames)
            {
                RoyalGuard guard = new RoyalGuard(royalGuardName);

                guard.EntityDeath += EntityDied;
                entities.Add(guard);
            }

            foreach (var footmanName in footmenNames)
            {
                Footman footman = new Footman(footmanName);

                footman.EntityDeath += EntityDied;
                entities.Add(footman);
            }

            entities.ForEach(s => king.UnderAttack += s.OnKingUnderAttack);

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split(' ');

                if (commandArgs[0].ToLower() == "kill")
                {
                    IEntity entity = entities.FirstOrDefault(e => e.Name == commandArgs[1]);

                    entity.HitTaken();
                }
                else
                {
                    king.Attack();
                }
            }
        }

        public static void EntityDied(IEntity entity)
        {
            entities.Remove(entity);
            king.UnderAttack -= entity.OnKingUnderAttack;
        }
    }
}