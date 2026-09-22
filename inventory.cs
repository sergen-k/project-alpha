public class InventoryManager
{
    public List<Weapon> Weapons = new List<Weapon>();
    public List<Armour> Armours = new List<Armour>();
    public List<Potion> Potions = new List<Potion>();

    public void AddWeapon(Weapon weapon)
    {
        Weapons.Add(weapon);
    }

    public void AddArmour(Armour armour)
    {
        Armours.Add(armour);
    }

    public void AddPotion(Potion potion)
    {
        // check to see if potion is already in inventory
        if (Potions.FindIndex(p => p.ID == potion.ID) == -1)
        {
            // if not in inventory, add it and set count to one
            Potions.Add(potion);
            potion.Count = 1;
        }
        else
        {
            // if is in inventory, increase count by one
            Potions[Potions.FindIndex(p => p.ID == potion.ID)].Count += 1;
        }
    }

    public void Reset()
    {
        Weapons.Clear();
        Armours.Clear();
        Potions.Clear();
    }

    public void ViewInventory(bool inBattle) // if inBattle = true, only able to view potions
    {
        do
        {
            Program.Refresh();
            if ((Weapons.Count + Potions.Count + Armours.Count > 0 && !inBattle) || 
                (Potions.Count > 0 && inBattle))
            {
                string option = "2";
                if (!inBattle) // if not in battle, give option to choose from weapons and armour too
                {
                    Console.WriteLine($"{World.BLUE}What do you wanna check?{World.RESET}");
                    Console.WriteLine($"{World.RED}--- Item Bag ---");
                    Console.WriteLine($"{World.BLUE}1.{World.RED} RETURN{World.RESET}");
                    Console.WriteLine($"{World.BLUE}2.{World.RESET} Potions");
                    Console.WriteLine($"{World.BLUE}3.{World.RESET} Weapons");
                    Console.WriteLine($"{World.BLUE}4.{World.RESET} Armour");
                    option = World.ChooseOption("1", "2", "3", "4");
                    Program.Refresh();
                }

                if (option == "1")
                {return;} // Exit inventory
                else if (option == "2")
                {
                    if (Potions.Count == 0)
                    { // if no potions
                        Console.WriteLine($"You have {World.RED}{World.BOLD}NO POTIONS{World.RESET} in your item bag");
                        Console.WriteLine("");
                        World.Continue();
                    } // if potions
                        else {ChoosePotion();}
                }
                else if (option == "3")
                {
                    if (Weapons.Count == 0)
                    { // if no weapons
                        Console.WriteLine($"You have {World.RED}{World.BOLD}NO WEAPONS{World.RESET} in your item bag");
                        Console.WriteLine("");
                        World.Continue();
                    } // if weapons
                        else {SwitchWeapon();}
                }
                else if (option == "4")
                {
                    if (Armours.Count == 0)
                    {  // if no armour
                        Console.WriteLine($"You have {World.RED}{World.BOLD}NO ARMOUR{World.RESET} in your item bag");
                        Console.WriteLine("");
                        World.Continue();
                    } // if armour
                        else {SwitchArmour();}
                }
            }
            else
            { // if no armour, weapons or potions
                Console.WriteLine($"Your item bag is {World.RED}{World.BOLD}EMPTY{World.RESET}");
                Console.WriteLine("");
                World.Continue();
                return;
            }
        } while (!inBattle);
    }
    
    public void SwitchArmour()
    {
        Console.WriteLine($"{World.BLUE}What do you wanna equip?{World.RESET}");
        Console.WriteLine($"{World.RED}--- Armour ---");
        Console.WriteLine($"{World.BLUE}1.{World.RED} RETURN{World.RESET}");
        int index = 2;
        foreach (Armour armour in Armours)
        { // Print out all armour
                Console.WriteLine($"{World.BLUE}{index}.{World.RESET} {armour.Name} - {World.BOLD}{armour.Rarity}{World.RESET} {World.BLUE}{World.DIM}({armour.Defense}% DEF){World.RESET}");
                index += 1;
        }
        // choose a number from 1 to the amount of armour you have
        string option = World.ChooseOption(Enumerable.Range(1, index).Select(x => x.ToString()).ToArray());
        if (option == "1")
            return;
        
        // replace current armour and add old armour back to inventory
        Armours.Add(Program.Player.CurrentArmour);
        Program.Player.CurrentArmour = Armours[int.Parse(option)-2];
        Armours.RemoveAt(int.Parse(option)-2);
        Program.Refresh();
        Console.WriteLine($"{World.YELLOW}You equipped {World.BOLD}{Program.Player.CurrentArmour.Name}!{World.RESET}");
        World.Continue();
        
    }
    
    public void SwitchWeapon()
    {
        Console.WriteLine($"{World.BLUE}What do you wanna equip?{World.RESET}");
        Console.WriteLine($"{World.RED}--- Weapons ---");
        Console.WriteLine($"{World.BLUE}1.{World.RED} RETURN{World.RESET}");
        int index = 2;
        foreach (Weapon weapon in Weapons)
        { // Print out all weapons
                Console.WriteLine($"{World.BLUE}{index}.{World.RESET} {weapon.Name} - {World.BOLD}{weapon.Rarity}{World.RESET} {World.RED}{World.DIM}({weapon.CurrentDamage} DMG){World.RESET}{World.YELLOW}{World.DIM}(Quality: {weapon.Quality}%){World.RESET}");
                index += 1;
        }
        // choose a number from 1 to the amount of weapons you have
        string option = World.ChooseOption(Enumerable.Range(1, index).Select(x => x.ToString()).ToArray());
        if (option == "1")
            return;
        
        // replace current weapon and add old weapon back to inventory
        Weapons.Add(Program.Player.CurrentWeapon);
        Program.Player.CurrentWeapon = Weapons[int.Parse(option)-2];
        Weapons.RemoveAt(int.Parse(option)-2);
        Program.Refresh();
        Console.WriteLine($"{World.YELLOW}You equipped {World.BOLD}{Program.Player.CurrentWeapon.Name}!{World.RESET}");
        World.Continue();
        
    }

    public void ChoosePotion()
    {
        Console.WriteLine($"{World.BLUE}What do you wanna use?{World.RESET}");
        Console.WriteLine($"{World.RED}--- Potions ---");
        Console.WriteLine($"{World.BLUE}1.{World.RED} RETURN{World.RESET}");
        int index = 2;
        foreach (Potion potion in Potions)
        { // print out all potions
                Console.WriteLine($"{World.BLUE}{index}.{World.RESET} {World.DIM}x{potion.Count}- {World.RESET}{potion.Name} {World.RED}{World.DIM}({potion.PotionDesc}){World.RESET} - {potion.Status}");
                index += 1;
        }
        string option = World.ChooseOption(Enumerable.Range(1, index).Select(x => x.ToString()).ToArray());
        if (option == "1")
            return;

        Program.Refresh();
        Potion usedPotion = Potions[int.Parse(option)-2];

        if (usedPotion.ID == 1) // for heal potion
        { // adds back hp
            Console.WriteLine($"You used a {World.YELLOW}{usedPotion.Name}!{World.RESET}");
            int healed = Program.Player.Heal(usedPotion.HealAmount);
            Console.WriteLine($"{World.RED}+{healed} HP{World.RESET}");
            World.Continue();
        }
        else if (usedPotion.ID == 2) // for mega heal potion
        { // adds back significant hp
            Console.WriteLine($"You used a {World.YELLOW}{usedPotion.Name}!{World.RESET}");
            int healed = Program.Player.Heal(usedPotion.HealAmount);
            Console.WriteLine($"{World.RED}+{healed} HP{World.RESET}");
            World.Continue();
            
        }
        else if (usedPotion.ID == 6) // for mystery potion
        {
            Console.WriteLine($"You used a {World.YELLOW}{usedPotion.Name}?{World.RESET}");
            if (World.RandomGenerator.Next(0,10) < 5)
            { // 50% chance to restore all hp
                Console.WriteLine($"{World.GREEN}FORTUNE!{World.RED} Your HP has been set to 100%!");
                int healed = Program.Player.Heal(Program.Player.MaximumHitPoints);
                Console.WriteLine($"{World.RED}+{healed} HP{World.RESET}");
            }
            else
            { // 50% chance to half your hp
                Console.WriteLine($"{World.RED}Disaster...{World.RESET} Your HP has been halved...");
                int damage = Program.Player.CurrentHitPoints / 2;
                Console.WriteLine($"{World.RED}-{Program.Player.TakeDamage(damage)} HP{World.RESET}");
            }
            World.Continue();
        } // Passive potions. Only usable once per battle
        // Check if passive potion is already active, if it is, return
        else if (Program.Player.PotionsActive.FindIndex(p => p.ID == usedPotion.ID) > -1)
        {
            Console.WriteLine($"{World.DIM}{World.RED}Potion already active!{World.RESET}");
            World.Continue();
            return;
        }
        else
        { // if not active, activate it
            Program.Player.PotionsActive.Add(usedPotion);
            Console.WriteLine($"{World.YELLOW}{usedPotion.Name} {World.BOLD}ACTIVATED!{World.RESET}");
            World.Continue();
        }
        // decrease potion count
        usedPotion.Count -= 1;
        if (usedPotion.Count == 0)
            Potions.Remove(usedPotion);
    }
}