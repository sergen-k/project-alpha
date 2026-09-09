public class Player
{
    public string Name;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public Weapon CurrentWeapon;
    public Location CurrentLocation;

    public Player(string name, int maximumHitPoints)
    {
        Name = name;
        MaximumHitPoints = maximumHitPoints;
        CurrentHitPoints = maximumHitPoints;
    }
}