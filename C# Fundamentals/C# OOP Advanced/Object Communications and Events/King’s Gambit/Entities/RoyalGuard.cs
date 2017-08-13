using System;

namespace King_s_Gambit.Models
{
    public class RoyalGuard : Entity
    {
        public RoyalGuard(string name)
            : base(name)
        {
            this.Health = 3;
        }

        public override void OnKingUnderAttack()
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}