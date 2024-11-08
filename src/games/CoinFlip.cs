public class CoinFlip : Game
{
    public override string Name => "Coin Flip";

    public override void Play()
    {
        Console.Clear();
        Random rnd = new Random();
        int amount = (int)(gameState.money * 0.30);
        int multiply = 2;
        if (gameState.loseSwitch)
            multiply++;

        string name = Constants.nameList[rnd.Next(Constants.nameList.Count)];
        Console.WriteLine($"{name} challenges you to a coin flip!\nThey bet you ${amount}!");
        
        while (!Helpers.AskYesNo("Do you accept? (yes or no): ")) {
            Console.WriteLine($"{name} doesn't like that! {name} robs you of ${amount * multiply}!");
            gameState.money -= amount * multiply;
            Helpers.SkippableDelay(5000);
        }

        Console.Write("Heads or Tails? (h or t): ");
        char picked = char.Parse(Console.ReadLine()!);
        while (picked != 'h' && picked != 't')
        {
            Console.WriteLine("That's not heads or tails!");
            Console.Write("Heads or Tails? (h or t): ");
            picked = char.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("Flipping Coin!!");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
        char result = rnd.Next(0, 2) == 1 ? 'h' : 't';

        if (result == picked)
        {
            Console.WriteLine($"You were right it was {result}!\nYou win ${amount}!");
            gameState.money += amount;
        }
        else
        {
            Console.WriteLine($"You were wrong it was {result}!\nYou lose ${amount}!");
            gameState.money -= amount;
        }
        Helpers.SkippableDelay(5000);
    }
}