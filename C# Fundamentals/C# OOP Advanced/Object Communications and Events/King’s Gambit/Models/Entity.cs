using King_s_Gambit.Interfaces;

namespace King_s_Gambit.Models
{
    public delegate void OnEntityDeathEventHandler(IEntity entity);

    public abstract class Entity : IEntity
    {
        public OnEntityDeathEventHandler EntityDeath;

        public Entity(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public int Health { get; protected set; }

        public abstract void OnKingUnderAttack();

        public void HitTaken()
        {
            this.Health--;

            if (this.Health <= 0)
            {
                this.Died();
            }
        }

        private void Died()
        {
            if (this.EntityDeath != null)
            {
                this.EntityDeath(this);
            }
        }
    }
}