public class Potion
{
    public int ID;
    public string Name;
    public string PotionDesc;
    public int Count = 0;
    public string Status;

    public Potion(int id, string name, string potionDesc, string status)
    {
        ID = id;
        Name = name;
        PotionDesc = potionDesc;
        Status = status;
    }
}