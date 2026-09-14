public class Program
{
    public static Player Player;
    public static bool game_running = true;
    public static void Main(string[] args)
    {  
        Introduction();
        
        string gameState = "";
        while (game_running)
        {
            // Some battles for testing purposes
            // Eventually replaced with the main game loop
            Refresh();
            Battle.StartBattle(World.MonsterByID(1));
            Refresh();
            Battle.StartBattle(World.MonsterByID(2));

            //TODO is player in inventory 
             // mohhamed en jasarat


            //TODO is player in location
            // rik en yessin zijn code gaan hier
            if (gameState == "exploring")
            {
                SelectLocation(Player);
            }
        }

    }

    public static void SelectLocation(Player player)
    {
        Console.WriteLine($"Je bevindt je nu in de locatie {player.CurrentLocation.Name}");
        Console.WriteLine("Selecteer een van de onderstaande locaties:");

        // get the list of (direction, Location) objects
        List<(string, Location)> validDirsLocations = player.CurrentLocation.GetValidNeighbors();

        // for user validation
        List<string> validDirs= [];

        // Print valid locations
        foreach ((string dir, Location loc) in validDirsLocations)
        {
           Console.WriteLine($"{dir}: {loc.Name}");
           validDirs.Add(dir[0].ToString().ToLower());
        }

        Console.WriteLine("fill in n/s/e/w select a location:");

        // let the user select and fetch Location based on first char of direction.
        string selection = World.ChooseOption(validDirs, "Invalid location");
        (_, Location selectedLoc)= validDirsLocations.Find( x => x.Item1[0].ToString() == selection );

        player.MoveToLocation(selectedLoc);
    }


    public static string IntroductionText()
    {
        return "Hallo welkom bij onze game blah";
    }

    public static void Introduction()
    {
        Console.Clear();
        // Print the intro
        Console.WriteLine($"{World.RED}The spirit of the assassinated king, {World.BOLD}Michelon,{World.RESET}{World.RED} has grown consumed by {World.BOLD}Vengeance.{World.RESET}");
        Console.WriteLine($"{World.RED}He has unleashed a horde of {World.BOLD}Wicked{World.RESET}{World.RED} monsters, spreading {World.BOLD}Chaos and Destruction{World.RESET}{World.RED} across the island.");
        Console.WriteLine($"{World.RED}They have overrun your {World.BOLD}Home{World.RESET}{World.RED}, leaving you no choice but to seize an {World.BOLD}Old Blade{World.RESET}{World.RED} and flee.{World.RESET}");
        World.Continue();
        string Username;
        // Do-while loop until user inputs correct Username
        do
        {
        Console.Clear();
        Console.WriteLine($"{World.YELLOW}{World.BOLD}What is thy name, {World.GREEN}Adventurer{World.RESET}");
        Console.WriteLine($"{World.DIM}- 2-12 Characters");
        Console.WriteLine($"{World.DIM}- Only letters/numbers{World.RESET}");
        Username = Console.ReadLine()!;
        } while(!(Username.Length >= 2 && Username.Length <= 12 && Username.All(char.IsLetterOrDigit)));
        // Create player object
        Player = new Player(Username);


        Console.Clear();
        Console.WriteLine($"{World.YELLOW}Welcome to {World.RESET}{World.BOLD}Michelon Island Adventure.{World.RESET}{World.YELLOW} May {World.BOLD}{World.GREEN}Fortune{World.RESET}{World.YELLOW} guide you on the journey that lies ahead.{World.RESET}");
        Console.WriteLine($"{World.YELLOW}Good luck, {World.BOLD}{Username}!{World.RESET}");
        World.Continue();
    }

    // Use this method if u wanna reset the screen and print out the player stats
    public static void Refresh() 
    {
        Console.Clear();
        Console.WriteLine($"{World.GREEN}NAME:{World.RESET} {Player.Name}");
        Console.WriteLine($"{World.GREEN}WEAPON:{World.RESET} {Player.CurrentWeapon.Name}");
        Console.WriteLine($"{World.GREEN}GOLD:{World.RESET} {Player.Gold}");
        // TODO: Display Optional Armour
        // TODO: Display Optional Quest
        Console.WriteLine($"{World.GREEN}LOCATION:{World.RESET} {Player.CurrentLocation.Name}");
        Console.WriteLine($"{World.GREEN}__________________________________________{World.RESET}");
        Console.WriteLine();
    }
}