public class InventoryManager
{
    public List<Weapon> Weapons = new List<Weapon>();
    public List<Armour> Armours = new List<Armour>();
    public List<Potion> Potions = new List<Potion>();

    public void AddWeapon(Weapon weapon)
    {
        Weapons.Add(weapon);
        Console.WriteLine(weapon.Name + " added to inventory.");
    }

    public void AddArmour(Armour armour)
    {
        Armours.Add(armour);
        Console.WriteLine(armour.Name + " added to inventory.");
    }

    public void AddPotion(Potion potion)
    {
        Potions.Add(potion);
        Console.WriteLine(potion.Name + " added to inventory.");
    }

    public void ViewInventory()
    {
        Console.WriteLine("Weapons:");
        foreach (var weapon in Weapons)
            Console.WriteLine("- " + weapon.Name + " (Damage: " + weapon.MaximumDamage + ")");

        Console.WriteLine("Armour:");
        foreach (var armour in Armours)
            Console.WriteLine("- " + armour.Name + " (Defense: " + armour.Defense + ")");

        Console.WriteLine("Potions:");
        foreach (var potion in Potions)
            Console.WriteLine("- " + potion.Name + " (" + potion.PotionType + ")");
    }

    // Switch active weapon - only allowed outside of battle
    public void SwitchWeapon(Weapon weapon, Player player)
    {
        if (player.IsFighting)
        {
            Console.WriteLine("You cannot switch weapons during battle.");
            return;
        }

        if (Weapons.Contains(weapon))
        {
            player.CurrentWeapon = weapon;
            Console.WriteLine("Switched weapon to " + weapon.Name);
        }
    }

    // Use a potion - heal potions work anytime, damage potions only in battle
    public void UsePotion(Potion potion, Player player)
    {
        if (!Potions.Contains(potion))
        {
            Console.WriteLine("You don't have that potion.");
            return;
        }

        if (potion.PotionType == "heal")
        {
            player.Heal(potion.Amount); // reuse Player's existing method
            Potions.Remove(potion);
            Console.WriteLine("Used potion: " + potion.Name);
        }
        else if (potion.PotionType == "damage")
        {
            if (!player.IsFighting)
            {
                Console.WriteLine("You can only use this potion during battle.");
                return;
            }

            // TODO: apply actual damage boost - depends on how Battle.cs tracks bonus damage
            Potions.Remove(potion);
            Console.WriteLine("Used potion: " + potion.Name + " (damage boost applied)");
        }
    }
}