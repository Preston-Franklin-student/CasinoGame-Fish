public class Boxing : Game
{
    public override string Name => "Boxing";

    public override void PlayGame()
    {
        Console.Clear();
        Random random = new Random();
        List<int> critNums = new List<int> { 0, 0, 0, 1, 1, 1, 1, 1, 1, 2 };
        
        Player p1 = new();
        Player p2 = new();

        Console.WriteLine($"{p1.name} and {p2.name} are boxing.");
        Console.WriteLine($"You have ${gameState.money}.");

        DisplayPlayerStats(p1);
        DisplayPlayerStats(p2);


        // Betting and game logic
        int bet;
        while (true)
        {
            Console.Write("Bet how much? ");
            try
            {
                bet = int.Parse(Console.ReadLine());
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

        string guess;
        while (true)
        {
            Console.Write("On who? ");
            guess = Console.ReadLine().ToLower();
            if (guess == p1.name.ToLower() || guess == p2.name.ToLower())
            {
                break;
            }
            Console.WriteLine("You can't be indifferent!");
        }
        Console.Clear();
        while (p1.health > 0 && p2.health > 0)
        {
            Console.WriteLine($"    Health: {p1.health}");
            Console.WriteLine("|--------------|");
            Console.Write("|");
            for (int i = 0; i < 14 - p1.name.Length; i++)
            {
                Console.Write(" ");
                if (i == (14 - p1.name.Length - 1) / 2)
                    Console.Write(p1);
            }
            Console.WriteLine("|");
            Console.WriteLine("|              |");
            Console.WriteLine("|              |");
            Console.Write("|");
            for (int i = 0; i < 14 - p2.name.Length; i++)
            {
                Console.Write(" ");
                if (i == (14 - p2.name.Length - 1) / 2)
                    Console.Write(p2);
            }
            Console.WriteLine("|");
            Console.WriteLine("|--------------|");
            Console.WriteLine($"    Health: {p2.health}");
            Console.Write("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
            if (p1.speed > p2.speed)
            {
                // p1 attacks first
                int crit = critNums[random.Next(critNums.Count)];
                int damageDealt = crit * (p1.damage - p2.defense);
                Console.WriteLine($"{p1} does {damageDealt} damage to {p2}!");
                p2.health -= damageDealt;

                if (p2.health > 0)
                {
                    crit = critNums[random.Next(critNums.Count)];
                    damageDealt = crit * (p2.damage - p1.defense);
                    Console.WriteLine($"{p2} does {damageDealt} damage to {p1}!");
                    p1.health -= damageDealt;
                }
            }
            else if (p2.speed > p1.speed)
            {
                // p2 attacks first
                int crit = critNums[random.Next(critNums.Count)];
                int damageDealt = crit * (p2.damage - p1.defense);
                Console.WriteLine($"{p2} does {damageDealt} damage to {p1}!");
                p1.health -= damageDealt;

                if (p1.health > 0)
                {
                    crit = critNums[random.Next(critNums.Count)];
                    damageDealt = crit * (p1.damage - p2.defense);
                    Console.WriteLine($"{p1} does {damageDealt} damage to {p2}!");
                    p2.health -= damageDealt;
                }
            }
            else
            {
                int crit = critNums[random.Next(critNums.Count)];
                int damageDealt = crit * (p1.damage - p2.defense);
                Console.WriteLine($"{p1} does {damageDealt} damage to {p2}!");
                p2.health -= damageDealt;
                crit = critNums[random.Next(critNums.Count)];
                damageDealt = crit * (p2.damage - p1.defense);
                Console.WriteLine($"{p2} does {damageDealt} damage to {p1}!");
                p1.health -= damageDealt;
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
}