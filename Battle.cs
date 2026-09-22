using System.IO.Compression;

public class Battle
{

    // TODO: Make the Battle work with a player's death
    Monster Monster;
    Player Player = Program.Player;
    bool FinishedBattle = false;
    int PlayersDamage;
    int MonstersDamage;

    bool HasDamageBoost = false;
    bool HasUsedPotion = false;

    Quest? quest;

    // Static startbattle method, callable without an instance of the class
    public static void StartBattle(Monster monster, Quest quest = null)
    {

        Battle battle = new Battle();
        battle.quest = quest;

        // Change the battle's Monster accordingly and reset his health
        battle.Monster = monster;
        battle.Monster.CurrentHitPoints = battle.Monster.MaximumHitPoints;

        Console.WriteLine($"You've encountered a {World.RED}wild{World.RESET} {World.BOLD}{battle.Monster.Name}{World.RESET}");
        World.Continue();
        while (true) // Battle loop until the Monster has been defeated
        {
            battle.ConstructMenu();
            battle.PlayersTurn();
            if (battle.FinishedBattle)
            {
                Program.Player.PotionsActive.Clear();
                break;
            }
            battle.ConstructMenu();
            battle.MonstersTurn();
        }

    }

    // PlayersTurn
    // The player will be able to either attack, use an item, or flee
    // A player can use items infinitely during his turn
    // A player only has a 50% chance for the flee to succeed
    public void PlayersTurn()
    {
        back: // Label for when the script wants to return to the start
        ConstructMenu();
        Console.WriteLine($"{World.BLUE}What will you do?{World.RESET}");
        Console.WriteLine($"{World.BLUE}1.{World.RESET} Attack");
        Console.WriteLine($"{World.BLUE}2.{World.RESET} Items");
        Console.WriteLine($"{World.BLUE}3.{World.RESET} Flee");
        string option = World.ChooseOption("1", "2", "3"); //Using helper method for options
        Program.Refresh();

        if (option == "1")
        {
            Console.WriteLine($"{World.BLUE}What will you do?{World.RESET}");
            Console.WriteLine($"{World.BLUE}1.{World.RESET}{World.BOLD} Attack:{World.RESET}");
            Console.WriteLine($"   {World.DIM}- {Player.CurrentWeapon.MoveName} {World.RESET}{World.DIM}{World.RED}({Player.CurrentWeapon.CurrentDamage} DMG){World.RESET}");
            Console.WriteLine($"{World.BLUE}2. {World.RED}RETURN{World.RESET}");
            if (World.ChooseOption("1", "2") == "2")
            {
                goto back;
            } 
            else
            {
                int hit_chance = World.RandomGenerator.Next(1,101);
                // The player randomly does between 80-120% of their weapons damage
                PlayersDamage = (int)(Player.CurrentWeapon.CurrentDamage * World.RandomGenerator.Next(80,120) * 0.01);
                if (Program.Player.PotionsActive.Any(p => p.ID == 3))
                    PlayersDamage += 50;
                if (Program.Player.PotionsActive.Any(p => p.ID == 4))
                    PlayersDamage *= 2;
                if (hit_chance > 90) // 10% chance to miss, no damage
                {
                    PlayersDamage = 0;
                    ConstructMenu();
                    Console.WriteLine($"{World.GRAY}MISS!{World.RESET} You did {World.RED}0 DMG{World.RESET}");
                } 
                else if (hit_chance > 50 && Program.Player.PotionsActive.Any(p => p.ID == 5) || hit_chance > 80) // 10% chance to crit, double damage
                {
                    PlayersDamage *= 2;
                    if (PlayersDamage > Monster.CurrentHitPoints){PlayersDamage = Monster.CurrentHitPoints;}
                    Monster.CurrentHitPoints -= PlayersDamage;
                    ConstructMenu();
                    Console.WriteLine($"{World.YELLOW}CRITICAL!{World.RESET} You did {World.RED}{PlayersDamage} DMG {World.RESET}");
                }
                else
                { // 80% chance to hit, standard damage
                    if (PlayersDamage > Monster.CurrentHitPoints){PlayersDamage = Monster.CurrentHitPoints;}
                    Monster.CurrentHitPoints -= PlayersDamage;
                    ConstructMenu();
                    Console.WriteLine($"{World.GREEN}HIT!{World.RESET} You did {World.RED}{PlayersDamage} DMG{World.RESET}");
                }
                PlayersDamage = 0;
                
                World.Continue();

                // If the monster is dead after attacking
                if(Monster.CurrentHitPoints == 0)
                {
                    if (Program.Player.CurrentQuest?.TargetMonster.ID == Monster.ID)
                        Program.Player.CurrentQuest.CurrentMonstersKilled++;
                    ConstructMenu();
                    Console.WriteLine($"{World.GREEN}You have successfully defeated {Monster.Name}!{World.RESET}");
                    World.Continue();
                    // Receive gold
                    int goldObtained = (int)(Monster.GoldDrop * World.RandomGenerator.Next(80,120) * 0.01);
                    Player.Gold += goldObtained;
                    ConstructMenu();
                    Console.WriteLine($"{World.YELLOW}+{goldObtained} Gold{World.RESET}");
                    World.Continue();
                    ConstructMenu();
                    // If the monster drops a lootbox
                    if ((!Monster.WeaponDropped || World.RandomGenerator.Next(0,101) <= 20) && Monster.LootboxRarity != null)
                    {
                        Console.WriteLine($"{World.GREEN}Oh?{World.RESET} {Monster.Name} is carrying {World.BOLD}something...{World.RESET}");
                        Console.Write($"{World.UNDERLINE}Reach for it?{World.RESET}");
                        Console.ReadLine(); 
                        ConstructMenu();
                        List<string> rarities = ["Common", "Rare", "Epic", "Legendary", "Mythical"];
                        Weapon chosenWeapon = new(World.WeaponByID(World.RandomGenerator.Next(1,4) + rarities.IndexOf(Monster.LootboxRarity)*3));
                        chosenWeapon.SetQuality();
                        Program.Player.Inventory.AddWeapon(chosenWeapon);
                        Monster.WeaponDropped = true;
                        Console.WriteLine($"{World.YELLOW}You have obtained a {World.RESET}{chosenWeapon.Name}{World.YELLOW}!{World.RESET}");
                        Console.WriteLine($"{World.YELLOW}QUALITY: {World.RESET}{chosenWeapon.Quality}");
                        Console.WriteLine($"{World.GREEN}RARITY: {World.RESET}{chosenWeapon.Rarity}");
                        Console.WriteLine($"{World.RED}DAMAGE: {World.RESET}{chosenWeapon.CurrentDamage}");
                        World.Continue();
                        if (chosenWeapon.Rarity == "Mythical")
                        {   
                            Program.Player.Inventory.AddWeapon(Program.Player.CurrentWeapon);
                            Player.CurrentWeapon = chosenWeapon;
                            ConstructMenu();
                            Console.WriteLine($"{World.RED}You automatically equipped the {chosenWeapon.Name}");
                        }
                    }

                    if (quest is not null)
                    {
                        quest.status = QuestStatus.finished;
                    }
                    
                    FinishedBattle = true;
                }
            }
        }
        else if (option == "2")
        {
            if (Monster.IsBoss)
            {
                Console.WriteLine($"{World.RED}{Monster.Name} is {World.BOLD}PROHIBITING{World.RESET}{World.RED} you from using items.");
            }
            else
            {
                Player.Inventory.ViewInventory(true);
                goto back;
            }
        }
        else if (option == "3")
        {
            if (Monster.IsBoss)
            {
                Console.WriteLine($"{World.RED}{Monster.Name} is {World.BOLD}PROHIBITING{World.RESET}{World.RED} you from fleeing.");
            }
                else
                {
                // 50% chance to fail the flee
                if (World.RandomGenerator.Next(100) < 50 )
                {
                    Console.WriteLine($"{World.RED}You failed to flee{World.RESET}");
                    World.Continue();
                }
                else
                // 50% chance to succeed the flee (No rewards)
                {
                    Console.WriteLine($"{World.GREEN}You have successfully fled!{World.RESET}");
                    FinishedBattle = true;
                    World.Continue();
                }
            }
        }

    }

    public void MonstersTurn()
    {
        MonstersDamage = (int)(Monster.MaximumDamage * World.RandomGenerator.Next(80,120) * 0.01 * (1 - Program.Player.CurrentArmour.Defense * 0.01));
        if (World.RandomGenerator.Next(100) > 73)
        {
            MonstersDamage = 0;
            ConstructMenu();
            Console.WriteLine($"{World.BOLD}{Monster.Name}{World.RESET} {World.GRAY}MISSED{World.RESET} and did {World.RED}0 DMG{World.RESET}");
        } else
        {
            if (Monster.IsBoss && World.RandomGenerator.Next(100) > 73 || !Monster.IsBoss || HasUsedPotion)
            {
                MonstersDamage = Program.Player.TakeDamage(MonstersDamage);
                if (HasDamageBoost)
                {
                    MonstersDamage *= 4;
                    HasDamageBoost = false;
                }
                ConstructMenu();
                Console.WriteLine($"{World.BOLD}{Monster.Name}{World.RESET} {World.GREEN}HIT{World.RESET} and did {World.RED}{MonstersDamage} DMG!{World.RESET}");
                HasUsedPotion = false;
            }
            else
            {
                if (World.RandomGenerator.Next(100) > 48)
                {
                    ConstructMenu();
                    Monster.CurrentHitPoints += 2500;
                    if (Monster.CurrentHitPoints > Monster.MaximumHitPoints)
                    {
                        Monster.CurrentHitPoints = Monster.MaximumHitPoints;
                    }
                    Console.WriteLine($"{World.RED}{Monster.Name} has used a Heal Potion");
                    Console.WriteLine($"{World.RED}+2500 HP");
                }
                else
                {
                    ConstructMenu();
                    HasDamageBoost = true;
                    Console.WriteLine($"{World.RED}{Monster.Name} has used a Strong Potion");
                    Console.WriteLine($"{World.RED}Will do 4x damage next attack.");
                }
                HasUsedPotion = true;
            }
        }
        MonstersDamage = 0; 
        if (Program.Player.IsDead())
        {
            Console.WriteLine($"{World.RED}u DEAD mah boi... Aint no second chances for u. Time to despawn{World.RESET}");
        }
        World.Continue();
    }

    public void ConstructMenu() // Refresh the screen with the player + monster health
    {
        Program.Refresh();
        Console.WriteLine($"{World.RED} {(Monster.IsBoss ? "--- ☠︎︎ BOSS FIGHT ☠︎︎ ---" : "--- Battle ---")}{World.RESET}");
        // Monsters HP
        Console.Write($"{Monster.Name}: {World.RED}{Monster.CurrentHitPoints}/{Monster.MaximumHitPoints}{World.RESET} HP");
        if (PlayersDamage != 0)
        { // Health lower indicator for monster
            Console.WriteLine($" {World.RED}{World.DIM}-{PlayersDamage}{World.RESET}");
        } else {Console.WriteLine();}
        // Players HP
        Console.Write($"{Player.Name}: {World.RED}{Player.CurrentHitPoints}/{Player.MaximumHitPoints}{World.RESET} HP");
        if (MonstersDamage != 0)
        { // Health lower indicator for player
            Console.WriteLine($" {World.RED}{World.DIM}-{MonstersDamage}{World.RESET}");
        } else {Console.WriteLine();}
        Console.WriteLine();
    }
}