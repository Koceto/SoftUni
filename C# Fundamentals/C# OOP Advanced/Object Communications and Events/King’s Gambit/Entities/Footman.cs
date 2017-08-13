using System;

namespace King_s_Gambit.Models
{
    public class Footman : Entity
    {
        public Footman(string name)
            : base(name)
        {
            this.Health = 2;
        }

        public override void OnKingUnderAttack()
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}