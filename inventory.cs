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
}