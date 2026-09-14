public class Armour
{
    public int ID;
    public string Name;
    public int Defense;
    public string Rarity;

    public Armour(int id, string name, int defense)
    {
        ID = id;
        Name = name;
        Defense = defense;
        Rarity = (id) switch
        {
            <= 2 => "Common",
            <= 3 => "Rare",
            <= 5 => "Epic",
            <= 6 => "Legendary",
        };
    }
}