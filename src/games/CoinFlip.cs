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
        char picked = 'n';
        try{
        Console.Write("Heads or Tails? (h or t): ");
        picked = char.Parse(Console.ReadLine()!);
        }
        catch(Exception){
        Console.WriteLine("That isn't a character");
        Thread.Sleep(5000);
        }
        while (picked != 'h' && picked != 't')
        {
            try{
            Console.WriteLine("That's not heads or tails!");
            Console.Write("Heads or Tails? (h or t): ");
            picked = char.Parse(Console.ReadLine()!);
            }
            catch{
                Thread.Sleep(5000);
            }
        }

        Console.WriteLine("Flipping Coin!!");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
        char result = rnd.Next(0, 2) == 1 ? 'h' : 't';
        string sResult = result == 'h' ? "heads" : "tails";

        if (result == picked)
        {

            Console.WriteLine($"You were right it was {sResult}!\nYou win ${amount}!");
            gameState.money += amount;
        }
        else
        {
            Console.WriteLine($"You were wrong it was {sResult}!\nYou lose ${amount}!");
            gameState.money -= amount;
        }
        Helpers.SkippableDelay(5000);
    }
}