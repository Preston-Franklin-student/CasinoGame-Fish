using System;
public static class Rob
{
    static int num1;
    static int num2;
    static int MathAnswer;
    static bool isDrunk;
    public static int Play(bool isDrunkIn)
    {
        isDrunk = isDrunkIn;
        Console.Clear();
        Console.WriteLine("You've decided to rob the only place that brings you joy.");
        Console.WriteLine("There are severe consequences for armed robbery. Are you sure you want to continue?");
        Console.WriteLine("[Y/N]");
        string awnserA = Console.ReadLine();
        if (awnserA.Contains('n') || awnserA.Contains('N'))
        {
            return 4;
        }
        else if (awnserA.Contains('y') || awnserA.Contains('Y'))
        {
            Console.Clear();
            Console.WriteLine("There's three vaults in the casino.");
                Console.WriteLine("");
            Console.WriteLine("Vault One is a easy vault with little security, it has a math problem as a password.");
            Console.WriteLine("Vault Two [WIP] is a medium vault with some security, it  has a history question as a password.");
            Console.WriteLine("Vault Three [WIP] is a hard vault with lots of security, it has faulty code that needs solving as a password.");

            Console.WriteLine("");

            Console.WriteLine("Which do you want to rob? [1, 2, 3, Cancel]");
            string awnserB = Console.ReadLine();
            if (awnserB == "1")
            {
                if (Caught(1) == false) // have you been caught?
                {
                    if (VaultOne() == true) // did you rob the vault?
                    {
                        return 1;   // you robbed vault 1
                    }
                    else
                    {
                        return 0;   // you failed to rob vault 1
                    }
                }
                else    // you got caught trying to rob
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
            Play(isDrunk);
            return 4;
        }
    }
    static int chance;
    public static bool Caught(int VaultNumber)
    {
        Random random = new Random();
        if (VaultNumber == 1) {chance = random.Next(1, 11);} // 1/10 chance of being caught
        else if (VaultNumber == 2) {chance = random.Next(1, 6);} // 1/5 chance of being caught
        else if (VaultNumber == 3) {chance = random.Next(1, 3);} // 1/2 chance of being caught
        else {}
        if (chance == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    #region Vault One

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
        Typing("Next to the input you see a sticky note.");
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
        if (isDrunk == true){
        Console.WriteLine($"               |     |  (,,𖦹﹏𖦹,,)?   |    |              ");}
        else 
        {Console.WriteLine($"               |     | Whats {MathProblem()}? |    |              ");}
        Console.WriteLine(@"               |     |________________|    |              ");
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               \___________________________/              ");

        Console.WriteLine("");
        Thread.Sleep(3000);
        Typing("Whats the answer");
        
        if (int.Parse(Console.ReadLine()) == MathAnswer)
        {
            Console.WriteLine("Correct!");
            return true;
        }
        else
        {
            return false;
        }
    }

    public static object MathProblem()
    {
        Random random = new Random();
        num1 = random.Next(10, 100);
        num2 = random.Next(10, 100);
        MathAnswer = num1 + num2;

        return ($"{num1} + {num2}");

    }

    #endregion

    static void Typing(string words){
        foreach(char letter in words){
            Thread.Sleep(25);
            Console.Write(letter);
        }
        Console.WriteLine();
    }
}