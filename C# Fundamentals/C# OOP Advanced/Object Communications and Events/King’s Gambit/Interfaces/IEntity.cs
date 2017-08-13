namespace King_s_Gambit.Interfaces
{
    public interface IEntity
    {
        string Name { get; }

        int Health { get; }

        void OnKingUnderAttack();

        void HitTaken();
    }
}