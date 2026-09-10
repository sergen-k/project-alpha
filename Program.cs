class Porgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IntroductionText());
        Console.WriteLine("Fill in player name:");
        string name = Console.ReadLine() ?? "John Doe";

        Player player = new(name, 100);

        SetupGame(player);

        

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

}