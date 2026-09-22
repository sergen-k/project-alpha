public class Weapon
{
    public int ID;
    public string Name;
    public int MaximumDamage;
    public string MoveName;
    public string Rarity;
    public int Quality = 50;
    public int CurrentDamage;

    public Weapon(int id, string name, string moveName, int maximumDamage)
    {
        ID = id;
        Name = name;
        MoveName = moveName;
        MaximumDamage = maximumDamage;
        CurrentDamage = (int)(maximumDamage*0.5);
        Rarity = id switch
        {
            <= 3 => "Common",
            <= 6 => "Rare",
            <= 9 => "Epic",
            <= 12 => "Legendary",
            <= 15 => "Mythic"
        };
    }

    public Weapon(Weapon weapon) : this(weapon.ID, weapon.Name, weapon.MoveName, weapon.MaximumDamage)
    {}

    public void SetQuality()
    {
        Quality = World.RandomGenerator.Next(70,101);
        CurrentDamage = Quality*MaximumDamage/100;
    }
}