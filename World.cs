public static class World
{

    public static readonly List<Weapon> Weapons = new List<Weapon>();
    public static readonly List<Monster> Monsters = new List<Monster>();
    public static readonly List<Armour> Armours = new List<Armour>();
    public static readonly List<Potion> Potions = new List<Potion>();
    
    public static readonly List<Shop> Shops = new List<Shop>();
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
    public const int WEAPON_ID_SKELETON_AXE = 10;
    public const int WEAPON_ID_MOLTEN_STAKE = 11;
    public const int WEAPON_ID_DEATHS_SCYTHE = 12;
    
    public const int WEAPON_ID_BRINGER_OF_COMETS = 13;
    public const int WEAPON_ID_HAMMER_OF_CHAOS = 14;
    public const int WEAPON_ID_SLAYER_OF_DRAGONS = 15;

    public const int ARMOUR_ID_RAGS = 1;
    public const int ARMOUR_ID_LEATHER_GARMENTS = 2;
    public const int ARMOUR_ID_CHAINMAIL_ARMOUR = 3;
    public const int ARMOUR_ID_GILDED_ARMOUR = 4;
    public const int ARMOUR_ID_STEEL_ARMOUR = 5;
    public const int ARMOUR_ID_CRYSTALLINE_ARMOUR = 6;
    

    public const int POTION_ID_HEAL_POTION = 1;
    public const int POTION_ID_MEGA_HEAL_POTION = 2;
    public const int POTION_ID_STRONG_POTION = 3;
    public const int POTION_ID_MEGA_STRONG_POTION = 4;
    public const int POTION_ID_CRITICAL_POTION = 5;
    public const int POTION_ID_SURPRISE_POTION = 6;



    public const int MONSTER_ID_GOBLIN_WARRIOR = 1;
    public const int MONSTER_ID_TERROR_RAT = 2;
    public const int MONSTER_ID_FUNGLING = 3;
    public const int MONSTER_ID_FOREST_ENT = 4;
    public const int MONSTER_ID_THE_WITCH = 5;
    public const int MONSTER_ID_GELATINOUS_CUBE = 6;
    public const int MONSTER_ID_MICHELON = 7;
    public const int MONSTER_ID_KING_MICHELON_VIII = 8;

    public const int QUEST_ID_THE_VILLAGER = 1;
    public const int QUEST_ID_THE_TROLL = 2;
    public const int QUEST_ID_THE_GRASSHOPPER = 3;
    public const int QUEST_ID_THE_WOODPECKER = 4;
    public const int QUEST_ID_THE_WITCH = 5;
    public const int QUEST_ID_THE_SLIME = 6;
    public const int QUEST_ID_THE_KING = 7;

    public const int LOCATION_ID_HOME = 1;
    public const int LOCATION_ID_LADYBUG_TOWN = 2;
    public const int LOCATION_ID_GOBLIN_CAMP = 3;
    public const int LOCATION_ID_ABANDONED_CASTLE = 4;
    public const int LOCATION_ID_MUSHROOM_FIELDS = 5;
    public const int LOCATION_ID_GIANT_FOREST = 6;
    public const int LOCATION_ID_WITCHES_HUT = 7;
    public const int LOCATION_ID_MURKY_SWAMP = 8;
    public const int LOCATION_ID_LOST_GRAVEYARD = 9;

    public const int SHOP_ID_LADYBUG_MERCHANT = 1;
    public const int SHOP_ID_GOBLIN_SALESMAN = 2;
    public const int SHOP_ID_THE_WITCH = 3;
    public const int SHOP_ID_THE_SLIME_SMITH = 4;

    public const string RESET = "\x1b[0m";
    public const string BOLD = "\x1b[1m";
    public const string ITALIC = "\x1b[3m";
    public const string UNDERLINE = "\x1b[4m";
    public const string DIM = "\x1b[2m";

    public const string RED = "\x1b[31m";
    public const string GREEN = "\x1b[32m";
    public const string YELLOW = "\x1b[33m";
    public const string BLUE = "\x1b[34m";
    public const string GRAY = "\u001b[90m";

    static World()
    {
        PopulateWeapons();
        PopulateArmour();
        PopulatePotions();
        PopulateMonsters();
        PopulateQuests();
        PopulateShops();
        PopulateLocations();
    }


    public static void PopulateWeapons()
    {
        Weapons.Add(new Weapon(WEAPON_ID_RUSTY_SWORD, "Rusty Sword", "Tetanus Tearer", 20));
        Weapons.Add(new Weapon(WEAPON_ID_BAT, "Bat", "Home Run", 25));
        Weapons.Add(new Weapon(WEAPON_ID_FRAIL_BOW, "Frail Bow", "Splinter Shot", 30));
        Weapons.Add(new Weapon(WEAPON_ID_THORNED_CLUB, "Thorned Club", "Acupuncture", 80));
        Weapons.Add(new Weapon(WEAPON_ID_DAGGER, "Dagger", "Veggie Cutter", 100));
        Weapons.Add(new Weapon(WEAPON_ID_SHINING_SWORD, "Shining Sword", "Hack 'n Slash", 120));
        Weapons.Add(new Weapon(WEAPON_ID_CROSSBOW, "Crossbow", "Mindblower", 300));
        Weapons.Add(new Weapon(WEAPON_ID_BEJEWELED_BLADE, "Bejeweled Blade", "Crystal Crumble", 350));
        Weapons.Add(new Weapon(WEAPON_ID_COMPOUND_BOW, "Compound Bow", "Arch of Precission", 400));
        Weapons.Add(new Weapon(WEAPON_ID_SKELETON_AXE, "Skeleton Axe", "Femur Fracture", 1400));
        Weapons.Add(new Weapon(WEAPON_ID_MOLTEN_STAKE, "Molten Stake", "Skin Melter", 1550));
        Weapons.Add(new Weapon(WEAPON_ID_DEATHS_SCYTHE, "Death's Scythe", "Now I am become death, the Destroyer of Worlds", 1650));
        Weapons.Add(new Weapon(WEAPON_ID_BRINGER_OF_COMETS, "Bringer of Comets", "As the sky falls", 5000));
        Weapons.Add(new Weapon(WEAPON_ID_HAMMER_OF_CHAOS, "Hammer of Chaos", "Feel the Thunder", 5000));
        Weapons.Add(new Weapon(WEAPON_ID_SLAYER_OF_DRAGONS, "Slayer of Dragons", "Free the End", 5000));
        
        
    }
    public static void PopulateArmour()
    {
        Armours.Add(new Armour(ARMOUR_ID_RAGS, "Rags", 0));
        Armours.Add(new Armour(ARMOUR_ID_LEATHER_GARMENTS, "Leather Garments", 38));
        Armours.Add(new Armour(ARMOUR_ID_CHAINMAIL_ARMOUR, "Chainmail Armour", 54));
        Armours.Add(new Armour(ARMOUR_ID_GILDED_ARMOUR, "Gilded Armour", 76));
        Armours.Add(new Armour(ARMOUR_ID_STEEL_ARMOUR, "Steel Armour", 88));
        Armours.Add(new Armour(ARMOUR_ID_CRYSTALLINE_ARMOUR, "Crystalline Armour", 94));
    }

    public static void PopulatePotions()
    {
        Potions.Add(new Potion(POTION_ID_HEAL_POTION, "Heal Potion", "+10 HP", $"{BLUE}INSTANT{RESET}", 10));
        Potions.Add(new Potion(POTION_ID_MEGA_HEAL_POTION, "Mega Heal Potion", "+20 HP", $"{BLUE}INSTANT{RESET}", 20));
        Potions.Add(new Potion(POTION_ID_STRONG_POTION, "Strong Potion", "+50 DMG", $"{RED}PASSIVE{RESET}", 0));
        Potions.Add(new Potion(POTION_ID_MEGA_STRONG_POTION, "Mega Strong Potion", "x2 DMG", $"{RED}PASSIVE{RESET}", 0));
        Potions.Add(new Potion(POTION_ID_CRITICAL_POTION, "Critical Potion", "50% Crit", $"{RED}PASSIVE{RESET}", 0));
        Potions.Add(new Potion(POTION_ID_SURPRISE_POTION, "Surprise Potion", "May luck be on your side.", $"{BLUE}INSTANT{RESET}", 0));
    }
        

    public static void PopulateMonsters()
    { // Damage, HP, Gold drops, LootboxRarity, LootboxChance
        Monsters.Add(new Monster(MONSTER_ID_GOBLIN_WARRIOR, "Goblin Warrior", 8, 60, 15, "Common", false));
        Monsters.Add(new Monster(MONSTER_ID_TERROR_RAT, "Terror Rat", 15, 175, 25, "Rare", false));
        Monsters.Add(new Monster(MONSTER_ID_FUNGLING, "Fungling", 25, 340, 40, "Rare", false));
        Monsters.Add(new Monster(MONSTER_ID_FOREST_ENT, "Forest Ent", 40, 625, 75, "Epic", false));
        Monsters.Add(new Monster(MONSTER_ID_THE_WITCH, "The Witch", 50, 10000, 500, "Legendary", true));
        Monsters.Add(new Monster(MONSTER_ID_GELATINOUS_CUBE, "Gelatinous Cube", 100, 6500, 150, "Legendary", false));
        Monsters.Add(new Monster(MONSTER_ID_MICHELON, "Michelon", 10, 5001, 13, "Mythic", true));
        Monsters.Add(new Monster(MONSTER_ID_KING_MICHELON_VIII, "King Michelon VIII", 200, 100000, 800000000, null, true));
    
    }
    public static void PopulateShops()
    { 
        Shops.Add(new Shop(SHOP_ID_LADYBUG_MERCHANT, "Ladybug Merchant", "Welcome to my humble shop, how may I be of service to thee?", true));
        Shops.Add(new Shop(SHOP_ID_GOBLIN_SALESMAN, "Goblin Salesman", "Mi sellz yu big big ituhmz very guuud very cheeeep cam buy NOWz", true));
        Shops.Add(new Shop(SHOP_ID_THE_WITCH, "The Witch", "Would you like to buy some of my wacky potions?", false));
        Shops.Add(new Shop(SHOP_ID_THE_SLIME_SMITH, "The Slime Smith", "I've got someeeeeeeee of that gooooooooooddd stuff ;]", false));
        ShopByID(SHOP_ID_LADYBUG_MERCHANT).AddshopItem(PotionByID(POTION_ID_HEAL_POTION), 30);
        ShopByID(SHOP_ID_LADYBUG_MERCHANT).AddshopItem(PotionByID(POTION_ID_STRONG_POTION), 50);
        ShopByID(SHOP_ID_LADYBUG_MERCHANT).AddshopItem(ArmourByID(ARMOUR_ID_LEATHER_GARMENTS), 65);
        ShopByID(SHOP_ID_LADYBUG_MERCHANT).AddshopItem(ArmourByID(ARMOUR_ID_CHAINMAIL_ARMOUR), 150);

        ShopByID(SHOP_ID_GOBLIN_SALESMAN).AddshopItem(ArmourByID(ARMOUR_ID_RAGS), 17);
        ShopByID(SHOP_ID_GOBLIN_SALESMAN).AddshopItem(PotionByID(POTION_ID_SURPRISE_POTION), 50);
        ShopByID(SHOP_ID_GOBLIN_SALESMAN).AddshopItem(WeaponByID(WEAPON_ID_DAGGER), 275);
        ShopByID(SHOP_ID_GOBLIN_SALESMAN).AddshopItem(ArmourByID(ARMOUR_ID_GILDED_ARMOUR), 400);
        
        ShopByID(SHOP_ID_THE_WITCH).AddshopItem(PotionByID(POTION_ID_MEGA_HEAL_POTION), 50);
        ShopByID(SHOP_ID_THE_WITCH).AddshopItem(PotionByID(POTION_ID_MEGA_STRONG_POTION), 100);
        ShopByID(SHOP_ID_THE_WITCH).AddshopItem(PotionByID(POTION_ID_CRITICAL_POTION), 100);
    
        ShopByID(SHOP_ID_THE_SLIME_SMITH).AddshopItem(ArmourByID(ARMOUR_ID_STEEL_ARMOUR), 750);
        ShopByID(SHOP_ID_THE_SLIME_SMITH).AddshopItem(ArmourByID(ARMOUR_ID_CRYSTALLINE_ARMOUR), 950);
    }

    public static void PopulateQuests()
    {
        Quest TheVillager =
            new Quest(
                QUEST_ID_THE_VILLAGER,
                "Defeat 3 Goblins in the Goblin Camp",
                $"(insert quest dialogue)",
                LOCATION_ID_GOBLIN_CAMP,
                MonsterByID(MONSTER_ID_GOBLIN_WARRIOR), 3,
                $"(insert quest completion dialogue)",
                50, true
                );
        
        Quest TheTroll =
            new Quest(
                QUEST_ID_THE_TROLL,
                "Defeat 3 Terror Rats in the Abandoned Castle",
                $"(insert quest dialogue)",
                LOCATION_ID_ABANDONED_CASTLE,
                MonsterByID(MONSTER_ID_TERROR_RAT), 3,
                $"(insert quest completion dialogue)",
                50, false
                );

        Quest TheGrasshopper =
            new Quest(
                QUEST_ID_THE_GRASSHOPPER,
                "Defeat a Fungling in the Mushroom Fields",
                $"(insert quest dialogue)",
                LOCATION_ID_MUSHROOM_FIELDS,
                MonsterByID(MONSTER_ID_FUNGLING), 1,
                $"(insert quest completion dialogue)",
                50, true
                );
        
        Quest TheWoodpecker =
            new Quest(
                QUEST_ID_THE_WOODPECKER,
                "Defeat a Forest Ent in the Giant Forest",
                $"(insert quest dialogue)",
                LOCATION_ID_GIANT_FOREST,
                MonsterByID(MONSTER_ID_FOREST_ENT), 1,
                $"(insert quest completion dialogue)",
                50, true
                );
        
        Quest TheWitch =
            new Quest(
                QUEST_ID_THE_WITCH,
                "Defeat the witch",
                $"(insert quest dialogue)",
                LOCATION_ID_MUSHROOM_FIELDS,
                MonsterByID(MONSTER_ID_THE_WITCH), 1,
                $"(insert quest completion dialogue)",
                50, false
                );
        
        Quest TheSlime =
            new Quest(
                QUEST_ID_THE_SLIME,
                "Defeat 3 Gelatinous Cubes in the Murky Swamp",
                $"(insert quest dialogue)",
                LOCATION_ID_MURKY_SWAMP,
                MonsterByID(MONSTER_ID_GELATINOUS_CUBE), 3,
                $"(insert quest completion dialogue)",
                50, true
                );

        Quest TheKing =
            new Quest(
                QUEST_ID_THE_KING,
                "Defeat King Michelon VIII",
                $"(insert quest dialogue)",
                LOCATION_ID_LOST_GRAVEYARD,
                MonsterByID(MONSTER_ID_KING_MICHELON_VIII), 1,
                $"(insert quest completion dialogue)",
                50, false
                );


        Quests.Add(TheVillager);
        Quests.Add(TheTroll);
        Quests.Add(TheGrasshopper);
        Quests.Add(TheWoodpecker);
        Quests.Add(TheWitch);
        Quests.Add(TheSlime);
        Quests.Add(TheKing);
    }

    public static void PopulateLocations()
    {
        // Create each location
        Location home = new Location(LOCATION_ID_HOME, "Home", null, null, null);
        home.AddSurrounding("This was supposed to be home...\nThe place where you grew up, where everything felt safe.\nNow the streets are empty and your home has been torn apart by monsters.\nYou still remember the night they came.\nPeople ran in every direction, and you barely managed to escape.\nYou don't know what happened to everyone else.\nAll you know is that you can't stay here anymore.\nWith nothing left to protect, you take the old blade your family kept hidden away.\nIt's not much... but it's better than nothing.");

        Location ladybugTown = new Location(LOCATION_ID_LADYBUG_TOWN, "Ladybug Town", QuestByID(QUEST_ID_THE_VILLAGER), null, ShopByID(SHOP_ID_LADYBUG_MERCHANT));
        ladybugTown.AddSurrounding("Ladybug Town is still standing.\nPeople still live here, shops are still open, and the streets are usually full of life.\nBut nobody here feels safe anymore.\nThe goblins regularly sneak into town, stealing food, weapons, and anything else they can carry.\nThey aren't working for Michelon.\nThey're simply taking advantage of the chaos he's left behind.\nEvery time the goblins come, the town loses a little more.\nThe people here are getting tired of rebuilding what gets destroyed.");
        Location goblinCamp = new Location(LOCATION_ID_GOBLIN_CAMP, "Goblin Camp", null, MonsterByID(MONSTER_ID_GOBLIN_WARRIOR), ShopByID(SHOP_ID_GOBLIN_SALESMAN));
        goblinCamp.AddSurrounding("So this is where the goblins have been hiding.\nThey're not part of Michelon's army.\nThey've simply seen an opportunity and decided to take it.\nWhile the rest of the island is distracted by the monsters, the goblins have been raiding towns and taking whatever they want.\nTheir camp is filled with stolen food, weapons, and belongings.\nSome of the things here look like they came from Ladybug Town.\nYou've seen what their raids have done to the people there.\nMaybe it's time someone stopped them.");
        Location abandonedCastle = new Location(LOCATION_ID_ABANDONED_CASTLE, "Abandoned Castle", QuestByID(QUEST_ID_THE_TROLL), MonsterByID(MONSTER_ID_TERROR_RAT), null);
        abandonedCastle.AddSurrounding("So this is the old castle of King Michelon.\nIt has been abandoned since his death, but the place still feels strangely alive.\nDust covers the halls, and most of the furniture has been left exactly where it was.\nPaintings of Michelon line the walls.\nSome show him as a respected king.\nOthers have been damaged so badly that you can barely recognize his face.\nWhatever happened here must have changed him.\nMaybe the truth about his death is still hidden somewhere inside these walls.");
        Location mushroomFields = new Location(LOCATION_ID_MUSHROOM_FIELDS, "Mushroom Fields", QuestByID(QUEST_ID_THE_GRASSHOPPER), MonsterByID(MONSTER_ID_FUNGLING), null);
        mushroomFields.AddSurrounding("You've never seen mushrooms this large before.\nThey cover the fields in every direction, growing over rocks, trees, and even old ruins.\nThe air is strangely quiet here.\nYou remember hearing stories about this place when you were younger.\nPeople said the mushrooms appeared after the king was killed.\nNobody knows why they started growing.\nSome say they're harmless.\nOthers say that anyone who stays here too long starts seeing things that aren't really there.\nYou aren't planning on sticking around to find out.");
        Location giantForest = new Location(LOCATION_ID_GIANT_FOREST, "Giant Forest", QuestByID(QUEST_ID_THE_WOODPECKER), MonsterByID(MONSTER_ID_FOREST_ENT), null);
        giantForest.AddSurrounding("The trees here are enormous.\nTheir branches stretch so high that you can barely see the sky.\nThe forest is strangely quiet, but you can constantly hear something moving somewhere in the distance.\nYou remember people warning you never to come here alone.\nThey said the forest was home to creatures that even the monsters avoid.\nWith everything that's happened to the island, you aren't sure what you'll find anymore.\nStill, there's no other way forward.\nYou tighten your grip around your old blade and step deeper into the forest.");
        Location witchesHut = new Location(LOCATION_ID_WITCHES_HUT, "Witches Hut", QuestByID(QUEST_ID_THE_WITCH), null, ShopByID(SHOP_ID_THE_WITCH));
        witchesHut.AddSurrounding("A small wooden hut sits between the trees.\nYou've heard stories about the witch who lives here for as long as you can remember.\nSome people say she's dangerous.\nOthers say she's one of the few people who understands what happened to King Michelon.\nThe door is unlocked.\nInside, the walls are covered with strange symbols, bottles, and old books.\nYou notice the same name written across several of them.\nMichelon.\nWhatever happened to the king, this witch probably knows more than she's willing to tell.");
        Location murkySwamp = new Location(LOCATION_ID_MURKY_SWAMP, "Murky Swamp", QuestByID(QUEST_ID_THE_SLIME), MonsterByID(MONSTER_ID_GELATINOUS_CUBE), ShopByID(SHOP_ID_THE_SLIME_SMITH));
        murkySwamp.AddSurrounding("The swamp is covered in thick fog.\nThe water is dark, the ground sinks beneath your feet, and the smell is almost unbearable.\nNothing here looks healthy anymore.\nDead trees stick out of the water, and strange plants grow around the edges of the swamp.\nPeople used to avoid this place even before the king's death.\nNow it's become even worse.\nYou can hear something moving through the water nearby.\nWhatever lives here, you hope it hasn't noticed you yet.");
        Location lostGraveyard = new Location(LOCATION_ID_LOST_GRAVEYARD, "Lost Graveyard", QuestByID(QUEST_ID_THE_KING), null, null);
        lostGraveyard.AddSurrounding("The Lost Graveyard is older than anyone can remember.\nHundreds of graves cover the area, but most of the names have faded away.\nNobody knows who many of these people were.\nYou walk past the graves until you notice one that looks different from the rest.\nThe name on the stone is still clearly visible.\nMichelon.\nThe grave is completely silent.\nThen, for just a moment, you hear a voice behind you.\n\"You finally came.\"");
        // Link the locations together
        home.LocationToNorth = ladybugTown;

        ladybugTown.LocationToSouth = home;
        ladybugTown.LocationToEast = goblinCamp;
        ladybugTown.LocationToWest = mushroomFields;

        goblinCamp.LocationToWest = ladybugTown;
        goblinCamp.LocationToEast = abandonedCastle;

        abandonedCastle.LocationToWest = goblinCamp;

        mushroomFields.LocationToWest = giantForest;
        mushroomFields.LocationToEast = ladybugTown;

        giantForest.LocationToWest = witchesHut;
        giantForest.LocationToEast = mushroomFields;

        witchesHut.LocationToEast = giantForest;

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
    public static Shop ShopByID(int id)
    {
        foreach (Shop shop in Shops)
        {
            if (shop.ID == id)
            {
                return shop;
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
            option = Console.ReadLine()!.ToLower();
        while (!options.Contains(option.ToLower()));
        return option;
    }   

    public static string ChooseOption(List<string> options, string errorMessage)
    {
        string option;
        int errorCount = 0;
       
        do
        {
            if (errorCount >0 )
            {
                Console.WriteLine(errorMessage);
            }


            option = Console.ReadLine()!;
            errorCount++;
        }
        while (!options.Contains(option.ToLower()));
        return option.ToLower();
    }   



    // Use this method if u want "Continue" printed
    public static void Continue()
    {
        Console.Write($"{BOLD}{UNDERLINE}Continue{RESET} ");
        Console.ReadLine();
    }
}
