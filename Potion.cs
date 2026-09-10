public class Potion
{
    public int ID;
    public string Name;
    public string PotionType; // "heal" or "damage"
    public int Amount;

    public Potion(int id, string name, string potionType, int amount)
    {
        ID = id;
        Name = name;
        PotionType = potionType;
        Amount = amount;
    }
}