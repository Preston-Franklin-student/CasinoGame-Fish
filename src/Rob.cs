using System;
public static class Rob
{
    static int num1;
    static int num2;
    static int MathAnswer;
    static string PresAwnser;
    static string hint;
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
                    Console.WriteLine("You got Caught Trying to rob!");
                    return 0;
                }
            }
            else if (awnserB == "2")
            {
                if (Caught(2) == false) // have you been caught?
                {
                    if (VaultTwo() == true) // did you rob the vault?
                    {
                        return 2;   // you robbed vault 2
                    }
                    else
                    {
                        return 0;   // you failed to rob
                    }
                }
                else    // you got caught trying to rob
                {
                    Console.WriteLine("You got Caught Trying to rob!");
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
        Helpers.Typing("You come upon the first vault without being caught");
        Thread.Sleep(1000);
        Helpers.Typing("Next to the input you see a sticky note.");
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
        Helpers.Typing("Whats the answer");
        
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
        string op;
        int opselectr;
        opselectr = random.Next(1, 3);
        switch(opselectr) 
        {
        case 1:
            op = "*";
            MathAnswer = num1 * num2;
            return ($"{num1} * {num2}");
            break;
        case 2:
            op = "-";
            MathAnswer = num1 - num2;
            return ($"{num1} - {num2}");
            break;
        default:
            op = "+";
            MathAnswer = num1 + num2;
            return ($"{num1} + {num2}");
            break;
        }

    }
    #endregion

    #region Vault Two

    public static bool VaultTwo()
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
        Console.WriteLine("");
        Helpers.Typing("You come upon the first vault without being caught");
        Thread.Sleep(1000);
        Helpers.Typing("Next to the input you see a sticky note.");
        Thread.Sleep(1500);

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
        Console.WriteLine(@"               |    ___________________    |              ");
        if (isDrunk == true){
        Console.WriteLine($"               |    |  (,,𖦹~𖦹,,)?  |     |               ");
        Console.WriteLine(@"               |    |________________|     |              ");}
        else {
        Console.WriteLine(@"               |    | LN of the POTUS |    |              ");
        Console.WriteLine($"               |    | In june of {Pres()}  |    |          ");
        Console.WriteLine(@"               |    ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯    |              ");}
        Console.WriteLine(@"               |                           |              ");
        Console.WriteLine(@"               \___________________________/              ");

        Console.WriteLine("");
        Thread.Sleep(3000);
        Helpers.Typing(hint);
        Helpers.Typing("Whats the answer?");
        string responce = Console.ReadLine();
        if (responce == PresAwnser) // .ToLower()
        {
            Console.WriteLine("Correct!");
            return true;
        }
        else
        {
            return false;
        }
    }

    public static object Pres()
    {
        Random random = new Random();
        int year = random.Next(1789, 2024);
        string president = "frank"; 
        hint = "frank"; 

        // Use if-else conditions instead of switch to determine the president based on the year
        if (year >= 1789 && year <= 1797)
        {
            president = "Washington";
            hint = "First president";
        }
        else if (year >= 1797 && year <= 1801)
        {
            president = "Adams";
            hint = "Washington's vice president";
        }
        else if (year >= 1801 && year <= 1809)
        {
            president = "Jefferson";
            hint = "Wrote the Declaration of Independence";
        }
        else if (year >= 1809 && year <= 1817)
        {
            president = "Madison";
            hint = "Father of the Constitution";
        }
        else if (year >= 1817 && year <= 1825)
        {
            president = "Monroe";
            hint = "Monroe Doctrine";
        }
        else if (year >= 1825 && year <= 1829)
        {
            president = "Adams";
            hint = "Son of John Adams, 6th president";
        }
        else if (year >= 1829 && year <= 1837)
        {
            president = "Jackson";
            hint = "Old Hickory, Indian Removal Act";
        }
        else if (year >= 1837 && year <= 1841)
        {
            president = "Van Buren";
            hint = "Panic of 1837";
        }
        else if (year >= 1841 && year <= 1841)
        {
            president = "Harrison";
            hint = "Died 31 days into presidency";
        }
        else if (year >= 1841 && year <= 1845)
        {
            president = "Tyler";
            hint = "First vice president to succeed a president";
        }
        else if (year >= 1845 && year <= 1849)
        {
            president = "Polk";
            hint = "Manifest Destiny";
        }
        else if (year >= 1849 && year <= 1850)
        {
            president = "Taylor";
            hint = "General in the Mexican-American War";
        }
        else if (year >= 1850 && year <= 1853)
        {
            president = "Fillmore";
            hint = "Compromise of 1850";
        }
        else if (year >= 1853 && year <= 1857)
        {
            president = "Pierce";
            hint = "Kansas-Nebraska Act";
        }
        else if (year >= 1857 && year <= 1861)
        {
            president = "Buchanan";
            hint = "Last president before the Civil War";
        }
        else if (year >= 1861 && year <= 1865)
        {
            president = "Lincoln";
            hint = "Emancipation Proclamation";
        }
        else if (year >= 1865 && year <= 1869)
        {
            president = "Johnson";
            hint = "Impeached but acquitted";
        }
        else if (year >= 1869 && year <= 1877)
        {
            president = "Grant";
            hint = "Civil War general";
        }
        else if (year >= 1877 && year <= 1881)
        {
            president = "Hayes";
            hint = "Ended Reconstruction";
        }
        else if (year >= 1881 && year <= 1881)
        {
            president = "Garfield";
            hint = "Assassinated in office";
        }
        else if (year >= 1881 && year <= 1885)
        {
            president = "Arthur";
            hint = "Pendleton Act (Civil Service Reform)";
        }
        else if (year >= 1885 && year <= 1889)
        {
            president = "Cleveland";
            hint = "Only president to serve non-consecutive terms";
        }
        else if (year >= 1889 && year <= 1893)
        {
            president = "Harrison";
            hint = "Grandson of William Henry Harrison";
        }
        else if (year >= 1893 && year <= 1897)
        {
            president = "Cleveland";
            hint = "Only president to serve two non-consecutive terms";
        }
        else if (year >= 1897 && year <= 1901)
        {
            president = "McKinley";
            hint = "Spanish-American War";
        }
        else if (year >= 1901 && year <= 1909)
        {
            president = "Roosevelt";
            hint = "Progressive reforms, trust-busting";
        }
        else if (year >= 1909 && year <= 1913)
        {
            president = "Taft";
            hint = "Later became Chief Justice of the Supreme Court";
        }
        else if (year >= 1913 && year <= 1921)
        {
            president = "Wilson";
            hint = "World War I, League of Nations";
        }
        else if (year >= 1921 && year <= 1923)
        {
            president = "Harding";
            hint = "Teapot Dome scandal";
        }
        else if (year >= 1923 && year <= 1929)
        {
            president = "Coolidge";
            hint = "Pro-business, Silent Cal";
        }
        else if (year >= 1929 && year <= 1933)
        {
            president = "Hoover";
            hint = "Great Depression began under his watch";
        }
        else if (year >= 1933 && year <= 1945)
        {
            president = "Roosevelt";
            hint = "New Deal, World War II";
        }
        else if (year >= 1945 && year <= 1953)
        {
            president = "Truman";
            hint = "Dropped the atomic bomb";
        }
        else if (year >= 1953 && year <= 1961)
        {
            president = "Eisenhower";
            hint = "Cold War, Interstate Highway System";
        }
        else if (year >= 1961 && year <= 1963)
        {
            president = "Kennedy";
            hint = "Cuban Missile Crisis, Space Race";
        }
        else if (year >= 1963 && year <= 1969)
        {
            president = "Johnson";
            hint = "Great Society, Civil Rights Act";
        }
        else if (year >= 1969 && year <= 1974)
        {
            president = "Nixon";
            hint = "Watergate scandal";
        }
        else if (year >= 1974 && year <= 1977)
        {
            president = "Ford";
            hint = "Pardoned Nixon";
        }
        else if (year >= 1977 && year <= 1981)
        {
            president = "Carter";
            hint = "Camp David Accords";
        }
        else if (year >= 1981 && year <= 1989)
        {
            president = "Reagan";
            hint = "Cold War, Reaganomics";
        }
        else if (year >= 1989 && year <= 1993)
        {
            president = "Bush";
            hint = "Persian Gulf War";
        }
        else if (year >= 1993 && year <= 2001)
        {
            president = "Clinton";
            hint = "Balanced budget, Monica Lewinsky scandal";
        }
        else if (year >= 2001 && year <= 2009)
        {
            president = "Bush";
            hint = "9/11 attacks, Iraq War";
        }
        else if (year >= 2009 && year <= 2017)
        {
            president = "Obama";
            hint = "First African American president";
        }
        else if (year >= 2017 && year <= 2021)
        {
            president = "Trump";
            hint = "Business tycoon turned politician";
        }
        else if (year >= 2021 && year <= 2025)
        {
            president = "Biden";
            hint = "Oldest president elected";
        }

        return year;
    }




    #endregion
}