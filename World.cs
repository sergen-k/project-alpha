public static class World
{

    public static readonly List<Weapon> Weapons = new List<Weapon>();
    public static readonly List<Monster> Monsters = new List<Monster>();
    public static readonly List<Armour> Armours = new List<Armour>();
    public static readonly List<Potion> Potions = new List<Potion>();
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

    public const int ARMOUR_ID_RAGS = 1;
    public const int ARMOUR_ID_LEATHER = 2;
    public const int ARMOUR_ID_CHAINMAIL = 3;
    public const int ARMOUR_ID_GILDED = 4;
    public const int ARMOUR_ID_STEEL = 5;
    public const int ARMOUR_ID_DRAGONBORN = 6;
    

    public const int POTION_ID_HEAL_POTION = 1;
    public const int POTION_ID_MEGA_HEAL_POTION = 2;
    public const int POTION_ID_STRONG_POTION = 3;
    public const int POTION_ID_MEGA_STRONG_POTION = 4;
    public const int POTION_ID_CRITICAL_POTION = 5;
    public const int POTION_ID_SURPRISE_POTION = 6;



    public const int MONSTER_ID_GOBLIN_CHILD = 1;
    public const int MONSTER_ID_GOBLIN_WARRIOR = 2;

    public const int QUEST_ID_TEST = 1;

    public const int LOCATION_ID_HOME = 1;
    public const int LOCATION_ID_LADYBUG_TOWN = 2;
    public const int LOCATION_ID_GOBLIN_CAMP = 3;
    public const int LOCATION_ID_ABANDONED_CASTLE = 4;
    public const int LOCATION_ID_MUSHROOM_FIELDS = 5;
    public const int LOCATION_ID_GIANT_FOREST = 6;
    public const int LOCATION_ID_WITCHES_HUT = 7;
    public const int LOCATION_ID_MURKY_SWAMP = 8;
    public const int LOCATION_ID_LOST_GRAVEYARD = 9;

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
        PopulateArmour();
        PopulatePotions();
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
    public static void PopulateArmour()
    {
        Armours.Add(new Armour(ARMOUR_ID_RAGS, "Rags", 0));
        Armours.Add(new Armour(ARMOUR_ID_LEATHER, "Leather", 38));
        Armours.Add(new Armour(ARMOUR_ID_CHAINMAIL, "Chainmail", 61));
        Armours.Add(new Armour(ARMOUR_ID_GILDED, "Gilded", 83));
        Armours.Add(new Armour(ARMOUR_ID_STEEL, "Steel", 90));
        Armours.Add(new Armour(ARMOUR_ID_DRAGONBORN, "Dragonborn", 96));
    }

    public static void PopulatePotions()
    {
        Potions.Add(new Potion(POTION_ID_HEAL_POTION, "Heal Potion", "+10 HP", $"{BLUE}INSTANT{RESET}"));
        Potions.Add(new Potion(POTION_ID_MEGA_HEAL_POTION, "Mega Heal Potion", "+20 HP", $"{BLUE}INSTANT{RESET}"));
        Potions.Add(new Potion(POTION_ID_STRONG_POTION, "Strong Potion", "+50 DMG", $"{RED}PASSIVE{RESET}"));
        Potions.Add(new Potion(POTION_ID_MEGA_STRONG_POTION, "Mega Strong Potion", "x2 DMG", $"{RED}PASSIVE{RESET}"));
        Potions.Add(new Potion(POTION_ID_CRITICAL_POTION, "Critical Potion", "50% Crit", $"{RED}PASSIVE{RESET}"));
        Potions.Add(new Potion(POTION_ID_SURPRISE_POTION, "Surprise Potion", "May luck be on your side.", $"{BLUE}INSTANT{RESET}"));
    }
        

    public static void PopulateMonsters()
    { // Damage, HP, Gold drops, LootboxRarity, LootboxChance
        Monsters.Add(new Monster(MONSTER_ID_GOBLIN_CHILD, "Goblin Child", 5, 50, 10, "Common", 25));
        Monsters.Add(new Monster(MONSTER_ID_GOBLIN_WARRIOR, "Goblin Warrior ", 8, 75, 15, "Common", 40));
    }

    public static void PopulateQuests()
    {
        Quest TestQuest =
            new Quest(
                QUEST_ID_TEST,
                "Clear the alchemist's garden",
                "Kill rats in the alchemist's garden ");


        Quests.Add(TestQuest);
    }

    public static void PopulateLocations()
    {
        // Create each location
        Location home = new Location(LOCATION_ID_HOME, "Home", "", null, null);

        Location ladybugTown = new Location(LOCATION_ID_LADYBUG_TOWN, "Ladybug Town", "", null, null);

        Location goblinCamp = new Location(LOCATION_ID_GOBLIN_CAMP, "Goblin Camp", "", null, null);

        Location abandonedCastle = new Location(LOCATION_ID_ABANDONED_CASTLE, "Abandoned Castle", "", null, null);

        Location mushroomFields = new Location(LOCATION_ID_MUSHROOM_FIELDS, "Mushroom Fields", "", null, null);

        Location giantForest = new Location(LOCATION_ID_GIANT_FOREST, "Giant Forest", "", null, null);

        Location witchesHut = new Location(LOCATION_ID_WITCHES_HUT, "Witches Hut", "", null, null);
        
        Location murkySwamp = new Location(LOCATION_ID_MURKY_SWAMP, "Murky Swamp", "", null, null);
        
        Location lostGraveyard = new Location(LOCATION_ID_LOST_GRAVEYARD, "Lost Graveyard", "", null, null);

        // Link the locations together
        home.LocationToNorth = ladybugTown;

        ladybugTown.LocationToNorth = murkySwamp;
        ladybugTown.LocationToSouth = home;
        ladybugTown.LocationToEast = goblinCamp;
        ladybugTown.LocationToWest = mushroomFields;

        goblinCamp.LocationToEast = ladybugTown;
        goblinCamp.LocationToWest = abandonedCastle;

        abandonedCastle.LocationToEast = goblinCamp;

        mushroomFields.LocationToEast = giantForest;
        mushroomFields.LocationToWest = ladybugTown;

        giantForest.LocationToEast = witchesHut;
        giantForest.LocationToWest = mushroomFields;

        witchesHut.LocationToWest = giantForest;

        murkySwamp.LocationToSouth = ladybugTown;
        murkySwamp.LocationToNorth = lostGraveyard;

        lostGraveyard.LocationToSouth = murkySwamp;

        // Add the locations to the static list
        Locations.Add(home);
        Locations.Add(ladybugTown);
        Locations.Add(goblinCamp);
        Locations.Add(abandonedCastle);
        Locations.Add(mushroomFields);
        Locations.Add(giantForest);
        Locations.Add(witchesHut);
        Locations.Add(murkySwamp);
        Locations.Add(lostGraveyard);
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
        foreach (Weapon weapon in Weapons)
        {
            if (weapon.ID == id)
            {
                return weapon;
            }
        }

        return null;
    }

    public static Potion PotionByID(int id)
    {
        foreach (Potion potion in Potions)
        {
            if (potion.ID == id)
            {
                return potion;
            }
        }

        return null;
    }

    public static Armour ArmourByID(int id)
    {
        foreach (Armour armour in Armours)
        {
            if (armour.ID == id)
            {
                return armour;
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
