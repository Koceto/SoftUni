using System.Collections.Generic;

public interface IWeapon
{
    string Name { get; }
    int MinDamage { get; }
    int MaxDamage { get; }
    object Quality { get; }
}