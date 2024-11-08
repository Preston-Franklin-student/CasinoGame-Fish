public class CoinFlip : Game
{
    public override string Name => "Coin Flip";

    public override void PlayGame()
    {
        Console.Clear();
        Random jimmy = new Random();
        int amount = (int)(.30 * gameState.money);
        int multiply = 2;
        if (gameState.loseSwitch)
            multiply++;
        string name = Constants.nameList[jimmy.Next(Constants.nameList.Count)];
        Console.WriteLine($"{name} challenges you to a coin flip!\nThey bet you ${amount}!");
        while (true)
        {
            Console.Write("Do you accept? (yes or no): ");
            string purple = Console.ReadLine();
            if (purple.ToLower() == "yes")
            {
                Console.Write("Heads or Tails? (h or t): ");
                char picked = char.Parse(Console.ReadLine());
                while (true)
                {
                    if (picked != 'h' && picked != 't')
                    {
                        Console.WriteLine("That's not heads or tails!");
                        Console.Write("Heads or Tails? (h or t): ");
                        picked = char.Parse(Console.ReadLine());
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                string letters = "ht";
                Console.WriteLine("Flipping Coin!!");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("");
                int coinresult = jimmy.Next(0, 2);
                if (letters[coinresult] == picked)
                {
                    if (picked == 'h')
                    {
                        Console.WriteLine($"You were right it was heads!\nYou win ${amount}!");
                    }
                    else
                    {
                        Console.WriteLine($"You were right it was tails!\nYou win ${amount}!");
                    }
                    gameState.money += amount;
                }
                else
                {
                    if (picked == 't')
                    {
                        Console.WriteLine($"You were wrong it was heads!\nYou lose ${amount}!");
                    }
                    else
                    {
                        Console.WriteLine($"You were wrong it was tails!\nYou lose ${amount}!");
                    }
                    gameState.money -= amount;
                }
                Thread.Sleep(5000);
                break;
            }
            else if (purple.ToLower() == "no")
            {
                Console.WriteLine($"{name} doesn't like that! You robs you of ${amount * multiply}!");
                gameState.money -= amount * multiply;
                Thread.Sleep(5000);
                break;
            }
            else
            {
                Console.WriteLine("Hey that's not an option!");
                continue;
            }
        }
    }
}