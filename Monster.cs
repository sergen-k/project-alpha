public class Monster
{
    public int ID;
    public string Name;
    public int MaximumDamage;
    public int MaximumHitPoints;
    
    public int CurrentHitPoints;
    public int GoldDrop;
    public string LootboxRarity;
    public int LootboxChance;

    public Monster(int id, string name, int maximumDamage, int maximumHitPoints, int goldDrop, string lootboxRarity, int lootboxChance)
    {
        ID = id;
        Name = name;
        MaximumDamage = maximumDamage;
        MaximumHitPoints = maximumHitPoints;
        CurrentHitPoints = maximumHitPoints;
        GoldDrop = goldDrop;
        LootboxRarity = lootboxRarity;
        LootboxChance = lootboxChance;
    }
}
