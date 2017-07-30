public class WeaponFactory
{
    public Weapon Create(string weapon, string name)
    {
        Weapon newWeapon = null;
        string[] weaponInfo = weapon.Split(' ');
        string quality = weaponInfo[0];
        string type = weaponInfo[1];

        switch (type.ToLower())
        {
            case "axe":
                newWeapon = new Axe(name, quality);
                break;

            case "sword":
                newWeapon = new Sword(name, quality);
                break;

            case "knife":
                newWeapon = new Knife(name, quality);
                break;
        }

        return newWeapon;
    }
}