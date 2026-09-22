public class Shop
{
    public int ID;
    public string Name;
    public string Speech;
    public Dictionary<object, int> Items = new();
    public bool ShopUnlocked;

    public Shop(int id, string name, string speech, bool shopUnlocked)
    {
        ID = id;
        Name = name;
        Speech = speech;
        ShopUnlocked = shopUnlocked;
    }

    public void AddshopItem(object item, int price)
    {
        Items[item] = price;
    }

    public void CheckShop()
    {
        while (true)
        {
        Program.Refresh();
        Console.WriteLine($"{World.RED}{Name}:{World.RESET} {Speech}");
        Console.WriteLine($"{World.BLUE}What do you wanna buy?{World.RESET}");
        Console.WriteLine($"{World.RED}--- Shop ---");
        Console.WriteLine($"{World.BLUE}1.{World.RED} RETURN{World.RESET}");
        int index = 2;
        foreach (var item in Items)
        { // Print out shop items
                Console.WriteLine($"{World.BLUE}{index}.{World.RESET} {((dynamic)item.Key).Name} - {(Program.Player.Gold >= item.Value ? World.GREEN : World.RED)}{item.Value} Gold{World.RESET}");
                index += 1;
        }

        string option = World.ChooseOption(Enumerable.Range(1, index).Select(x => x.ToString()).ToArray());
        if (option == "1")
            return;

        Program.Refresh();
        object TryingToBuy = Items.Keys.ElementAt(int.Parse(option)-2);
        if (Program.Player.Gold >= Items[TryingToBuy])
        {
            Program.Player.Gold -= Items[TryingToBuy];
            if (TryingToBuy.GetType() == typeof(Armour))
            {
                Program.Player.Inventory.AddArmour((dynamic)TryingToBuy);
            } 
            else if (TryingToBuy.GetType() == typeof(Potion))
            {
                Program.Player.Inventory.AddPotion((dynamic)TryingToBuy);
            }
            if (TryingToBuy.GetType() == typeof(Weapon))
            {
                Program.Player.Inventory.AddWeapon((dynamic)TryingToBuy);
            } 
            Console.WriteLine($"{World.YELLOW}You are now the proud owner of: {World.RESET}{((dynamic)TryingToBuy).Name}!");
        }
        else
        {
            Console.WriteLine($"You are too {World.RED}{World.BOLD}BROKE!{World.RED}");
        }
        World.Continue();
        }
    }
}