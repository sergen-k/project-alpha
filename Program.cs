class Porgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IntroductionText());
        Console.WriteLine("Fill in player name:");
        string name = Console.ReadLine() ?? "John Doe";

        Player player = new(name, 100);
        SetupGame(player);

        bool is_game_running = true;
        string gameState = "exploring";


         // main game loop
        while (is_game_running)
        {
            //TODO show the stats of the player



            //TODO is player fighting 
             // sergen zijn code 



            //TODO is player in inventory 
             // mohhamed en jasarat


            //TODO is player in location
            // rik en yessin zijn code gaan hier
            if (gameState == "exploring")
            {
                SelectLocation(player);
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

    public static void SetupGame(Player player)
    {
        // start player in home
        player.CurrentLocation = World.LocationByID(1);
        player.CurrentHitPoints  = 100;

        // give player rusty sword
        player.CurrentWeapon = World.WeaponByID(1);

    }

    public static string IntroductionText()
    {
        return "Hallo welkom bij onze game blah";
    }

    public static void Stats(Player player)
    {
        Console.Clear();
        Console.WriteLine($"NAME: {player.Name}");
        Console.WriteLine($"WEAPON: {player.CurrentWeapon}");
        // Display Armour
        // Display Quest
        Console.WriteLine($"LOCATION: {player.CurrentLocation}");
        Console.WriteLine("__________________________________________");
        Console.WriteLine();
    }
}