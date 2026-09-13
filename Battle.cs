public class Battle
{
    Player Player;
    Monster Monster;

    public Battle(Player player, Monster monster)
    {
        Player = player;
        Monster = monster;
    }

    public void InitiateBattle()
    {
        Console.WriteLine($"You've encountered a wild {Monster.Name}");
        Console.ReadLine();
    }

    public void PlayersTurn()
    {
        ConstructMenu();
        Console.WriteLine("What will you do?");
        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Item Bag");
        Console.WriteLine("3. Try to flee");
        string option = World.ChooseOption("1", "2", "3");

        if (option == "1")
        {
            
        }
        else if (option == "2")
        {
            
        }
        else if (option == "3")
        {
            
        }

    }

    public void MonstersTurn()
    {
        
    }

    public void ConstructMenu()
    {
        Console.Clear();
        Console.WriteLine($"{Monster.Name}: {(int)(Monster.CurrentHitPoints/Monster.MaximumHitPoints)*100}");
        Console.WriteLine();
        Console.WriteLine($"{Player.Name}: {Player.CurrentHitPoints}/{Player.MaximumHitPoints}");
    }
}