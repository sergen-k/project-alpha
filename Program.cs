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

}