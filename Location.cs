public class Location
{
    public int ID;

    public string Name;

    public string Description;

    public Location? LocationToNorth;

    public Location? LocationToEast;

    public Location? LocationToSouth;

    public Location? LocationToWest;

    public Quest QuestAvailableHere;

    public Monster MonsterLivingHere;

    public Location(int id, string name, string description, Quest quest, Monster monster)
    {
        ID = id;
        Name = name;
        Description = description;
        QuestAvailableHere = quest;
        MonsterLivingHere = monster;
    }

    public bool CheckIsNeighbor(Location location)
    {
        return location.ID switch
        {
            var x when x == LocationToNorth?.ID => true,
            var x when x == LocationToEast?.ID => true,
            var x when x == LocationToSouth?.ID => true,
            var x when x == LocationToWest?.ID => true,
            _ => false,
        };
    } 

}