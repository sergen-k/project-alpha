class Porgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IntroductionText());
        Console.WriteLine("Fill in player name:");
        string name = Console.ReadLine() ?? "John Doe";

        Player player = new(name, 100);
        SetupGame(player);

        bool is_game_finished = false;

        while (is_game_finished)
        {
            
        }

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

    public static void Stats()
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