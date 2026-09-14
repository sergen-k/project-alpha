public class Weapon
{
    public int ID;
    public string Name;
    public int MaximumDamage;
    public string MoveName;
    public string Rarity;

    public Weapon(int id, string name, string moveName, int maximumDamage)
    {
        ID = id;
        Name = name;
        MoveName = moveName;
        MaximumDamage = maximumDamage;
        Rarity = (id) switch
        {
            <= 3 => "Common",
            <= 6 => "Rare",
            <= 8 => "Epic",
            <= 10 => "Legendary",
        };
    }
}