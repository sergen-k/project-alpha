public class Location
{
    public int ID;

    public string Name;

    public string Description;

    public Quest? QuestAvailableHere;

    public Monster? MonsterLivingHere;

    public Location? LocationToNorth;

    public Location? LocationToEast;

    public Location? LocationToSouth;

    public Location? LocationToWest;


    public Location(int id, string name, string description, Quest quest, Monster monster)
    {
        ID = id;
        Name = name;
        Description = description;
        QuestAvailableHere = quest;
        MonsterLivingHere = monster;
    }


    /// <summary>
    /// Check if two Location objects are neighbors of each other.
    /// </summary>
    /// <param name="location"></param>
    /// <returns>bool</returns>
    public bool IsNeighbor(Location location)
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


    /// <summary>
    /// Returns a list of Direction, Location pairs of non null neighbors
    /// </summary>
    /// <returns></returns>
    public List<(string, Location)> GetValidNeighbors()
    {
        List<(string, Location)> result = [];

        if (LocationToNorth is not null)
        {
            result.Add(("north", LocationToNorth));
        }

        if (LocationToEast is not null)
        {
            result.Add(("east", LocationToEast));
        }

        if (LocationToSouth is not null)
        {
            result.Add(("south", LocationToSouth));
        }

        if (LocationToWest is not null)
        {
            result.Add(("west", LocationToWest));
        }

        return result;
    }


    public string QuestDescription()
    {
        return Description;
    }

}