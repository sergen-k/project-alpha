public class Player
{
    public string Name;
    public int CurrentHitPoints;
    public int MaximumHitPoints = 100;
    public int Gold = 0;
    public Weapon CurrentWeapon = World.WeaponByID(World.WEAPON_ID_RUSTY_SWORD);
    public Armour CurrentArmour = World.ArmourByID(World.ARMOUR_ID_RAGS);
    public Location CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);
    public bool IsFighting;
    public InventoryManager Inventory = new();
    public List<Potion> PotionsActive = new();

    public Quest? CurrentQuest;

    public Player(string name)
    {
        Name = name;
        CurrentHitPoints = MaximumHitPoints;
    }

    public int TakeDamage(int damage)
    {
        //Reduce the player's health
        CurrentHitPoints -= damage;
        int return_health = damage;
        // Health cannot go below 0
        if (CurrentHitPoints < 0)
        {
            return_health = damage + CurrentHitPoints;
            CurrentHitPoints = 0;
        }
        return return_health;
    }

    public bool IsDead()
    {
        // Check if the player has no health left
        return CurrentHitPoints == 0;
    }

    public int Heal(int amount)
    {
        // Increase the player's health
        CurrentHitPoints += amount;
        int return_health = amount;
        // Health cannot go above maximum health
        if (CurrentHitPoints > MaximumHitPoints)
        {
            return_health = amount - (CurrentHitPoints - MaximumHitPoints);
            CurrentHitPoints = MaximumHitPoints;
        }
        return return_health;
    }


    /// <summary>
    /// Update the players CurrentLocation to the given <paramref name="location"/> if possible
    /// </summary>
    /// <param name="location"> The new <see cref="Location"/> to move the player this location.</param>
    /// <returns>
    /// returns true if location has been changed successfully 
    /// </returns>
    public bool MoveToLocation(Location location)
    {
        if (!CurrentLocation.IsNeighbor(location))
        {
            return false;
        }
        CurrentLocation = location;
        return true;
    }
}