using System;
public static class Rob
{
    public static int Play()
    {
        Console.Clear();
        Console.WriteLine("You've decided to rob the only place that brings you joy.");
        Console.WriteLine("There are severe consequences for armed robbery. Are you sure you want to continue?");
        Console.WriteLine("[Y/N]");
        string awnserA = Console.ReadLine();
        if (awnserA.ToLower().Contains('n'))
        {
            return 4;
        }
        else if (awnserA.ToLower().Contains('y'))
        {
            Console.Clear();
            Console.WriteLine("There's three vaults in the casino.");
                Console.WriteLine("");
            Console.WriteLine("Vault One is a easy vault with little security, it has a math problem as a password.");
            Console.WriteLine("Vault Two is a medium vault with some security, it  has a history question as a password.");
            Console.WriteLine("Vault Three is a hard vault with lots of security, it has faulty code that needs solving as a password.");

            Console.WriteLine("");

            Console.WriteLine("Which do you want to rob? [1, 2, 3, Cancel]");
            string awnserB = Console.ReadLine();
            if (awnserB == "1")
            {
                if (VaultOne() == true)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (awnserB == "2")
            {
                if (VaultOne() == true)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (awnserB == "3")
            {
                if (VaultOne() == true)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else 
            {
                return 4;
            }
        }
        else 
        {
            Play();
            return 4;
        }
    }
    
    public static bool VaultOne()
    {
        Console.WriteLine(@"             _______________________________________              ");
        Console.WriteLine(@"            /                                       \             ");
        Console.WriteLine(@"           /                                         \            ");
        Console.WriteLine(@"          |                                           |           ");
        Console.WriteLine(@"          |              _______________              |           ");
        Console.WriteLine(@"          |             |               |             |           ");
        Console.WriteLine(@"          |             |   VAULT   1   |             |           ");
        Console.WriteLine(@"          |             |_______________|             |           ");
        Console.WriteLine(@"          |             |      ___      |             |           ");
        Console.WriteLine(@"          |             |     /   \     |             |           ");
        Console.WriteLine(@"          |             |     | : |     |             |           ");
        Console.WriteLine(@"          |             |     \___/     |             |           ");
        Console.WriteLine(@"          |             |_______________|             |           ");
        Console.WriteLine(@"          |                                           |           ");
        Console.WriteLine(@"          \                                           /           ");
        Console.WriteLine(@"           \_________________________________________/            ");

        Thread.Sleep(1000);
        Console.WriteLine("");
        Typing("You come upon the first vault without being caught");
        Thread.Sleep(1000);
        Typing("next to the input you see a sticky note.");
        Thread.Sleep(1500);

        Console.WriteLine(@"                ___________________________               ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               |          VAULT 1          |              ");
        Console.WriteLine(@"               |___________________________|              ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               |      [ INPUT PANEL ]      |              ");
        Console.WriteLine(@"               |      ________________     |              ");
        Console.WriteLine(@"               |     |                |    |              ");
        Console.WriteLine(@"               |     |   Enter Code   |    |              ");
        Console.WriteLine(@"               |     |________________|    |              ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               |          **NOTE**         |              ");
        Console.WriteLine(@"               |      ________________     |              ");
        Console.WriteLine($"               |     | Whats 83 + 42? |    |              ");
        Console.WriteLine(@"               |     |________________|    |              ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               \___________________________/              ");

        Console.WriteLine("");
        Thread.Sleep(3000);
        Typing("Whats the Awnser");
        
        if (Console.ReadLine() == "125")
        {
            Console.WriteLine("Correct!");
            return true;
        }
        else
        {
            return false;
        }
    }
    #region maybe
    /*
    public static void VaultTwo()
    {
        Console.WriteLine(@"             _______________________________________              ");
        Console.WriteLine(@"            /                                       \             ");
        Console.WriteLine(@"           /                                         \            ");
        Console.WriteLine(@"          |                                           |           ");
        Console.WriteLine(@"          |              _______________              |           ");
        Console.WriteLine(@"          |             |               |             |           ");
        Console.WriteLine(@"          |             |   VAULT   2   |             |           ");
        Console.WriteLine(@"          |             |_______________|             |           ");
        Console.WriteLine(@"          |             |      ___      |             |           ");
        Console.WriteLine(@"          |             |     /   \     |             |           ");
        Console.WriteLine(@"          |             |     | : |     |             |           ");
        Console.WriteLine(@"          |             |     \___/     |             |           ");
        Console.WriteLine(@"          |             |_______________|             |           ");
        Console.WriteLine(@"          |                                           |           ");
        Console.WriteLine(@"          \                                           /           ");
        Console.WriteLine(@"           \_________________________________________/            ");

        Thread.Sleep(1000);
        Console.WriteLine("")
        Typing("You come upon the first vault without being caught");
        Typing("next to the input you see a sticky note.")

        Console.WriteLine(@"                ___________________________               ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               |          VAULT 2          |              ");
        Console.WriteLine(@"               |___________________________|              ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               |      [ INPUT PANEL ]      |              ");
        Console.WriteLine(@"               |      ________________     |              ");
        Console.WriteLine(@"               |     |                |    |              ");
        Console.WriteLine(@"               |     |   Enter Code   |    |              ");
        Console.WriteLine(@"               |     |________________|    |              ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               |          **NOTE**         |              ");
        Console.WriteLine(@"               |      ________________     |              ");
        Console.WriteLine($"               |     | Whats {Two('q')}? |    |              ");
        Console.WriteLine(@"               |     |________________|    |              ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               \___________________________/              ");

    }
    public static void VaultThree()
    {
        Console.WriteLine(@"             _______________________________________              ");
        Console.WriteLine(@"            /                                       \             ");
        Console.WriteLine(@"           /                                         \            ");
        Console.WriteLine(@"          |                                           |           ");
        Console.WriteLine(@"          |              _______________              |           ");
        Console.WriteLine(@"          |             |               |             |           ");
        Console.WriteLine(@"          |             |   VAULT   3   |             |           ");
        Console.WriteLine(@"          |             |_______________|             |           ");
        Console.WriteLine(@"          |             |      ___      |             |           ");
        Console.WriteLine(@"          |             |     /   \     |             |           ");
        Console.WriteLine(@"          |             |     | : |     |             |           ");
        Console.WriteLine(@"          |             |     \___/     |             |           ");
        Console.WriteLine(@"          |             |_______________|             |           ");
        Console.WriteLine(@"          |                                           |           ");
        Console.WriteLine(@"          \                                           /           ");
        Console.WriteLine(@"           \_________________________________________/            ");

        Thread.Sleep(1000);
        Console.WriteLine("")
        Typing("You come upon the first vault without being caught");
        Typing("next to the input you see a sticky note.")

        Console.WriteLine(@"                ___________________________               ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               |          VAULT 3          |              ");
        Console.WriteLine(@"               |___________________________|              ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               |      [ INPUT PANEL ]      |              ");
        Console.WriteLine(@"               |      ________________     |              ");
        Console.WriteLine(@"               |     |                |    |              ");
        Console.WriteLine(@"               |     |   Enter Code   |    |              ");
        Console.WriteLine(@"               |     |________________|    |              ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               |          **NOTE**         |              ");
        Console.WriteLine(@"               |      ________________     |              ");
        Console.WriteLine($"               |     | Whats {Three('q')}? |    |              ");
        Console.WriteLine(@"               |     |________________|    |              ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               \___________________________/              ");

    }
    */
    #endregion

    static void Typing(string words){
        foreach(char letter in words){
            Thread.Sleep(25);
            Console.Write(letter);
        }
        Console.WriteLine();
    }
}