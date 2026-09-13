public class Player
{
    public string Name;
    public int CurrentHitPoints;
    public int MaximumHitPoints = 100;
    public int Gold = 0;
    public Weapon CurrentWeapon = World.WeaponByID(1);
    public Location CurrentLocation = World.LocationByID(1);
    public bool IsFighting;

    public Quest? CurrentQuest;

    public Player(string name)
    {
        Name = name;
        CurrentHitPoints = MaximumHitPoints;
    }
    public void ShowHealth()
    {
        Console.WriteLine($"Health: {CurrentHitPoints}/{MaximumHitPoints}");
    }

        public void TakeDamage(int damage)
    {
        //Reduce the player's health
        CurrentHitPoints -= damage;

        // Health cannot go below 0
        if (CurrentHitPoints < 0)
        {
            CurrentHitPoints = 0;
        }

        // Show the updated health
        ShowHealth();
    }

    public bool IsDead()
    {
        // Check if the player has no health left
        return CurrentHitPoints == 0;
    }

    public void Heal(int amount)
    {
        // Increase the player's health
        CurrentHitPoints += amount;

        // Health cannot go above maximum health
        if (CurrentHitPoints > MaximumHitPoints)
        {
            CurrentHitPoints = MaximumHitPoints;
        }

        // Show the updated health
        ShowHealth();
    }
    public void MoveToLocation(Location location)
    {
        CurrentLocation = location;

        Console.WriteLine(location.Name);
        Console.WriteLine(location.Description);

        if (location.QuestAvailableHere is not null && CurrentQuest is null)
        {
            bool accepted = AcceptQuest(location);
            if (accepted)
            {
                CurrentQuest = location.QuestAvailableHere;
            }
        }
    }

    public bool AcceptQuest(Location location)
    {
        Console.WriteLine("there is a quest available in this location!!");
        Console.WriteLine(location.QuestDescription());
        Console.WriteLine("Do you want to accept the quest? (y/n)");


        string answer;
        while (true)
        {
           answer = Console.ReadLine()!;
           if (answer == "y" || answer == "n") break; 
        }

        

       return  answer == "y"; 
    }


}