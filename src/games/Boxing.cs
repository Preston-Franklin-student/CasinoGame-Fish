public class Boxing : Game
{
    public override string Name => "Boxing";

    public override void Play()
    {
        Console.Clear();
        Random random = new Random();
        List<int> critNums = new List<int> { 0, 0, 0, 1, 1, 1, 1, 1, 1, 2 };
        
        Player p1 = new();
        Player p2 = new();

        Console.WriteLine($"{p1.name} and {p2.name} are boxing.");
        Console.WriteLine($"You have ${gameState.money}.");



        // Betting and game logic
        int bet;
        while (true)
        {
            Console.Write("Bet how much? ");
            try
            {
                bet = int.Parse(Console.ReadLine() ?? "");
            }
            catch (Exception)
            {
                Console.WriteLine("Not a number!");
                continue;
            }
            if (bet > 0 && bet <= gameState.money)
            {
                break;
            }
            Console.WriteLine("Invalid bet!");
        }
        DisplayPlayerStats(p1);
        DisplayPlayerStats(p2);

        string? guess;
        while (true)
        {
            Console.Write("On who? ");
            guess = Console.ReadLine()?.ToLower();
            if (guess == p1.name.ToLower() || guess == p2.name.ToLower())
            {
                break;
            }
            Console.WriteLine("You can't be indifferent!");
        }
        Console.Clear();
        while (p1.health > 0 && p2.health > 0)
        {
            Console.Clear();
            Console.WriteLine("\n\n''-.            .-''\n  ò:            :ó\n...'            '...\n@O@%.O        O.%@O@\n&@@'*'        '*'@@&\n[][][][][][][][][][]");
            Console.WriteLine($"{p1.name}'s Health: {p1.health}\n{p2.name}'s Health: {p2.health}");

            Console.Write("Press enter to continue.");
            Console.ReadLine();

            if (p1.speed > p2.speed)
            {
                // p1 attacks first
                int crit = critNums[random.Next(critNums.Count)];
                int damageDealt = crit * (p1.damage - p2.defense);
                
                if (p2.health - damageDealt > 0)
                {
                    P1Attack();
                    Console.Clear();
                    Console.WriteLine("\n\n''-.            .-''\n  ò:            :ó\n...'            '...\n@O@%.O        O.%@O@\n&@@'*'        '*'@@&\n[][][][][][][][][][]");
                    
                    Console.WriteLine($"{p1.name} does {damageDealt} damage to {p2.name}!");
                    p2.health -= damageDealt;

                    Thread.Sleep(1500);
                }
                else
                {
                    P2Out();
                    p2.health -= damageDealt;
                }

                if (p2.health > 0)
                {
                    crit = critNums[random.Next(critNums.Count)];
                    damageDealt = crit * (p2.damage - p1.defense);

                    if (p1.health - damageDealt > 0)
                    {
                        P2Attack();
                        Console.Clear();
                        Console.WriteLine("\n\n''-.            .-''\n  ò:            :ó\n...'            '...\n@O@%.O        O.%@O@\n&@@'*'        '*'@@&\n[][][][][][][][][][]");

                        Console.WriteLine($"{p2.name} does {damageDealt} damage to {p1.name}!");
                        p1.health -= damageDealt;

                        Thread.Sleep(1500);
                    }
                    else
                    {
                        P1Out();
                        p1.health -= damageDealt;
                    }
                }
            }
            else if (p2.speed > p1.speed)
            {
                // p2 attacks first
                int crit = critNums[random.Next(critNums.Count)];
                int damageDealt = crit * (p2.damage - p1.defense);

                if (p1.health - damageDealt > 0)
                {
                    P2Attack();
                    Console.Clear();
                    Console.WriteLine("\n\n''-.            .-''\n  ò:            :ó\n...'            '...\n@O@%.O        O.%@O@\n&@@'*'        '*'@@&\n[][][][][][][][][][]");

                    Console.WriteLine($"{p2.name} does {damageDealt} damage to {p1.name}!");
                    p1.health -= damageDealt;
                    
                    Thread.Sleep(1500);
                }
                else
                {
                    P1Out();
                    p1.health -= damageDealt;
                }

                if (p1.health > 0)
                {
                    crit = critNums[random.Next(critNums.Count)];
                    damageDealt = crit * (p1.damage - p2.defense);

                    if (p2.health - damageDealt > 0)
                    {
                        P1Attack();
                        Console.Clear();
                        Console.WriteLine("\n\n''-.            .-''\n  ò:            :ó\n...'            '...\n@O@%.O        O.%@O@\n&@@'*'        '*'@@&\n[][][][][][][][][][]");

                        Console.WriteLine($"{p1.name} does {damageDealt} damage to {p2.name}!");
                        p2.health -= damageDealt;
                        
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        P2Out();
                        p2.health -= damageDealt;
                    }
                }
            }
            else
            {
                int crit = critNums[random.Next(critNums.Count)];
                int damageDealt = crit * (p1.damage - p2.defense);

                if (p2.health - damageDealt > 0)
                {
                    P1Attack();
                    Console.Clear();
                    Console.WriteLine("\n\n''-.            .-''\n  ò:            :ó\n...'            '...\n@O@%.O        O.%@O@\n&@@'*'        '*'@@&\n[][][][][][][][][][]");

                    Console.WriteLine($"{p1.name} does {damageDealt} damage to {p2.name}!");
                    p2.health -= damageDealt;

                    Thread.Sleep(1500);
                }
                else
                {
                    P2Out();
                    p2.health -= damageDealt;
                }

                if (p2.health > 0)
                {
                    crit = critNums[random.Next(critNums.Count)];
                    damageDealt = crit * (p2.damage - p1.defense);

                    if (p1.health - damageDealt > 0)
                    {
                        P2Attack();
                        Console.Clear();
                        Console.WriteLine("\n\n''-.            .-''\n  ò:            :ó\n...'            '...\n@O@%.O        O.%@O@\n&@@'*'        '*'@@&\n[][][][][][][][][][]");

                        Console.WriteLine($"{p2.name} does {damageDealt} damage to {p1.name}!");
                        p1.health -= damageDealt;

                        Thread.Sleep(1500);
                    }
                    else
                    {
                        P1Out();
                        p1.health -= damageDealt;
                    }
                }
            }
        }
        Console.WriteLine("Game!");
        if ((guess == p1.name.ToLower() && p2.health <= 0) || (guess == p2.name.ToLower() && p1.health <= 0))
        {
            gameState.money += bet;
            Console.WriteLine($"You were right! You win ${bet}!\nYou now have ${gameState.money}.");
        }
        else
        {
            gameState.money -= bet;
            Console.WriteLine($"You were wrong! You lose ${bet}!\nYou now have ${gameState.money}.");
        }

        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
    }

    private void DisplayPlayerStats(Player p)
    {
        string[] stats = { p.damage.ToString(), p.defense.ToString(), p.health.ToString(), p.speed.ToString() };

        if (gameState.loseSwitch)
        {
            for (int i = 0; i < stats.Length; i++)
                stats[i] = "?";
        }
        else
        {
            Random random = new Random();
            int unknown = random.Next(0, 4);

            stats[unknown] = "?";
        }


        Console.WriteLine($"{p.name}'s stats:");
        Console.WriteLine($"Attack: {stats[0]}");
        Console.WriteLine($"Defense: {stats[1]}");
        Console.WriteLine($"Health: {stats[2]}");
        Console.WriteLine($"Speed: {stats[3]}");
    }

    private class Player {
        private static Random rnd = new();

        public readonly string name = Constants.nameList[rnd.Next(Constants.nameList.Count)];
        public readonly int defense = rnd.Next(0, 5);
        public readonly int speed = rnd.Next(1, 11);
        public readonly int damage = rnd.Next(5, 11);

        public int health = rnd.Next(15, 21);
    }

    //Animations and other art - DO NOT TOUCH

    /*Idle
                    \n
                    \n
''-.            .-''\n
  ò:            :ó  \n
...'            '...\n
@O@%.O        O.%@O@\n
&@@'*'        '*'@@&\n
[][][][][][][][][][]~
    */

    public void P1Attack()
    {
        int frameRate = 50;
        
        Console.Clear();
        Console.WriteLine("\n__\n''''.           .-''\n  ò :           :ó\n.  .'..O        '...\n@O@@@@@'      O.%@O@\n&@@&*         '*'@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n _._\n.' ''.          .-''\n  ò ó:          :o\n'.  .' ..()     '...\n%@@@@@@@&'    O.%@O@\n@O@@&*        '*'@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n  _._\n.'' ''.         .-''\n  ò ó :    _    : -\n'.   .' .=( )   '...\n%@@@@@@@@&%'  O.%@@O\n@O@@@&%*'     '*'@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n   _._\n .'' ''.        .-''\n:  ò ó :      ..:> <\n '.   .' ..=%:  :. .\n %@@@@@@@@@@@&*:%@@O\n @O@@@@@&%*'  '*'@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n   _._\n .'' ''.        .-''\n:  ò ó :      ..:> <\n '.   .' ..=%:  :. .\n %@@@@@@@@@@@&*:%@@O\n @O@@@@@&%*'  '*'@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n   _._\n .'' ''.        .-''\n:  ò ó :      ..:> <\n '.   .' ..=%:  :. .\n %@@@@@@@@@@@&*:%@@O\n @O@@@@@&%*'  '*'@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n  _._\n.'' ''.         .-''\n  ò ó :    _    :> <\n'.   .' .=( )   '. .\n%@@@@@@@@&%'  O.%@@O\n@O@@@&%*'     '*'@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n _._\n.' ''.          .-''\n  ò ó:          : -\n'.  .' ..()     '...\n%@@@@@@@&'    O.%@O@\n@O@@&*        '*'@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n__\n''''.           .-''\n  ò :           :o\n.  .'..O        '...\n@O@@@@@'      O.%@O@\n&@@&*         '*'@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);
    }
    
    public void P2Attack()
    {
        int frameRate = 50;
        
        Console.Clear();
        Console.WriteLine("\n                  __\n''-.           .''''\n  ò:           : ó\n...'        O..'.  .\n@O@%.O      '@@@@@O@\n&@@'*'         *&@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n                _._\n''-.          .'' '.\n  o:          :ò ó\n...'     ().. '.  .'\n@O@%.O    '&@@@@@@@%\n&@@'*'        *&@@O@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n               _._\n''-.         .'' ''.\n - :    _    : ò ó\n...'   ( )=. '.   .'\nO@@%.O  '%&@@@@@@@@%\n&@@'*'     '*%&@@@O@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n              _._\n''-.        .'' ''.\n> <:..  _   : ò ó  :\n. .:  :%=.. '.   .'\nO@@%:*&@@@@@@@@@@@%\n&@@'*'  '*%&@@@@@O@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n              _._\n''-.        .'' ''.\n> <:..  _   : ò ó  :\n. .:  :%=.. '.   .'\nO@@%:*&@@@@@@@@@@@%\n&@@'*'  '*%&@@@@@O@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n              _._\n''-.        .'' ''.\n> <:..  _   : ò ó  :\n. .:  :%=.. '.   .'\nO@@%:*&@@@@@@@@@@@%\n&@@'*'  '*%&@@@@@O@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n               _._\n''-.         .'' ''.\n> <:    _    : ò ó\n. .'   ( )=. '.   .'\nO@@%.O  '%&@@@@@@@@%\n&@@'*'     '*%&@@@O@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n                _._\n''-.          .'' '.\n - :          :ò ó\n...'     ().. '.  .'\n@O@%.O    '&@@@@@@@%\n&@@'*'        *&@@O@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n                  __\n''-.           .''''\n  o:           : ó\n...'        O..'.  .\n@O@%.O      '@@@@@O@\n&@@'*'         *&@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);
    }

    public void P1Out()
    {
        int frameRate = 50;
        
        Console.Clear();
        Console.WriteLine("\n                  __\n''-.           .''''\n  ò:           : ó\n...'        O..'.  .\n@O@%.O      '@@@@@O@\n&@@'*'         *&@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n                _._\n''-.          .'' '.\n  o:          :ò ó\n...'     ().. '.  .'\n@O@%.O    '&@@@@@@@%\n&@@'*'        *&@@O@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n               _._\n''-.         .'' ''.\n - :    _    : ò ó\n...'   ( )=. '.   .'\nO@@%.O  '%&@@@@@@@@%\n&@@'*'     '*%&@@@O@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n              _._\n''-.        .'' ''.\n> <:..  _   : ò ó  :\n. .:  :%=.. '.   .'\nO@@%:*&@@@@@@@@@@@%\n&@@'*'  '*%&@@@@@O@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n              _._\n'-.         .'' ''.\n - :..  _   : ò ó  :\n _.:  :%=.. '.   .'\n@@@:'*&@@@@@@@@@@@%\n@@@**'  '*%&@@@@@O@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n              _._\n-.          .'' ''.\n_ : ..  _   : ò ó  :\n  ::  :%=.. '.   .'\n%%@#'*&@@@@@@@@@@@%\n@@@%=O  '*%&@@@@@O@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n              _._\n.           .'' ''.\n '. ..  _   : ò ó  :\n  ::  :%=.. '.   .'\n.%@.'*&@@@@@@@@@@@%\n@@@%:   '*%&@@@@@O@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n              _._\n            .'' ''.\n'.  ..  _   : ò ó  :\n : :  :%=.. '.   .'\n.@. '*&@@@@@@@@@@@%\n@@&     '*%&@@@@@O@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n              _._\n            .'' ''.\n    ..  _   : ò ó  :\n.  :  :%=.. '.   .'\n&   '*&@@@@@@@@@@@%\n@.      '*%&@@@@@O@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n              _._\n            .'' ''.\n    ..  _   : ò ó  :\n   :  :%=.. '.   .'\n    '*&@@@@@@@@@@@%\n        '*%&@@@@@O@\n[][][][][][][][][][]");
        Thread.Sleep(1300);

        Console.Clear();
        Thread.Sleep(1000);
    }

    public void P2Out()
    {
        int frameRate = 50;
        
        Console.Clear();
        Console.WriteLine("\n__\n''''.           .-''\n  ò :           :ó\n.  .'..O        '...\n@O@@@@@'      O.%@O@\n&@@&*         '*'@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n _._\n.' ''.          .-''\n  ò ó:          :o\n'.  .' ..()     '...\n%@@@@@@@&'    O.%@O@\n@O@@&*        '*'@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n  _._\n.'' ''.         .-''\n  ò ó :    _    : -\n'.   .' .=( )   '...\n%@@@@@@@@&%'  O.%@@O\n@O@@@&%*'     '*'@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n   _._\n .'' ''.        .-''\n:  ò ó :      ..:> <\n '.   .' ..=%:  :. .\n %@@@@@@@@@@@&*:%@@O\n @O@@@@@&%*'  '*'@@&\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n   _._\n .'' ''.         .-'\n:  ò ó :      ..: -\n '.   .' ..=%:  :._\n %@@@@@@@@@@@&*':@@@\n @O@@@@@&%*'  '**@@@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n   _._\n .'' ''.          .-\n:  ò ó :      .. : _\n '.   .' ..=%:  ::\n %@@@@@@@@@@@&*'#@%%\n @O@@@@@&%*'  O=%@@@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n   _._\n .'' ''.           .\n:  ò ó :      .. .'\n '.   .' ..=%:  ::\n %@@@@@@@@@@@&*'.@%.\n @O@@@@@&%*'   :%@@@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n   _._\n .'' ''.\n:  ò ó :      ..  .'\n '.   .' ..=%:  : :\n %@@@@@@@@@@@&*' .@.\n @O@@@@@&%*'     &@@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n   _._\n .'' ''.\n:  ò ó :      ..\n '.   .' ..=%:  :  .\n %@@@@@@@@@@@&*'   &\n @O@@@@@&%*'      .@\n[][][][][][][][][][]");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n   _._\n .'' ''.\n:  ò ó :      ..\n '.   .' ..=%:  :\n %@@@@@@@@@@@&*'\n @O@@@@@&%*'\n[][][][][][][][][][]");
        Thread.Sleep(1300);

        Console.Clear();
        Thread.Sleep(1000);
    }
}