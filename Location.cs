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

    public bool SeenLocation = false;
    public static bool MurkySwampUnlocked = false;

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
        if (!SeenLocation)
        {
            Console.WriteLine(SurroundingHere);
            SeenLocation = true;
            Console.WriteLine();
            World.Continue();
        }
        while (true)
        {
            // TODO - add surroundings for each area
            Program.Refresh();
            Console.WriteLine($"{World.GREEN}---Surroundings---{World.RESET}");
            Console.WriteLine($"{World.BLUE}1.{World.RED} RETURN{World.RESET}");
            Dictionary<String, String> Options = new()
            {
                {"1","Return"}
            };
            int index = 1;

            if (MonsterLivingHere != null)
            {
                index++;
                Console.WriteLine($"{World.BLUE}{index}.{World.RESET} Battle Monster{World.RESET}");
                Options[$"{index}"] = "Monster";
            }
            if (QuestAvailableHere != null)
            {
                if (QuestAvailableHere.IsQuestUnlocked)
                {
                index++;
                Console.WriteLine($"{World.BLUE}{index}. {World.RESET}Check Quest");
                Options[$"{index}"] = "Quest";
                }
            }
            if (ShopHere != null)
            {  
                if (ShopHere.ShopUnlocked)
                {
                index++;
                Console.WriteLine($"{World.BLUE}{index}. {World.RESET}Enter {ShopHere.Name}'s Shop");
                Options[$"{index}"] = "Shop";
                }
            }
            if (Options.Count == 1)
            {
                return;
            }
            
            string option = World.ChooseOption(Options.Keys.ToArray());
            if (Options[option] == "Return")
                return;
            else if (Options[option] == "Monster")
            {
                Program.Refresh();
                Battle.StartBattle(MonsterLivingHere);
                if (Program.Player.IsDead())
                    return;
            }
            else if (Options[option] == "Quest")
            {
                Program.Refresh();
                    if (QuestAvailableHere.status == QuestStatus.pending)
                    {
                        if (QuestAvailableHere.AcceptOrDenyQuest() == 1)
                        {
                            Program.Player.CurrentQuest = QuestAvailableHere;
                            if (Program.Player.CurrentQuest == World.QuestByID(World.QUEST_ID_THE_WITCH))
                            {
                                Program.Refresh();
                                Battle.StartBattle(World.MonsterByID(World.MONSTER_ID_THE_WITCH));
                                if (Program.Player.IsDead())
                                return;
                                
                            }
                            else if (Program.Player.CurrentQuest == World.QuestByID(World.QUEST_ID_THE_KING))
                            {
                                Program.Refresh();
                                Battle.StartBattle(World.MonsterByID(World.MONSTER_ID_MICHELON));
                                if (Program.Player.IsDead())
                                return;
                                Console.WriteLine($"{World.RED}The king has finally been defeated, the island may now be free...");
                                Console.WriteLine($"{World.RED}Plus, you got a kick-ass weapon out of it. I'd call this a complete win!");
                                World.Continue();
                                Program.Refresh();
                                Console.WriteLine($"{World.RED}Although, it seemed a bit easy");
                                Console.WriteLine($"{World.RED}Too easy...");
                                World.Continue();
                                Program.Refresh();
                                Console.WriteLine($"{World.RED}A distant rumble is audible..");
                                World.Continue();
                                Program.Refresh();
                                Battle.StartBattle(World.MonsterByID(World.MONSTER_ID_KING_MICHELON_VIII));
                                if (Program.Player.IsDead())
                                return;
                                Program.Player.CurrentQuest = null;
                                Console.WriteLine($"{World.GREEN}There we go!");
                                Console.WriteLine($"{World.GREEN}He's surely dead now..");
                                World.Continue();
                                Program.Refresh();
                                Console.WriteLine($"{World.GREEN}The island has been saved.");
                                Console.WriteLine($"{World.GREEN}You can go home now.");
                                Program.WinGame();
                                return;
                            }
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
            else if (Options[option] == "Shop")
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