public class Boxing : Game
{
    public override string Name => "Boxing";

    public override void PlayGame(GameState gameState) {
        Console.Clear();
        Random random = new Random();
        List<int> critNums = new List<int> { 0, 0, 0, 1, 1, 1, 1, 1, 1, 2 };
        string p1 = Constants.nameList[random.Next(Constants.nameList.Count)];
        string p2 = Constants.nameList[random.Next(Constants.nameList.Count)];

        Console.WriteLine($"{p1} and {p2} are boxing.");
        Console.WriteLine($"You have ${gameState.money}.");

        // Player 1 stats initialization
        int p1Defense = random.Next(0, 5), p1Health = random.Next(15, 21), p1Speed = random.Next(1, 11), p1Damage = random.Next(5, 11);
        Helpers.DisplayPlayerStats(gameState, p1, p1Damage, p1Defense, p1Health, p1Speed);

        // Player 2 stats initialization
        int p2Defense = random.Next(0, 5), p2Health = random.Next(15, 21), p2Speed = random.Next(1, 11), p2Damage = random.Next(5, 11);
        Helpers.DisplayPlayerStats(gameState, p2, p2Damage, p2Defense, p2Health, p2Speed);
        

        // Betting and game logic
        int bet;
        while (true)
        {
            Console.Write("Bet how much? ");
            try{
            bet = int.Parse(Console.ReadLine());
            }
            catch(Exception){
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
            if (guess == p1.ToLower() || guess == p2.ToLower())
            {
                break;
            }
            Console.WriteLine("You can't be indifferent!");
        }
        Console.Clear();
        while (p1Health > 0 && p2Health > 0)
        {
            Console.WriteLine($"    Health: {p1Health}");
            Console.WriteLine("|--------------|");
            Console.Write("|");
            for(int i = 0;i < 14 - p1.Length ;i++){
                Console.Write(" ");
                if(i==(14-p1.Length-1)/2)
                Console.Write(p1);
            }
            Console.WriteLine("|");
            Console.WriteLine("|              |");
            Console.WriteLine("|              |");
            Console.Write("|");
            for(int i = 0;i < 14 - p2.Length ;i++){
                Console.Write(" ");
                if(i==(14-p2.Length-1)/2)
                Console.Write(p2);
            }
            Console.WriteLine("|");
            Console.WriteLine("|--------------|");
            Console.WriteLine($"    Health: {p2Health}");
            Console.Write("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
            if (p1Speed > p2Speed)
            {
                // p1 attacks first
                int crit = critNums[random.Next(critNums.Count)];
                int damageDealt = crit * (p1Damage - p2Defense);
                Console.WriteLine($"{p1} does {damageDealt} damage to {p2}!");
                p2Health -= damageDealt;

                if (p2Health > 0)
                {
                    crit = critNums[random.Next(critNums.Count)];
                    damageDealt = crit * (p2Damage - p1Defense);
                    Console.WriteLine($"{p2} does {damageDealt} damage to {p1}!");
                    p1Health -= damageDealt;
                }
            }
            else if (p2Speed > p1Speed)
            {
                // p2 attacks first
                int crit = critNums[random.Next(critNums.Count)];
                int damageDealt = crit * (p2Damage - p1Defense);
                Console.WriteLine($"{p2} does {damageDealt} damage to {p1}!");
                p1Health -= damageDealt;

                if (p1Health > 0)
                {
                    crit = critNums[random.Next(critNums.Count)];
                    damageDealt = crit * (p1Damage - p2Defense);
                    Console.WriteLine($"{p1} does {damageDealt} damage to {p2}!");
                    p2Health -= damageDealt;
                }
            } else {
                int crit = critNums[random.Next(critNums.Count)];
                int damageDealt = crit * (p1Damage - p2Defense);
                Console.WriteLine($"{p1} does {damageDealt} damage to {p2}!");
                p2Health -= damageDealt;
                crit = critNums[random.Next(critNums.Count)];
                damageDealt = crit * (p2Damage - p1Defense);
                Console.WriteLine($"{p2} does {damageDealt} damage to {p1}!");
                p1Health -= damageDealt;
            }
            
        }
        Console.WriteLine("Game!");
        if ((guess == p1.ToLower() && p2Health <= 0) || (guess == p2.ToLower() && p1Health <= 0))
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
}