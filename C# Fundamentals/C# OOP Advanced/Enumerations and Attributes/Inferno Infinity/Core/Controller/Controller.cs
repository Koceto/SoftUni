using System;
using System.Collections.Generic;
using System.Linq;

public class Controller
{
    private WeaponFactory weaponFactory;
    private GemFactory gemFactory;
    private List<Weapon> weapons;

    public Controller()
    {
        this.weaponFactory = new WeaponFactory();
        this.gemFactory = new GemFactory();
        this.weapons = new List<Weapon>();
    }

    public void CreateWeapon(string weaponInfo, string weaponName)
    {
        try
        {
            Weapon weapon = this.weaponFactory.Create(weaponInfo, weaponName);
            this.weapons.Add(weapon);
        }
        catch (ArgumentException)
        {
        }
    }

    public void Add(string weaponName, int socketIndex, string gemInfo)
    {
        Gem gem = this.gemFactory.Create(gemInfo);
        Weapon weapon = this.weapons.FirstOrDefault(w => w.Name == weaponName);

        try
        {
            weapon.AddSocket(socketIndex, gem);
        }
        catch (IndexOutOfRangeException)
        {
        }
    }

    public void Remove(string weaponName, int socketIndex)
    {
        Weapon weapon = this.weapons.FirstOrDefault(w => w.Name == weaponName);

        try
        {
            weapon.RemoveSocket(socketIndex);
        }
        catch (IndexOutOfRangeException)
        {
        }
    }

    public void Print(string weaponName)
    {
        try
        {
            Weapon weapon = this.weapons.FirstOrDefault(w => w.Name == weaponName);

            Console.WriteLine(weapon);
        }
        catch (NullReferenceException)
        {
        }
    }
}