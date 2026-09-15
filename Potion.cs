public class Potion
{
    public int ID;
    public string Name;
    public string PotionDesc;
    public int Count = 0;
    public string Status;
    public int HealAmount;

    public Potion(int id, string name, string potionDesc, string status, int healAmount)
    {
        ID = id;
        Name = name;
        PotionDesc = potionDesc;
        Status = status;
        HealAmount = healAmount;
    }
}