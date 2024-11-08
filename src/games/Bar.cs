public class Bar : Game
{
    public override string Name => "Bar";

    public override void Play()
    {
        string? userAnswer;
        Console.Clear();
        if (gameState.drunkLevel <= 3)
        {
            Console.Write("You are at the bar.\nDo you want a drink for $10? (y/n): ");
            userAnswer = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You go back to the bar and order another dwink.");
            userAnswer = "y";
        }
        if (userAnswer == "y")
        {
            gameState.money -= 10;
            Random rand = new Random();
            int RandNum = rand.Next(1, 4);
            Thread.Sleep(1000);
            Console.Write("You take a drink.");
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine();
            Thread.Sleep(1000);
            if (RandNum == 1)
            {
                Console.WriteLine("You feel... drunk...");
                Thread.Sleep(4000);
                gameState.drunkLevel += 2;
            }
            else
            {
                Console.WriteLine("Nothing happens.");
                Thread.Sleep(4000);
                gameState.drunkLevel += 1;
            }
        }
        else
        {
            Console.WriteLine("You go to the bar yet don't even sit down.\nYou don't know what you are doing.");
            Thread.Sleep(4000);
        }
    }
}