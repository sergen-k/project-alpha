public class Program
{
    public static Player Player;
    public static bool game_running = true;
    public static void Main(string[] args)
    {
        Introduction();

        while (game_running)
        {
            Refresh();
            Console.WriteLine($"{World.BLUE}What do you want to do, Adventurer?{World.RESET}");
            Console.WriteLine();
            Console.WriteLine($"{World.BLUE}1.{World.RESET} Check Inventory");
            Console.WriteLine($"{World.BLUE}2.{World.RESET} Travel");
            Console.WriteLine($"{World.BLUE}3.{World.RESET} Explore Current Area");
            string menuSelection = World.ChooseOption("1", "2", "3");
            switch (menuSelection)
            {
                case "1": Player.Inventory.ViewInventory(false); break;
                case "2": SelectLocation(); break;
                case "3": Player.CurrentLocation.CheckSurroundings(); break;
            }

            Refresh();
        }
    }

    public static void SelectLocation()
    {
        Refresh();
        Console.WriteLine($"{World.YELLOW}You are currently at: {World.BOLD}{World.RESET}{Player.CurrentLocation.Name}{World.RESET}");
        Console.WriteLine();

        // get the list of (direction, Location) objects
        List<(string, Location)> validDirsLocations = Player.CurrentLocation.GetValidNeighbors();

        // for user validation
        List<string> validDirs = [];

        // Print valid locations
        foreach ((string dir, Location loc) in validDirsLocations)
        {
            Console.WriteLine($"{World.BLUE}{dir}:{World.RESET} {loc.Name}");
            validDirs.Add(dir[0].ToString().ToLower());
        }
        Console.WriteLine();
        Console.WriteLine($"{World.YELLOW}{World.BOLD}Fill in {World.RESET}{World.BOLD}{(validDirs.Contains("n") ? World.GREEN : World.DIM)}N{World.RESET}/{World.BOLD}{(validDirs.Contains("s") ? World.GREEN : World.DIM)}S{World.RESET}/{World.BOLD}{(validDirs.Contains("e") ? World.GREEN : World.DIM)}E{World.RESET}/{World.BOLD}{(validDirs.Contains("w") ? World.GREEN : World.DIM)}W{World.YELLOW} to travel:{World.RESET}");

        // let the user select and fetch Location based on first char of direction.
        string selection = World.ChooseOption(validDirs, "Invalid location");
        (_, Location selectedLoc) = validDirsLocations.Find(x => x.Item1[0].ToString().ToLower() == selection);
        Refresh();
        Console.WriteLine($"You took a {World.BLUE}STEP.{World.RESET}");
        World.Continue();
        Refresh();
        Console.WriteLine($"You took another {World.BLUE}STEP.{World.RESET}");
        World.Continue();
        Refresh();
        Console.WriteLine($"You took the final {World.BLUE}STEP!{World.RESET}");
        World.Continue();
        Refresh();
        Console.WriteLine($"{World.GREEN}{World.BOLD}You have arrived at: {World.RESET}{selectedLoc.Name}");
        Player.MoveToLocation(selectedLoc);
        World.Continue();
    }

    public static void Introduction()
    {
        Console.Clear();

        Console.WriteLine($"{World.BLUE}{World.BOLD}");
        Console.WriteLine("███╗   ███╗██╗ ██████╗██╗  ██╗███████╗██╗      ██████╗ ███╗   ██╗");
        Console.WriteLine("████╗ ████║██║██╔════╝██║  ██║██╔════╝██║     ██╔═══██╗████╗  ██║");
        Console.WriteLine("██╔████╔██║██║██║     ███████║█████╗  ██║     ██║   ██║██╔██╗ ██║");
        Console.WriteLine("██║╚██╔╝██║██║██║     ██╔══██║██╔══╝  ██║     ██║   ██║██║╚██╗██║");
        Console.WriteLine("██║ ╚═╝ ██║██║╚██████╗██║  ██║███████╗███████╗╚██████╔╝██║ ╚████║");
        Console.WriteLine("╚═╝     ╚═╝╚═╝ ╚═════╝╚═╝  ╚═╝╚══════╝╚══════╝ ╚═════╝ ╚═╝  ╚═══╝");
        Console.WriteLine($"{World.RESET}");

        Console.WriteLine($"{World.YELLOW}{World.BOLD}              I S L A N D   A D V E N T U R E{World.RESET}");
        Console.WriteLine();
        Console.WriteLine($"{World.BLUE}                ⚔  VENGEANCE HAS AWOKEN  ⚔{World.RESET}");
        Console.WriteLine();

        World.Continue();

        Console.Clear();

        Console.WriteLine($"{World.BLUE}The spirit of the assassinated king, {World.BOLD}Michelon,{World.RESET}{World.BLUE} has grown consumed by {World.BOLD}Vengeance.{World.RESET}");
        Console.WriteLine($"{World.BLUE}He has unleashed a horde of {World.BOLD}Wicked{World.RESET}{World.BLUE} monsters, spreading {World.BOLD}Chaos and Destruction{World.RESET}{World.BLUE} across the island.");
        Console.WriteLine($"{World.BLUE}They have overrun your {World.BOLD}Home{World.RESET}{World.BLUE}, leaving you no choice but to seize an {World.BOLD}Old Blade{World.RESET}{World.BLUE} and flee.{World.RESET}");

        World.Continue();

        string Username;

        do
        {
            Console.Clear();

            Console.WriteLine($"{World.YELLOW}{World.BOLD}What is thy name, {World.GREEN}Adventurer{World.RESET}");
            Console.WriteLine($"{World.DIM}- 2-12 Characters");
            Console.WriteLine($"{World.DIM}- Only letters/numbers{World.RESET}");

            Username = Console.ReadLine()!;

        } while (!(Username.Length >= 2 &&
                   Username.Length <= 12 &&
                   Username.All(char.IsLetterOrDigit)));

        Player = new Player(Username);
        Console.Clear();

        Console.WriteLine($"{World.YELLOW}Welcome to {World.RESET}{World.BOLD}Michelon Island Adventure.{World.RESET}");
        Console.WriteLine($"{World.YELLOW}May {World.BOLD}{World.GREEN}Fortune{World.RESET}{World.YELLOW} guide you on the journey that lies ahead.{World.RESET}");
        Console.WriteLine($"{World.YELLOW}Good luck, {World.RESET}{World.BOLD}{Username}!{World.RESET}");

        World.Continue();
    }

    // Use this method if u wanna reset the screen and print out the player stats
    public static void Refresh()
    {
        Console.Clear();
        Console.WriteLine($"{World.GREEN}NAME:{World.RESET} {Player.Name}");
        Console.WriteLine($"{World.GREEN}HP:{World.RESET} {Player.CurrentHitPoints}/{Player.MaximumHitPoints}");
        Console.WriteLine($"{World.GREEN}WEAPON:{World.RESET} {Player.CurrentWeapon.Name} - {World.BOLD}{Player.CurrentWeapon.Rarity}{World.RESET} {World.DIM}{World.RED}({Player.CurrentWeapon.CurrentDamage} DMG){World.RESET} {World.RESET}{World.YELLOW}{World.DIM}(Quality: {Player.CurrentWeapon.Quality}%){World.RESET}");
        Console.WriteLine($"{World.GREEN}ARMOUR:{World.RESET} {Player.CurrentArmour.Name} - {World.BOLD}{Player.CurrentArmour.Rarity}{World.RESET} {World.DIM}{World.BLUE}({Player.CurrentArmour.Defense}% DEF){World.RESET}");
        Console.WriteLine($"{World.GREEN}GOLD:{World.RESET} {Player.Gold}");
        Console.WriteLine($"{World.GREEN}LOCATION:{World.RESET} {Player.CurrentLocation.Name}");
        if (Player.CurrentQuest != null)
        {
            Console.WriteLine();
            Console.WriteLine($"{World.GREEN}CURRENT QUEST:");
            Console.WriteLine($" {World.RED}- {Player.CurrentQuest.Description}{World.RESET}");
            if(Player.CurrentQuest.CurrentMonstersKilled >= Player.CurrentQuest.MonsterCount)
            {
                Console.WriteLine($"{World.GREEN}{World.BOLD}FINISHED! Return to {World.Locations.Find(l => l?.QuestAvailableHere == Player.CurrentQuest).Name}{World.RESET}");
                Player.CurrentQuest.status = QuestStatus.finished;
            }
            else
            {Console.WriteLine($"{World.RED}{World.BOLD}({Player.CurrentQuest.CurrentMonstersKilled}/{Player.CurrentQuest.MonsterCount}){World.RESET}");}
        }
        if (Player.PotionsActive.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine($"{World.RED}ACTIVE POTIONS:{World.RESET}");
            foreach (Potion potion in Player.PotionsActive)
                Console.WriteLine($" - {potion.Name} {World.RED}({potion.PotionDesc}){World.RESET} {World.GREEN}ACTIVATED{World.RESET}");
        }
        Console.WriteLine($"{World.GREEN}__________________________________________{World.RESET}");
        Console.WriteLine();
    }
    public static void WinGame()
    {
        Console.Clear();

        Console.WriteLine($"{World.GREEN}{World.BOLD}YOU WIN!{World.RESET}");
        Console.WriteLine();

        Console.WriteLine($"Name: {Player.Name}");
        Console.WriteLine($"HP: {Player.CurrentHitPoints}/{Player.MaximumHitPoints}");
        Console.WriteLine($"Gold: {Player.Gold}");
        Console.WriteLine($"Weapon: {Player.CurrentWeapon.Name}");
        Console.WriteLine($"Armour: {Player.CurrentArmour.Name}");
        game_running = false;
    }
}