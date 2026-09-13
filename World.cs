public static class World
{

    public static readonly List<Weapon> Weapons = new List<Weapon>();
    public static readonly List<Monster> Monsters = new List<Monster>();
    public static readonly List<Quest> Quests = new List<Quest>();
    public static readonly List<Location> Locations = new List<Location>();
    public static readonly Random RandomGenerator = new Random();

    public const int WEAPON_ID_RUSTY_SWORD = 1;
    public const int WEAPON_ID_BAT = 2;
    public const int WEAPON_ID_FRAIL_BOW = 3;
    public const int WEAPON_ID_THORNED_CLUB = 4;
    public const int WEAPON_ID_DAGGER = 5;
    public const int WEAPON_ID_SHINING_SWORD = 6;
    public const int WEAPON_ID_CROSSBOW = 7;
    public const int WEAPON_ID_BEJEWELED_BLADE = 8;
    public const int WEAPON_ID_COMPOUND_BOW = 9;
    public const int WEAPON_ID_DRAGON_SLAYER = 10;


    public const int MONSTER_ID_GOBLIN_CHILD = 1;
    public const int MONSTER_ID_GOBLIN_WARRIOR = 2;

    public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
    public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
    public const int QUEST_ID_COLLECT_SPIDER_SILK = 3;

    public const int LOCATION_ID_HOME = 1;
    public const int LOCATION_ID_TOWN_SQUARE = 2;
    public const int LOCATION_ID_GUARD_POST = 3;
    public const int LOCATION_ID_ALCHEMIST_HUT = 4;
    public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
    public const int LOCATION_ID_FARMHOUSE = 6;
    public const int LOCATION_ID_FARM_FIELD = 7;
    public const int LOCATION_ID_BRIDGE = 8;
    public const int LOCATION_ID_SPIDER_FIELD = 9;

    public const string RESET = "\x1b[0m";
    public const string BOLD = "\x1b[1m";
    public const string ITALIC = "\x1b[3m";
    public const string UNDERLINE = "\x1b[4m";
    public const string DIM = "\x1b[2m";

    public const string RED = "\x1b[31m";
    public const string GREEN = "\x1b[32m";
    public const string YELLOW = "\x1b[33m";
    public const string BLUE = "\x1b[34m";
    public const string GRAY = "\x1b[30m";

    static World()
    {
        PopulateWeapons();
        PopulateMonsters();
        PopulateQuests();
        PopulateLocations();
    }


    public static void PopulateWeapons()
    {
        Weapons.Add(new Weapon(WEAPON_ID_RUSTY_SWORD, "Rusty Sword", "Tetanus Tearer", 20));
        Weapons.Add(new Weapon(WEAPON_ID_BAT, "Bat", "Home Run", 30));
        Weapons.Add(new Weapon(WEAPON_ID_FRAIL_BOW, "Frail Bow", "Splinter Shot", 50));
        Weapons.Add(new Weapon(WEAPON_ID_THORNED_CLUB, "Thorned Club", "Acupuncture", 80));
        Weapons.Add(new Weapon(WEAPON_ID_DAGGER, "Dagger", "Veggie Cutter", 110));
        Weapons.Add(new Weapon(WEAPON_ID_SHINING_SWORD, "", "Hack 'n Slash", 165));
        Weapons.Add(new Weapon(WEAPON_ID_CROSSBOW, "Crossbow", "Mindblower", 270));
        Weapons.Add(new Weapon(WEAPON_ID_BEJEWELED_BLADE, "Bejeweled Blade", "Crystal Crumble", 420));
        Weapons.Add(new Weapon(WEAPON_ID_COMPOUND_BOW, "Compound Bow", "Arch of Precission", 777));
        Weapons.Add(new Weapon(WEAPON_ID_DRAGON_SLAYER, "Dragon Slayer", "Power of A Thousand Suns", 999));
    }

    public static void PopulateMonsters()
    { // Damage, HP, Gold drops, LootboxRarity, LootboxChance
        Monsters.Add(new Monster(MONSTER_ID_GOBLIN_CHILD, "Goblin Child", 5, 50, 10, "Common", 25));
        Monsters.Add(new Monster(MONSTER_ID_GOBLIN_WARRIOR, "Goblin Warrior ", 8, 75, 15, "Common", 40));
    }

    public static void PopulateQuests()
    {
        Quest clearAlchemistGarden =
            new Quest(
                QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                "Clear the alchemist's garden",
                "Kill rats in the alchemist's garden ");



        Quest clearFarmersField =
            new Quest(
                QUEST_ID_CLEAR_FARMERS_FIELD,
                "Clear the farmer's field",
                "Kill snakes in the farmer's field");


        Quest clearSpidersForest =
                    new Quest(
                        QUEST_ID_COLLECT_SPIDER_SILK,
                        "Collect spider silk",
                        "Kill spiders in the spider forest");


        Quests.Add(clearAlchemistGarden);
        Quests.Add(clearFarmersField);
        Quests.Add(clearSpidersForest);
    }

    public static void PopulateLocations()
    {
        // Create each location
        Location home = new Location(LOCATION_ID_HOME, "Home", "Your house. You really need to clean up the place.", null, null);

        Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "You see a fountain.", null, null);

        Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves.", null, null);
        alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

        Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Many plants are growing here.", World.QuestByID(1), null);
        //alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

        Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.", null, null);
        farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

        Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "You see rows of vegetables growing here.", null, null);
        //farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

        Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "There is a large, tough-looking guard here.", null, null);

        Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.", null, null);
        bridge.QuestAvailableHere = QuestByID(QUEST_ID_COLLECT_SPIDER_SILK);

        Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering covering the trees in this forest.", null, null);
        //spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

        // Link the locations together
        home.LocationToNorth = townSquare;

        townSquare.LocationToNorth = alchemistHut;
        townSquare.LocationToSouth = home;
        townSquare.LocationToEast = guardPost;
        townSquare.LocationToWest = farmhouse;

        farmhouse.LocationToEast = townSquare;
        farmhouse.LocationToWest = farmersField;

        farmersField.LocationToEast = farmhouse;

        alchemistHut.LocationToSouth = townSquare;
        alchemistHut.LocationToNorth = alchemistsGarden;

        alchemistsGarden.LocationToSouth = alchemistHut;

        guardPost.LocationToEast = bridge;
        guardPost.LocationToWest = townSquare;

        bridge.LocationToWest = guardPost;
        bridge.LocationToEast = spiderField;

        spiderField.LocationToWest = bridge;

        // Add the locations to the static list
        Locations.Add(home);
        Locations.Add(townSquare);
        Locations.Add(guardPost);
        Locations.Add(alchemistHut);
        Locations.Add(alchemistsGarden);
        Locations.Add(farmhouse);
        Locations.Add(farmersField);
        Locations.Add(bridge);
        Locations.Add(spiderField);
    }

    public static Location LocationByID(int id)
    {
        foreach (Location location in Locations)
        {
            if (location.ID == id)
            {
                return location;
            }
        }

        return null;
    }

    public static Weapon WeaponByID(int id)
    {
        foreach (Weapon item in Weapons)
        {
            if (item.ID == id)
            {
                return item;
            }
        }

        return null;
    }



    public static Monster MonsterByID(int id)
    {
        foreach (Monster monster in Monsters)
        {
            if (monster.ID == id)
            {
                return monster;
            }
        }

        return null;
    }

    public static Quest QuestByID(int id)
    {
        foreach (Quest quest in Quests)
        {
            if (quest.ID == id)
            {
                return quest;
            }
        }

        return null;
    }

    // Use this method if u want the user to be able to pick between options
    // Keeps asking until the loop receives valid input
    public static string ChooseOption(params string[] options)
    {
        string option;
        do
            option = Console.ReadLine()!;
        while (!options.Contains(option.ToLower()));
        return option;
    }   

    // Use this method if u want "Continue" printed
    public static void Continue()
    {
        Console.Write($"{BOLD}{UNDERLINE}Continue{RESET} ");
        Console.ReadLine();
    }
}
