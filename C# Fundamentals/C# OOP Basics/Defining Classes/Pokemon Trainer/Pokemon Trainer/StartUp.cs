using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Trainer
{
    public class StartUp
    {
        public static void Main()
        {
            List<Trainer> listOfTrainers = new List<Trainer>();
            List<Pokemon> listOfPokemons = new List<Pokemon>();
            string input;

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] data = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string trainerName = data[0];
                string pokemonName = data[1];
                string element = data[2];
                int health = int.Parse(data[3]);

                Pokemon pokemon = listOfPokemons.FirstOrDefault(p => p.Name == pokemonName);

                if (pokemon == null)
                {
                    pokemon = new Pokemon(pokemonName, element, health);
                    listOfPokemons.Add(pokemon);
                }

                Trainer trainer = listOfTrainers.FirstOrDefault(t => t.Name == trainerName);

                if (trainer == null)
                {
                    listOfTrainers.Add(new Trainer(trainerName, pokemon));
                }
                else
                {
                    trainer.AddPokemon(pokemon);
                }
            }

            string type;

            while ((type = Console.ReadLine()) != "End")
            {
                foreach (var trainer in listOfTrainers)
                {
                    if (trainer.Pokemons.All(p => p.Element != type))
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            Pokemon pokemon = trainer.Pokemons[i];

                            if (pokemon.Health - 10 <= 0)
                            {
                                trainer.Pokemons.Remove(pokemon);
                                i--;
                                continue;
                            }
                            pokemon.Health -= 10;
                        }
                        continue;
                    }
                    trainer.Badges++;
                }
            }

            foreach (var trainer in listOfTrainers.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}