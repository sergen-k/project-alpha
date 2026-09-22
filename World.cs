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

    public const int QUEST_ID_THE_GOBLINS = 1;
    public const int QUEST_ID_THE_RATS = 2;
    public const int QUEST_ID_THE_FUNGLINGS = 3;
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

    public static void ResetWorld()
    {
        Weapons.Clear();
        Armours.Clear();
        Potions.Clear();
        Monsters.Clear();
        Quests.Clear();
        Shops.Clear();
        Locations.Clear();

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
        Potions.Add(new Potion(POTION_ID_HEAL_POTION, "Heal Potion", "+50 HP", $"{BLUE}INSTANT{RESET}", 50));
        Potions.Add(new Potion(POTION_ID_MEGA_HEAL_POTION, "Mega Heal Potion", "+100 HP", $"{BLUE}INSTANT{RESET}", 100));
        Potions.Add(new Potion(POTION_ID_STRONG_POTION, "Strong Potion", "+50 DMG", $"{RED}PASSIVE{RESET}", 0));
        Potions.Add(new Potion(POTION_ID_MEGA_STRONG_POTION, "Mega Strong Potion", "x2 DMG", $"{RED}PASSIVE{RESET}", 0));
        Potions.Add(new Potion(POTION_ID_CRITICAL_POTION, "Critical Potion", "50% Crit", $"{RED}PASSIVE{RESET}", 0));
        Potions.Add(new Potion(POTION_ID_SURPRISE_POTION, "Surprise Potion", "May luck be on your side.", $"{BLUE}INSTANT{RESET}", 0));
    }
        

    public static void PopulateMonsters()
    { // Damage, HP, Gold drops, LootboxRarity, LootboxChance
        Monsters.Add(new Monster(MONSTER_ID_GOBLIN_WARRIOR, "Goblin Warrior", 6, 60, 15, "Common", false));
        Monsters.Add(new Monster(MONSTER_ID_TERROR_RAT, "Terror Rat", 11, 150, 25, "Rare", false));
        Monsters.Add(new Monster(MONSTER_ID_FUNGLING, "Fungling", 25, 340, 40, "Rare", false));
        Monsters.Add(new Monster(MONSTER_ID_FOREST_ENT, "Forest Ent", 40, 625, 75, "Epic", false));
        Monsters.Add(new Monster(MONSTER_ID_THE_WITCH, "The Witch", 50, 2000, 500, "Legendary", true));
        Monsters.Add(new Monster(MONSTER_ID_GELATINOUS_CUBE, "Gelatinous Cube", 75, 5000, 150, "Legendary", false));
        Monsters.Add(new Monster(MONSTER_ID_MICHELON, "Michelon", 10, 6767, 13, "Mythic", true));
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
        Quest TheGoblinCamp =
            new Quest(
                QUEST_ID_THE_GOBLINS,
                "Defeat 3 Goblins in the Goblin Camp",
                $"{RED}The Villager:{RESET} 'Those goblins have been raiding our village for weeks now.\nThey sneak in at night, steal our food, and destroy anything they can't carry away.\nWe're tired of hiding from them.\nIf you're really willing to help us, go to their camp and defeat a few of them.\nMaybe that'll teach them that this village isn't theirs to plunder.'",
                LOCATION_ID_GOBLIN_CAMP,
                MonsterByID(MONSTER_ID_GOBLIN_WARRIOR), 3,
                $"{RED}The Villager:{RESET} 'You actually did it! Maybe those little monsters will think twice before coming back here.\nThere's something else I should tell you, though.\nLately, people have been whispering about a troll living somewhere around the abandoned castle, which is past the Goblin Camp.\nI don't know if it's true, but if you're heading that way, you should probably keep your guard up.'",
                50, true
                );
        
        Quest theRats =
            new Quest(
                QUEST_ID_THE_RATS,
                "Defeat 3 Terror Rats in the Abandoned Castle",
                $"{RED}The Troll:{RESET} 'What are you doing here?\nI've lived in these ruins ever since the old king died, and I've had enough trouble without strangers wandering around.\nEver since his death, the rats around here have changed.\nThey're bigger, more aggressive, and they're multiplying faster than I can deal with them.\nKill a few of them for me, and maybe I can finally have some peace around here.'",
                LOCATION_ID_ABANDONED_CASTLE,
                MonsterByID(MONSTER_ID_TERROR_RAT), 3,
                $"{RED}The Troll:{RESET} 'Good. Maybe now I can finally get some sleep without those filthy rats crawling around everywhere.\nSince you've helped me, I'll tell you something you might find useful.\nThere's a witch who lives deeper into the island.\nShe lives in a hut past the Mushroom fields and the Giant Forest directly west from here.\nShe's evil, but she knows things that nobody else does.\nIf you want to know what happened to this island, or what really happened to the king, she may be the one you need to find.'",
                100, false
                );

        Quest theFunglings =
            new Quest(
                QUEST_ID_THE_FUNGLINGS,
                "Defeat a Fungling in the Mushroom Fields",
                $"{RED}The Caterpillar:{RESET} 'I'm starving!\nThose mushrooms used to be my favorite food, but now they've gone completely mad!\nThey've started walking around and fighting back!\nI'm usually fast enough to escape anything that tries to eat me, but I can't outrun those things anymore.\nThere's one Fungling nearby that's been eating all the mushrooms before I can get to them.\nPlease, kill it for me!\nI just want to eat my dinner in peace.'",
                LOCATION_ID_MUSHROOM_FIELDS,
                MonsterByID(MONSTER_ID_FUNGLING), 1,
                $"{RED}The Caterpillar:{RESET} 'You did it!\nFinally, I can eat in peace again!\nI can't thank you enough.\nNow if you'll excuse me, I've got some catching up to do.'",
                70, true
                );
        
        Quest TheWoodpecker =
            new Quest(
                QUEST_ID_THE_WOODPECKER,
                "Defeat a Forest Ent in the Giant Forest",
                $"{RED}The Woodpecker:{RESET} 'Have you seen what happened to my home?!\nThese trees used to be perfectly normal, and then they suddenly came to life!\nNow the whole forest is full of walking trees, and my home is gone!\nI need somewhere to live, but I can't build a new home while these things are stomping around everywhere.\nThere's a Forest Ent nearby that's causing me the most trouble.\nCould you take care of it for me?\nOnce it's gone, I can finally build myself a new home.'",
                LOCATION_ID_GIANT_FOREST,
                MonsterByID(MONSTER_ID_FOREST_ENT), 1,
                $"{RED}The Woodpecker:{RESET} 'You actually did it!\nThank you!\nNow I can finally build myself a new home without worrying about some giant tree walking away with it.\nI owe you one.'",
                80, true
                );
        
        Quest TheWitch =
            new Quest(
                QUEST_ID_THE_WITCH,
                "Defeat the witch",
                $"{RED}The Witch:{RESET} 'You dare enter my home without permission?\nI've had enough of foolish intruders thinking they can simply walk into my hut.\nYou should have turned around while you had the chance.\nNow you'll learn why people fear me.'",
                LOCATION_ID_MUSHROOM_FIELDS,
                MonsterByID(MONSTER_ID_THE_WITCH), 1,
                $"{RED}The Witch:{RESET} 'You... defeated me?\nI must admit, I misjudged you.\nPerhaps you're not as foolish as I thought.\nYou seek answers about the king, don't you?\nThen listen carefully.\nThe spirit of the dead king has been hiding in the Lost Graveyard.\nThe graveyard lies beyond the Murky Swamp, north of Ladybug Town.\nIf you want to reach him, that is where you must go.\nAnd since you've proven yourself worthy, I've opened my shop to you.\nI have potions that may prove useful in your fight against the king.\nYou'll need all the help you can get.'",
                25, false
                );
        
        Quest TheSlime =
            new Quest(
                QUEST_ID_THE_SLIME,
                "Defeat 3 Gelatinous Cubes in the Murky Swamp",
                $"{RED}The Slime:{RESET} 'Please, you have to help me!\nSeveral gelatinous cubes broke into my home and stole my family's heirlooms!\nThose items have been passed down through my family for generations.\nI tried to get them back myself, but those cubes are much tougher than they look.\nPlease, defeat them and bring my family's heirlooms back to me.\nI'll make sure you're rewarded for your trouble.'",
                LOCATION_ID_MURKY_SWAMP,
                MonsterByID(MONSTER_ID_GELATINOUS_CUBE), 3,
                $"{RED}The Slime:{RESET} 'You brought them back!\nI can't thank you enough.\nMy family's heirlooms are finally safe again.\nYou've done me a great favor, so I'll let you in on a little secret.\nI've been keeping a shop hidden away from the rest of the island.\nNormally, I wouldn't let anyone know about it, but you've earned my trust.\nCome take a look.\nI have some of the strongest armour you'll find anywhere on the island.'",
                185, true
                );

        Quest TheKing =
            new Quest(
                QUEST_ID_THE_KING,
                "Defeat King Michelon VIII",
                $"{RED}King Michelon:{RESET} 'So... you finally made your way to me.\nI must congratulate you.\nFew have come this far, and even fewer have survived the journey.\nBut your journey ends here.\nYou will die, just like the rest of them.\nThis island belongs to me!\nIt always has, and it always will.\nNo one has the right to take it from me.\nI was betrayed and murdered by the very people I ruled over.\nThey took my life, stole my kingdom, and left me to rot in the ground.\nBut death did not make me forget.\nIt only made my hatred stronger.\nNow the people of this island will suffer for what they have done.\nThey will taste my wicked revenge.\nAnd you...\nYour journey ends HERE.'",
                LOCATION_ID_LOST_GRAVEYARD,
                MonsterByID(MONSTER_ID_KING_MICHELON_VIII), 1,
                "",
                0, false
                );


        Quests.Add(TheGoblinCamp);
        Quests.Add(theRats);
        Quests.Add(theFunglings);
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

        Location ladybugTown = new Location(LOCATION_ID_LADYBUG_TOWN, "Ladybug Town", QuestByID(QUEST_ID_THE_GOBLINS), null, ShopByID(SHOP_ID_LADYBUG_MERCHANT));
        ladybugTown.AddSurrounding("Ladybug Town is still standing.\nPeople still live here, shops are still open, and the streets are usually full of life.\nBut nobody here feels safe anymore.\nThe goblins regularly sneak into town, stealing food, weapons, and anything else they can carry.\nThey aren't working for Michelon.\nThey're simply taking advantage of the chaos he's left behind.\nEvery time the goblins come, the town loses a little more.\nThe people here are getting tired of rebuilding what gets destroyed.");
        Location goblinCamp = new Location(LOCATION_ID_GOBLIN_CAMP, "Goblin Camp", null, MonsterByID(MONSTER_ID_GOBLIN_WARRIOR), ShopByID(SHOP_ID_GOBLIN_SALESMAN));
        goblinCamp.AddSurrounding("So this is where the goblins have been hiding.\nThey're not part of Michelon's army.\nThey've simply seen an opportunity and decided to take it.\nWhile the rest of the island is distracted by the monsters, the goblins have been raiding towns and taking whatever they want.\nTheir camp is filled with stolen food, weapons, and belongings.\nSome of the things here look like they came from Ladybug Town.\nYou've seen what their raids have done to the people there.\nMaybe it's time someone stopped them.");
        Location abandonedCastle = new Location(LOCATION_ID_ABANDONED_CASTLE, "Abandoned Castle", QuestByID(QUEST_ID_THE_RATS), MonsterByID(MONSTER_ID_TERROR_RAT), null);
        abandonedCastle.AddSurrounding("So this is the old castle of King Michelon.\nIt has been abandoned since his death, but the place still feels strangely alive.\nDust covers the halls, and most of the furniture has been left exactly where it was.\nPaintings of Michelon line the walls.\nSome show him as a respected king.\nOthers have been damaged so badly that you can barely recognize his face.\nWhatever happened here must have changed him.\nMaybe the truth about his death is still hidden somewhere inside these walls.");
        Location mushroomFields = new Location(LOCATION_ID_MUSHROOM_FIELDS, "Mushroom Fields", QuestByID(QUEST_ID_THE_FUNGLINGS), MonsterByID(MONSTER_ID_FUNGLING), null);
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
            if (quest.QuestID == id)
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
