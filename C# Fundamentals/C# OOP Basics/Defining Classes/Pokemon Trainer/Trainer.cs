using System.Collections.Generic;

namespace Pokemon_Trainer
{
    public class Trainer
    {
        public Trainer(string name, Pokemon pokemon)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>() { pokemon };
        }

        public string Name { get; set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public void AddPokemon(Pokemon pokemon)
        {
            if (this.Pokemons.Count != 0)
            {
                this.Pokemons.Add(pokemon);
            }
        }
    }
}