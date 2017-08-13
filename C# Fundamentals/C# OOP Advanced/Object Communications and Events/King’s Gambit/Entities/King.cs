using System;

namespace King_s_Gambit.Models
{
    public delegate void KindUnderAttackEventHandler();

    public class King
    {
        public event KindUnderAttackEventHandler UnderAttack;

        public King(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public void Attack()
        {
            Console.WriteLine($"King {this.Name} is under attack!");
            this.OnKingUnderAttack();
        }

        public void OnKingUnderAttack()
        {
            if (this.UnderAttack != null)
            {
                this.UnderAttack();
            }
        }
    }
}