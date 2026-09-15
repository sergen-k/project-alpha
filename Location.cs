public class Location
{
    public int ID;

    public string Name;

    public Quest? QuestAvailableHere;

    public Monster? MonsterLivingHere;
    public Shop? ShopHere;
    public string SurroundingHere;

    public Location? LocationToNorth;

    public Location? LocationToEast;

    public Location? LocationToSouth;

    public Location? LocationToWest;


    public Location(int id, string name, Quest quest, Monster monster, Shop shop)
    {
        ID = id;
        Name = name;
        QuestAvailableHere = quest;
        MonsterLivingHere = monster;
        ShopHere = shop;
    }

    public void AddSurrounding(string surrounding)
    {
        SurroundingHere = surrounding;
    }

    public void CheckSurroundings()
    {
        Program.Refresh();
        Console.WriteLine("You see, stuff! (WIP)");
        World.Continue();
        while (true)
        {
            // TODO - add surroundings for each area
            Program.Refresh();
            Console.WriteLine($"{World.GREEN}---Surroundings---{World.RESET}");
            Console.WriteLine($"{World.BLUE}1.{World.RED} RETURN{World.RESET}");
            List<string> Options = ["1"];
            if (MonsterLivingHere != null)
            {
                Console.WriteLine($"{World.BLUE}B.{World.RESET} Battle Monster{World.RESET}");
                Options.Add("b");
            }
            if (QuestAvailableHere != null)
            {
                Console.WriteLine($"{World.BLUE}Q. {World.RESET}Check Quest");
                Options.Add("q");
            }
            if (ShopHere != null)
            {
                Console.WriteLine($"{World.BLUE}S. {World.RESET}Enter {ShopHere.Name}'s Shop");
                Options.Add("s");
            }
            if (Options.Count == 1)
            {
                return;
            }
            
            string option = World.ChooseOption(Options.ToArray());
            if (option == "1")
                return;
            else if (option == "b")
            {
                Program.Refresh();
                Battle.StartBattle(MonsterLivingHere);
            }
            else if (option == "q")
            {
                Program.Refresh();
                    if (QuestAvailableHere.status == QuestStatus.pending)
                    {
                        if (QuestAvailableHere.AcceptOrDenyQuest() == 1)
                        {
                            Program.Player.CurrentQuest = QuestAvailableHere;
                        }
                    }
                    else if (QuestAvailableHere.status == QuestStatus.accepted)
                    {
                        Console.WriteLine($"{World.RED}Quest has NOT been finished yet.{World.RESET}");
                        World.Continue();
                    }
                    else if (QuestAvailableHere.status == QuestStatus.finished)
                    {
                        QuestAvailableHere.FinishQuest();
                        QuestAvailableHere = null;
                        World.Continue();
                    }
                        
            }
            else if (option == "s")
            {
                Program.Refresh();
                ShopHere.CheckShop();
            }

            
        }

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
            result.Add(("North", LocationToNorth));
        }

        if (LocationToEast is not null)
        {
            result.Add(("East", LocationToEast));
        }

        if (LocationToSouth is not null)
        {
            result.Add(("South", LocationToSouth));
        }

        if (LocationToWest is not null)
        {
            result.Add(("West", LocationToWest));
        }

        return result;
    }
}