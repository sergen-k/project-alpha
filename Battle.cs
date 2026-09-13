using System.IO.Compression;

public class Battle
{

    // TODO: Make the Battle work with a player's death
    Monster Monster;
    Player Player = Program.Player;
    bool FinishedBattle = false;
    int PlayersDamage;
    int MonstersDamage;

    // Static startbattle method, callable without an instance of the class
    public static void StartBattle(Monster monster)
    {
        Battle battle = new Battle();

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
                break;
            }
            battle.ConstructMenu();
            battle.MonstersTurn();
            // TODO: Add a break for when a player is dead
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
            Console.WriteLine($"   {World.DIM}- {Player.CurrentWeapon.MoveName} {World.RESET}{World.RED}({Player.CurrentWeapon.MaximumDamage} DMG){World.RESET}");
            Console.WriteLine($"{World.BLUE}2.{World.RESET} Go back");
            if (World.ChooseOption("1", "2") == "2")
            {
                goto back;
            } 
            else
            {
                int hit_chance = World.RandomGenerator.Next(1,101);
                // The player randomly does between 80-120% of their weapons damage
                PlayersDamage = (int)(Player.CurrentWeapon.MaximumDamage * World.RandomGenerator.Next(80,120) * 0.01);
                if (hit_chance > 90) // 10% chance to miss, no damage
                {
                    ConstructMenu();
                    Console.WriteLine($"{World.GRAY}MISS!{World.RESET} You did {World.RED}0 DMG{World.RESET}");
                } 
                else if (hit_chance > 80) // 10% chance to crit, double damage
                {
                    PlayersDamage *= 2;
                    if (PlayersDamage > Monster.CurrentHitPoints){PlayersDamage = Monster.CurrentHitPoints;}
                    Monster.CurrentHitPoints -= PlayersDamage;
                    ConstructMenu();
                    Console.WriteLine($"{World.YELLOW}CRITICAL!{World.RESET} You did {World.RED}{100*PlayersDamage/Monster.MaximumHitPoints}% DMG {World.RESET}");
                }
                else
                { // 80% chance to hit, standard damage
                    if (PlayersDamage > Monster.CurrentHitPoints){PlayersDamage = Monster.CurrentHitPoints;}
                    Monster.CurrentHitPoints -= PlayersDamage;
                    ConstructMenu();
                    Console.WriteLine($"{World.GREEN}HIT!{World.RESET} You did {World.RED}{100*PlayersDamage/Monster.MaximumHitPoints}% DMG{World.RESET}");
                }
                PlayersDamage = 0;
                
                World.Continue();

                // If the monster is dead after attacking
                if(Monster.CurrentHitPoints == 0)
                {
                    ConstructMenu();
                    Console.WriteLine($"{World.GREEN}You have successfully defeated {Monster.Name}!{World.RESET}");
                    World.Continue();
                    // Receive gold
                    int GoldObtained = (int)(Monster.GoldDrop * World.RandomGenerator.Next(80,120) * 0.01);
                    Player.Gold += GoldObtained;
                    ConstructMenu();
                    Console.WriteLine($"{World.YELLOW}+{GoldObtained} Gold{World.RESET}");
                    World.Continue();
                    ConstructMenu();
                    // If the monster drops a lootbox
                    if (World.RandomGenerator.Next(1,101) <= Monster.LootboxChance)
                    {
                        Console.WriteLine($"{World.GREEN}Oh?{World.RESET} {Monster.Name} is carrying {World.BOLD}something...{World.RESET}");
                        Console.Write($"{World.UNDERLINE}Reach for it?{World.RESET}");
                        Console.ReadLine(); 
                        ConstructMenu();
                        // TODO: Add weapon obtainment to inventory
                        World.Continue();
                    }
                    FinishedBattle = true;
                }
            }
        }
        else if (option == "2")
        {
            goto back; // Temporary
            // TODO: Add an item selection menu
        }
        else if (option == "3")
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

    public void MonstersTurn()
    {
        // TODO: Add so that monsters cant overkill
        MonstersDamage = (int)(Monster.MaximumDamage * World.RandomGenerator.Next(80,120) * 0.01);
        if (World.RandomGenerator.Next(100) > 73)
        {
            MonstersDamage = 0;
            ConstructMenu();
            Console.WriteLine($"{World.BOLD}{Monster.Name}{World.RESET} {World.GRAY}MISSED{World.RESET} and did {World.RED}0 DMG{World.RESET}");
        } else
        {
            Player.CurrentHitPoints -= MonstersDamage;
            ConstructMenu();
            Console.WriteLine($"{World.BOLD}{Monster.Name}{World.RESET} {World.GREEN}HIT{World.RESET} and did {World.RED}{MonstersDamage} DMG!{World.RESET}");
        }
        // TODO: Add death sequence
        MonstersDamage = 0; 
        World.Continue();
    }

    public void ConstructMenu() // Refresh the screen with the player + monster health
    {
        Program.Refresh();
        // Monsters HP
        Console.Write($"{Monster.Name}: {World.RED}{100*Monster.CurrentHitPoints/Monster.MaximumHitPoints}%{World.RESET} HP");
        if (PlayersDamage != 0)
        { // Health lower indicator for monster
            Console.WriteLine($" {World.RED}{World.DIM}-{100*PlayersDamage/Monster.MaximumHitPoints}%{World.RESET}");
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